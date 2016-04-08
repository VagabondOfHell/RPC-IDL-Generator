namespace RPCGeneration
{
    partial class frmMethodDialog
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
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.lblMethodName = new System.Windows.Forms.Label();
            this.btnAddMethod = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblParams = new System.Windows.Forms.Label();
            this.btnAddParameter = new System.Windows.Forms.Button();
            this.cmbDataTypes = new System.Windows.Forms.ComboBox();
            this.lblParamType = new System.Windows.Forms.Label();
            this.chkIn = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOut = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParamName = new System.Windows.Forms.TextBox();
            this.lstParams = new System.Windows.Forms.ListView();
            this.btnRemoveParameter = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(177, 29);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(211, 22);
            this.txtMethodName.TabIndex = 0;
            // 
            // lblMethodName
            // 
            this.lblMethodName.AutoSize = true;
            this.lblMethodName.Location = new System.Drawing.Point(12, 32);
            this.lblMethodName.Name = "lblMethodName";
            this.lblMethodName.Size = new System.Drawing.Size(100, 17);
            this.lblMethodName.TabIndex = 1;
            this.lblMethodName.Text = "Method Name:";
            // 
            // btnAddMethod
            // 
            this.btnAddMethod.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddMethod.Location = new System.Drawing.Point(177, 434);
            this.btnAddMethod.Name = "btnAddMethod";
            this.btnAddMethod.Size = new System.Drawing.Size(107, 38);
            this.btnAddMethod.TabIndex = 2;
            this.btnAddMethod.Text = "Add Method";
            this.btnAddMethod.UseVisualStyleBackColor = true;
            this.btnAddMethod.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(332, 434);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblParams
            // 
            this.lblParams.AutoSize = true;
            this.lblParams.Location = new System.Drawing.Point(12, 291);
            this.lblParams.Name = "lblParams";
            this.lblParams.Size = new System.Drawing.Size(85, 17);
            this.lblParams.TabIndex = 5;
            this.lblParams.Text = "Parameters:";
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.Location = new System.Drawing.Point(147, 230);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(123, 45);
            this.btnAddParameter.TabIndex = 6;
            this.btnAddParameter.Text = "Add Parameter";
            this.btnAddParameter.UseVisualStyleBackColor = true;
            this.btnAddParameter.Click += new System.EventHandler(this.btnAddParameter_Click);
            // 
            // cmbDataTypes
            // 
            this.cmbDataTypes.FormattingEnabled = true;
            this.cmbDataTypes.Items.AddRange(new object[] {
            "boolean",
            "char",
            "double",
            "float",
            "int",
            "long",
            "None",
            "short",
            "unsigned char",
            "unsigned double",
            "unsigned float",
            "unsigned int",
            "unsigned long",
            "unsigned short",
            "wchar_t"});
            this.cmbDataTypes.Location = new System.Drawing.Point(362, 122);
            this.cmbDataTypes.Name = "cmbDataTypes";
            this.cmbDataTypes.Size = new System.Drawing.Size(211, 24);
            this.cmbDataTypes.Sorted = true;
            this.cmbDataTypes.TabIndex = 7;
            // 
            // lblParamType
            // 
            this.lblParamType.AutoSize = true;
            this.lblParamType.Location = new System.Drawing.Point(233, 125);
            this.lblParamType.Name = "lblParamType";
            this.lblParamType.Size = new System.Drawing.Size(114, 17);
            this.lblParamType.TabIndex = 8;
            this.lblParamType.Text = "Parameter Type:";
            // 
            // chkIn
            // 
            this.chkIn.AutoSize = true;
            this.chkIn.Location = new System.Drawing.Point(6, 42);
            this.chkIn.Name = "chkIn";
            this.chkIn.Size = new System.Drawing.Size(41, 21);
            this.chkIn.TabIndex = 9;
            this.chkIn.Text = "In";
            this.chkIn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOut);
            this.groupBox1.Controls.Add(this.chkIn);
            this.groupBox1.Location = new System.Drawing.Point(27, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter Endpoint";
            // 
            // chkOut
            // 
            this.chkOut.AutoSize = true;
            this.chkOut.Location = new System.Drawing.Point(72, 42);
            this.chkOut.Name = "chkOut";
            this.chkOut.Size = new System.Drawing.Size(53, 21);
            this.chkOut.TabIndex = 10;
            this.chkOut.Text = "Out";
            this.chkOut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Parameter Name:";
            // 
            // txtParamName
            // 
            this.txtParamName.Location = new System.Drawing.Point(362, 164);
            this.txtParamName.Name = "txtParamName";
            this.txtParamName.Size = new System.Drawing.Size(211, 22);
            this.txtParamName.TabIndex = 11;
            // 
            // lstParams
            // 
            this.lstParams.FullRowSelect = true;
            this.lstParams.GridLines = true;
            this.lstParams.HideSelection = false;
            this.lstParams.Location = new System.Drawing.Point(103, 291);
            this.lstParams.MultiSelect = false;
            this.lstParams.Name = "lstParams";
            this.lstParams.Size = new System.Drawing.Size(436, 136);
            this.lstParams.TabIndex = 13;
            this.lstParams.UseCompatibleStateImageBehavior = false;
            this.lstParams.View = System.Windows.Forms.View.Details;
            this.lstParams.SelectedIndexChanged += new System.EventHandler(this.lstParams_SelectedIndexChanged);
            this.lstParams.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstParams_MouseClick);
            // 
            // btnRemoveParameter
            // 
            this.btnRemoveParameter.Location = new System.Drawing.Point(316, 230);
            this.btnRemoveParameter.Name = "btnRemoveParameter";
            this.btnRemoveParameter.Size = new System.Drawing.Size(123, 45);
            this.btnRemoveParameter.TabIndex = 14;
            this.btnRemoveParameter.Text = "Remove Parameter";
            this.btnRemoveParameter.UseVisualStyleBackColor = true;
            this.btnRemoveParameter.Click += new System.EventHandler(this.btnRemoveParameter_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(556, 321);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(39, 23);
            this.btnUp.TabIndex = 15;
            this.btnUp.Text = "/\\";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(556, 366);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(39, 23);
            this.btnDown.TabIndex = 16;
            this.btnDown.Text = "\\/";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // frmMethodDialog
            // 
            this.AcceptButton = this.btnAddMethod;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(617, 484);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRemoveParameter);
            this.Controls.Add(this.lstParams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParamName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblParamType);
            this.Controls.Add(this.cmbDataTypes);
            this.Controls.Add(this.btnAddParameter);
            this.Controls.Add(this.lblParams);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMethod);
            this.Controls.Add(this.lblMethodName);
            this.Controls.Add(this.txtMethodName);
            this.Name = "frmMethodDialog";
            this.Text = "frmMethodDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMethodDialog_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Label lblMethodName;
        private System.Windows.Forms.Button btnAddMethod;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblParams;
        private System.Windows.Forms.Button btnAddParameter;
        private System.Windows.Forms.ComboBox cmbDataTypes;
        private System.Windows.Forms.Label lblParamType;
        private System.Windows.Forms.CheckBox chkIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParamName;
        private System.Windows.Forms.ListView lstParams;
        private System.Windows.Forms.Button btnRemoveParameter;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
    }
}