using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace RPCGeneration
{
    public partial class frmMethodView : Form
    {
        //System.Diagnostics.Process.Start("process");
        List<Method> Methods = new List<Method>();

        public frmMethodView()
        {
            InitializeComponent();

            // Add columns
            lstParams.Columns.Add("Endpoint", -2, HorizontalAlignment.Left);
            lstParams.Columns.Add("Datatype", -2, HorizontalAlignment.Left);
            lstParams.Columns.Add("Name", -2, HorizontalAlignment.Left);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMethodDialog methodDialog = new frmMethodDialog();

            if (methodDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (methodDialog.Successful())
                {
                    Methods.Add(methodDialog.GetMethod());
                    UpdateListDisplay();
                }
            }
        }

        private void UpdateListDisplay()
        {
            lstMethods.Items.Clear();

            foreach (Method method in Methods)
            {
                lstMethods.Items.Add(method.MethodName);               
            }
        }

        private void lstMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstParams.Clear();

            lstParams.Columns.Add("Endpoint", 80, HorizontalAlignment.Left);
            lstParams.Columns[0].Width = 80;
            lstParams.Columns.Add("Datatype", 80, HorizontalAlignment.Left);
            lstParams.Columns.Add("Name", -2, HorizontalAlignment.Left);

            if (lstMethods.SelectedItem != null)
            {
                foreach (Method method in Methods)
                {
                    if (method.MethodName == lstMethods.SelectedItem.ToString())
                    {
                        foreach (Parameter param in method.Parameters)
                        {
                            ListViewItem newItem = new ListViewItem(new[] { param.ParameterEndpoint, param.ParameterDatatype, param.ParameterName });
                            lstParams.Items.Add(newItem);
                        }
                        break;
                    }
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(ValidInterface())
            {
                string folderPath;

                if (dlgFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string acf = Path.Combine(dlgFolder.SelectedPath, txtInterfaceName.Text + ".acf");
                    string idl = Path.Combine(dlgFolder.SelectedPath, txtInterfaceName.Text + ".idl");

                    folderPath = dlgFolder.SelectedPath;

                    DialogResult result;

                    if (File.Exists(acf))
                    {
                        result = MessageBox.Show(txtInterfaceName.Text + ".acf already exists. Do you want to overwrite it?",
                            "Overwrite .acf?", MessageBoxButtons.YesNo);

                        if (result == System.Windows.Forms.DialogResult.No)
                            return;
                    }

                    if (File.Exists(idl))
                    {
                        result = MessageBox.Show(txtInterfaceName.Text + ".idl already exists. Do you want to overwrite it?",
                            "Overwrite .idl?", MessageBoxButtons.YesNo);

                        if (result == System.Windows.Forms.DialogResult.No)
                            return;
                    }

                    if (CreateACFAndIDL(acf, idl) == 0)
                    {
                         ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");

                        startInfo.UseShellExecute = false;
                        startInfo.RedirectStandardInput = true;
                        startInfo.RedirectStandardOutput = true;
                        //startInfo.CreateNoWindow = true;
                        string runPath = "%comspec% /k \"C:\\Program Files (x86)\\Microsoft Visual Studio 11.0\\VC\\vcvarsall.bat\"";
                        string docPath = "cd \"" + folderPath + "\"";

                       // startInfo.Arguments = runPath + " " + docPath;

                        try
                        {
                            
                            // Start the process with the info we specified.
                            // Call WaitForExit and then the using statement will close.
                            using (Process exeProcess = Process.Start(startInfo))
                            {                               
                                exeProcess.StandardInput.WriteLine(runPath);//" /cpp_cmd  " + clFilePath + idl);
                                exeProcess.StandardInput.WriteLine(docPath);

                                exeProcess.StandardInput.WriteLine("midl " + txtInterfaceName.Text + ".idl");

                                exeProcess.WaitForExit(2000);
                                exeProcess.CloseMainWindow();
                                
                                string outputString = exeProcess.StandardOutput.ReadToEnd();// 
                            }                           

                        }
                        catch(Exception ex)
                        {
                            string outputString = ex.Message;
                        }
                        //midlProcess.StandardInput.WriteLine("midl " + idl);
                        
                    }


                }
            }
        }

        private int CreateACFAndIDL(string acfFilePath, string idlFilePath)
        {
            Guid guid = Guid.NewGuid();
            string handle = "";
            
            if(rdbExplicit.Checked == true)
                handle = "explicit_handle";
            else if(rdbImplicit.Checked == true)
                handle = "implicit_handle(handle_t hMyHandle)";

            //The lines that the ACF file is composed of.
            string[] acfLines = { "//File " + txtInterfaceName.Text + ".acf", "[", 
                                    "//This interface will use " + handle + " handle", 
                                    handle, "]", 
                                    "interface " + txtInterfaceName.Text, "{\n}" };

            string[] idlHeader = {"//" + txtInterfaceName.Text + ".idl",
                                    "[", "uuid(" + guid + "),",
                                    "version(" + txtVersionNumber.Text + ")", "]"};

            List<string> idlLines = new List<string>(idlHeader);

            idlLines.Add("interface " + txtInterfaceName.Text);
            idlLines.Add("{");

            idlLines.AddRange(TranslateMethodsToIDL());

            idlLines.Add("}");

            try
            {
                File.WriteAllLines(acfFilePath, acfLines);
                File.WriteAllLines(idlFilePath, idlLines);
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.Message);
                return - 1;
            }

            MessageBox.Show("Files Created Successfully");
            return 0;
        }

        private string[] TranslateMethodsToIDL()
        {
            List<string> idlMethods = new List<string>();

            foreach (Method method in Methods)
            {
                string methodString = "void ";

                methodString += method.MethodName + "(";

                if (method.Parameters.Count > 0)
                {
                    for (int i = 0; i < method.Parameters.Count; i++)
                    {
                        methodString += method.Parameters[i].ParameterEndpoint + " ";
                        methodString += method.Parameters[i].ParameterDatatype + " ";
                        methodString += method.Parameters[i].ParameterName + " ";
                        
                        if (i != method.Parameters.Count - 1)
                            methodString += ", ";
                        else
                            methodString += ");";
                    }
                }
                else
                    methodString += "void);";

                idlMethods.Add(methodString);
            }

            return idlMethods.ToArray();
        }

        private bool ValidInterface()
        {
            if (txtInterfaceName.Text == String.Empty)
            {
                MessageBox.Show("Class Name cannot be empty");
                return false;
            }

            for (int i = 0; i < txtInterfaceName.Text.Length; i++)
            {
                if (i == 0)
                {
                    if (!Char.IsLetter(txtInterfaceName.Text, i))
                    {
                        MessageBox.Show("Class Name must start with a letter");
                        return false;
                    }
                }

                if (!Char.IsLetterOrDigit(txtInterfaceName.Text, i))
                {
                    MessageBox.Show("Class Name can only be letters and numbers with no spaces");
                    return false;
                }
            }

            if (Methods.Count == 0)
            {
                MessageBox.Show("Having no methods defeats the purpose of RPC");
                return false;
            }

            if(txtVersionNumber.TextLength > 0)
            {
                for (int i = 0; i < txtVersionNumber.TextLength; i++)
                {
                    if(!Char.IsNumber(txtVersionNumber.Text, i) && txtVersionNumber.Text[i] != '.')
                    {
                        MessageBox.Show("The version number must be in a format similar to 1.0.0." + 
                            " Number of periods and digits is optional");
                        return false;
                    }
                }
            }            

            //Set default version number
            if(txtVersionNumber.Text == String.Empty)
            {
                txtVersionNumber.Text = "1.0";
            }

            return true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstMethods.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove the selected method?", "Remove Parameter Confirm",
                   MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Methods.RemoveAt(lstMethods.SelectedIndices[0]);
                    lstMethods.Items.RemoveAt(lstMethods.SelectedIndices[0]);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstMethods.SelectedIndices.Count > 0)
            {
                frmMethodDialog methodDialog = new frmMethodDialog(Methods[lstMethods.SelectedIndices[0]]);

                if (methodDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (methodDialog.Successful())
                    {
                        Methods[lstMethods.SelectedIndices[0]] = methodDialog.GetMethod();
                        lstMethods.SelectedIndices.Clear();
                        UpdateListDisplay();
                    }
                }
            }
        }

        private void frmMethodView_Load(object sender, EventArgs e)
        {
        
        }

        private void frmMethodView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //foreach (Process process in System.Diagnostics.Process.GetProcessesByName("cmd"))
            //{
            //    process.Kill();
            //}
        }
    }
}
