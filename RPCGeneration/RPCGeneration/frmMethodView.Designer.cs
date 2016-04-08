namespace RPCGeneration
{
    partial class frmMethodView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMethods = new System.Windows.Forms.ListBox();
            this.lblParams = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rdbImplicit = new System.Windows.Forms.RadioButton();
            this.rdbExplicit = new System.Windows.Forms.RadioButton();
            this.grpHandles = new System.Windows.Forms.GroupBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lstParams = new System.Windows.Forms.ListView();
            this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.lblInterfaceName = new System.Windows.Forms.Label();
            this.txtInterfaceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVersionNumber = new System.Windows.Forms.TextBox();
            this.grpHandles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMethods
            // 
            this.lstMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMethods.FormattingEnabled = true;
            this.lstMethods.ItemHeight = 16;
            this.lstMethods.Location = new System.Drawing.Point(240, 173);
            this.lstMethods.Name = "lstMethods";
            this.lstMethods.Size = new System.Drawing.Size(380, 340);
            this.lstMethods.TabIndex = 0;
            this.lstMethods.SelectedIndexChanged += new System.EventHandler(this.lstMethods_SelectedIndexChanged);
            // 
            // lblParams
            // 
            this.lblParams.AutoSize = true;
            this.lblParams.Location = new System.Drawing.Point(676, 137);
            this.lblParams.Name = "lblParams";
            this.lblParams.Size = new System.Drawing.Size(85, 17);
            this.lblParams.TabIndex = 1;
            this.lblParams.Text = "Parameters:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 173);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 76);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New Method";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 437);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(157, 76);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Method";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 304);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 76);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Method";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(955, 526);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(172, 55);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create Files";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rdbImplicit
            // 
            this.rdbImplicit.AutoSize = true;
            this.rdbImplicit.Checked = true;
            this.rdbImplicit.Location = new System.Drawing.Point(14, 42);
            this.rdbImplicit.Name = "rdbImplicit";
            this.rdbImplicit.Size = new System.Drawing.Size(71, 21);
            this.rdbImplicit.TabIndex = 6;
            this.rdbImplicit.TabStop = true;
            this.rdbImplicit.Text = "Implicit";
            this.rdbImplicit.UseVisualStyleBackColor = true;
            // 
            // rdbExplicit
            // 
            this.rdbExplicit.AutoSize = true;
            this.rdbExplicit.Location = new System.Drawing.Point(113, 42);
            this.rdbExplicit.Name = "rdbExplicit";
            this.rdbExplicit.Size = new System.Drawing.Size(72, 21);
            this.rdbExplicit.TabIndex = 7;
            this.rdbExplicit.Text = "Explicit";
            this.rdbExplicit.UseVisualStyleBackColor = true;
            // 
            // grpHandles
            // 
            this.grpHandles.Controls.Add(this.rdbExplicit);
            this.grpHandles.Controls.Add(this.rdbImplicit);
            this.grpHandles.Location = new System.Drawing.Point(240, 12);
            this.grpHandles.Name = "grpHandles";
            this.grpHandles.Size = new System.Drawing.Size(200, 100);
            this.grpHandles.TabIndex = 10;
            this.grpHandles.TabStop = false;
            this.grpHandles.Text = "Handle";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(237, 137);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(66, 17);
            this.lblMethod.TabIndex = 11;
            this.lblMethod.Text = "Methods:";
            // 
            // lstParams
            // 
            this.lstParams.FullRowSelect = true;
            this.lstParams.GridLines = true;
            this.lstParams.Location = new System.Drawing.Point(679, 173);
            this.lstParams.Name = "lstParams";
            this.lstParams.Size = new System.Drawing.Size(436, 172);
            this.lstParams.TabIndex = 14;
            this.lstParams.UseCompatibleStateImageBehavior = false;
            this.lstParams.View = System.Windows.Forms.View.Details;
            // 
            // dlgFolder
            // 
            this.dlgFolder.Description = "Select a folder to generate the RPC files to";
            this.dlgFolder.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // lblInterfaceName
            // 
            this.lblInterfaceName.AutoSize = true;
            this.lblInterfaceName.Location = new System.Drawing.Point(525, 54);
            this.lblInterfaceName.Name = "lblInterfaceName";
            this.lblInterfaceName.Size = new System.Drawing.Size(108, 17);
            this.lblInterfaceName.TabIndex = 15;
            this.lblInterfaceName.Text = "Interface Name:";
            // 
            // txtInterfaceName
            // 
            this.txtInterfaceName.Location = new System.Drawing.Point(639, 53);
            this.txtInterfaceName.Name = "txtInterfaceName";
            this.txtInterfaceName.Size = new System.Drawing.Size(183, 22);
            this.txtInterfaceName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Version Number:";
            // 
            // txtVersionNumber
            // 
            this.txtVersionNumber.Location = new System.Drawing.Point(639, 90);
            this.txtVersionNumber.Name = "txtVersionNumber";
            this.txtVersionNumber.Size = new System.Drawing.Size(183, 22);
            this.txtVersionNumber.TabIndex = 18;
            // 
            // frmMethodView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 593);
            this.Controls.Add(this.txtVersionNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInterfaceName);
            this.Controls.Add(this.lblInterfaceName);
            this.Controls.Add(this.lstParams);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.grpHandles);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblParams);
            this.Controls.Add(this.lstMethods);
            this.Name = "frmMethodView";
            this.Text = "Method View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMethodView_FormClosing);
            this.Load += new System.EventHandler(this.frmMethodView_Load);
            this.grpHandles.ResumeLayout(false);
            this.grpHandles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMethods;
        private System.Windows.Forms.Label lblParams;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton rdbImplicit;
        private System.Windows.Forms.RadioButton rdbExplicit;
        private System.Windows.Forms.GroupBox grpHandles;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ListView lstParams;
        private System.Windows.Forms.FolderBrowserDialog dlgFolder;
        private System.Windows.Forms.Label lblInterfaceName;
        private System.Windows.Forms.TextBox txtInterfaceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVersionNumber;
    }
}

