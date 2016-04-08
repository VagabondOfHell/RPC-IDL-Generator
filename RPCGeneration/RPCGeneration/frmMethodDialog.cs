using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPCGeneration
{
    public partial class frmMethodDialog : Form
    {
        Method newMethod = new Method("");
        bool successful = false;

        bool add = false;

        public frmMethodDialog()
        {
            InitializeComponent();

            // Add columns
            lstParams.Columns.Add("Endpoint", -2, HorizontalAlignment.Left);
            lstParams.Columns.Add("Datatype", -2, HorizontalAlignment.Left);
            lstParams.Columns.Add("Name", -2, HorizontalAlignment.Left);

        }

        public frmMethodDialog(Method method)
        {
            InitializeComponent();

            // Add columns
            lstParams.Columns.Add("Endpoint", -2, HorizontalAlignment.Left);
            lstParams.Columns.Add("Datatype", -2, HorizontalAlignment.Left);
            lstParams.Columns.Add("Name", -2, HorizontalAlignment.Left);

            newMethod = method;

            txtMethodName.Text = method.MethodName;

            UpdateList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;

            if (!ValidMethod(true))
            {                
                return;
            }
            else
            { 
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private bool ValidMethod(bool displayMessagebox)
        {
            if (txtMethodName.Text == string.Empty)
            {
                if(displayMessagebox)
                    MessageBox.Show("Method Requires a Name");
                return false;
            }

            foreach (Char character in txtMethodName.Text)
            {
                if (!Char.IsLetterOrDigit(character))
                {
                    if (displayMessagebox)
                        MessageBox.Show("Invalid Characters in Parameter Name");
                    return false;
                }

                if (Char.IsWhiteSpace(character))
                {
                    if (displayMessagebox)
                        MessageBox.Show("Invalid Characters in Parameter Name");
                    return false;
                }
            }

            newMethod.MethodName = txtMethodName.Text;

            successful = true;
            return true;
        }

        private bool ValidParameter()
        {
            if (cmbDataTypes.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Datatype");
                return false;
            }

            if (cmbDataTypes.SelectedItem.ToString() != "None")
            {
                if (chkIn.Checked == false && chkOut.Checked == false)
                {
                    MessageBox.Show("Please Select An Endpoint");
                    return false;
                }

                if (txtParamName.Text == string.Empty)
                {
                    MessageBox.Show("Please Input a Parameter Name");
                    return false;
                }                
                else
                {
                    foreach (Char character in txtParamName.Text)
                    {
                        if (!Char.IsLetterOrDigit(character) && character != '*')
                        {
                            MessageBox.Show("Invalid Characters in Parameter Name");
                            return false;
                        }

                        if (Char.IsWhiteSpace(character))
                        {
                            MessageBox.Show("Invalid Characters in Parameter Name");
                            return false;
                        }
                    }

                    if (btnAddParameter.Text == "Add Parameter")
                    {
                        foreach (Parameter param in newMethod.Parameters)
                        {
                            if (param.ParameterName == txtParamName.Text)
                            {
                                MessageBox.Show("Parameter Name must be unique");
                                return false;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Datatype, therefore no need to add parameter");
                return false;
            }

            return true;
        }

        private void btnAddParameter_Click(object sender, EventArgs e)
        {
            if (btnAddParameter.Text == "Add Parameter")
                AddParameter();
            else if (btnAddParameter.Text == "Edit Parameter")
                UpdateParameter();
        }

        private void AddParameter()
        {
            if (ValidParameter())
            {
                Parameter paramToAdd = new Parameter(txtParamName.Text, cmbDataTypes.SelectedItem.ToString(), GetEndpoint());
                newMethod.AddNewParameter(paramToAdd);

                UpdateList();

                ResetParamInput();
            }
            else
                return;
        }

        private void UpdateList()
        {
            lstParams.Clear();

            // Add columns
            lstParams.Columns.Add("Endpoint", 80, HorizontalAlignment.Left);
            lstParams.Columns.Add("Datatype", 80, HorizontalAlignment.Left);
            lstParams.Columns.Add("Name", -2, HorizontalAlignment.Left);

            foreach (Parameter param in newMethod.Parameters)
            {
                ListViewItem newItem = new ListViewItem(new[] { param.ParameterEndpoint, param.ParameterDatatype, param.ParameterName });
                lstParams.Items.Add(newItem);
            }
           
        }

        private void UpdateParameter()
        {
            if (ValidParameter())
            {
                newMethod.EditParamName(lstParams.SelectedIndices[0], txtParamName.Text);
                newMethod.EditParamDatatype(lstParams.SelectedIndices[0], cmbDataTypes.SelectedItem.ToString());
                newMethod.EditParamEndpoint(lstParams.SelectedIndices[0], GetEndpoint());

                btnAddParameter.Text = "Add Parameter";
                UpdateList();
                ResetParamInput();

                lstParams.SelectedIndices.Clear();
            }
        }

        public Method GetMethod()
        {
             return newMethod;
        }

        public bool Successful()
        {
            return successful;
        }

        private string GetEndpoint()
        {
            string endpoint = "";

            if (chkIn.Checked == true && chkOut.Checked == false)
                endpoint = "[in]";
            else if (chkIn.Checked == false && chkOut.Checked == true)
                endpoint = "[out]";
            else if (chkIn.Checked == true && chkOut.Checked == true)
                endpoint = "[in, out]";

            return endpoint;
        }

        private void lstParams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstParams.SelectedItems.Count > 0)
            {
                btnAddParameter.Text = "Edit Parameter";
                txtParamName.Text = lstParams.SelectedItems[0].SubItems[2].Text;
                cmbDataTypes.SelectedItem = lstParams.SelectedItems[0].SubItems[1].Text;

                string endpoint = lstParams.SelectedItems[0].SubItems[0].Text;

                if (endpoint.Contains("In"))
                    chkIn.Checked = true;
                else
                    chkIn.Checked = false;

                if (endpoint.Contains("Out"))
                    chkOut.Checked = true;
                else
                    chkOut.Checked = false;
            }
        }

        private void lstParams_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                lstParams.SelectedItems.Clear();
                btnAddParameter.Text = "Add Parameter";
                ResetParamInput();
            }           
        }

        private void ResetParamInput()
        {
            txtParamName.Text = string.Empty;
            cmbDataTypes.SelectedItem = "None";
            chkIn.Checked = false;
            chkOut.Checked = false;
        }

        private void btnRemoveParameter_Click(object sender, EventArgs e)
        {
            if (lstParams.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove the selected parameter?", "Remove Parameter Confirm",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    newMethod.RemoveParameter(lstParams.SelectedIndices[0]);

                    lstParams.Items.RemoveAt(lstParams.SelectedIndices[0]);
                    btnAddParameter.Text = "Add Parameter";
                    lstParams.SelectedIndices.Clear();
                    UpdateList();
                    ResetParamInput();
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lstParams.SelectedIndices.Count > 0)
            {
                if (lstParams.SelectedIndices[0] > 0)
                {
                    Parameter param1 = newMethod.Parameters[lstParams.SelectedIndices[0]];
                    Parameter param2 = newMethod.Parameters[lstParams.SelectedIndices[0] - 1];

                    newMethod.Parameters[lstParams.SelectedIndices[0]] = param2;
                    newMethod.Parameters[lstParams.SelectedIndices[0] - 1] = param1;

                    btnAddParameter.Text = "Add Parameter";
                    lstParams.SelectedIndices.Clear();
                    UpdateList();
                    ResetParamInput();
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (lstParams.SelectedIndices.Count > 0)
            {
                if (lstParams.SelectedIndices[0] < lstParams.Items.Count - 1)
                {
                    Parameter param1 = newMethod.Parameters[lstParams.SelectedIndices[0]];
                    Parameter param2 = newMethod.Parameters[lstParams.SelectedIndices[0] + 1];

                    newMethod.Parameters[lstParams.SelectedIndices[0]] = param2;
                    newMethod.Parameters[lstParams.SelectedIndices[0] + 1] = param1;

                    btnAddParameter.Text = "Add Parameter";
                    lstParams.SelectedIndices.Clear();
                    UpdateList();
                    ResetParamInput();
                }
            }
        }

        private void frmMethodDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (add)
            {
                if (!ValidMethod(false))
                {
                    add = false;
                    e.Cancel = true;
                }
            }
        }
    }
}
