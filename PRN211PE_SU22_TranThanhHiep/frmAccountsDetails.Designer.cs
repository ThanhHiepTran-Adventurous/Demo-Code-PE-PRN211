namespace PRN211PE_SU22_TranThanhHiep
{
    partial class frmAccountsDetails
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
            this.lbAccountId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.lbOpenDate = new System.Windows.Forms.Label();
            this.txtRegionName = new System.Windows.Forms.TextBox();
            this.lbRegionName = new System.Windows.Forms.Label();
            this.lbCustomerId = new System.Windows.Forms.Label();
            this.txtOpenDate = new System.Windows.Forms.MaskedTextBox();
            this.cbxCustomerId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbAccountId
            // 
            this.lbAccountId.AutoSize = true;
            this.lbAccountId.Location = new System.Drawing.Point(33, 35);
            this.lbAccountId.Name = "lbAccountId";
            this.lbAccountId.Size = new System.Drawing.Size(82, 20);
            this.lbAccountId.TabIndex = 0;
            this.lbAccountId.Text = "Account ID";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(364, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(597, 304);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAccountId
            // 
            this.txtAccountId.Location = new System.Drawing.Point(142, 35);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(193, 27);
            this.txtAccountId.TabIndex = 3;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(142, 99);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(193, 27);
            this.txtAccountName.TabIndex = 5;
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Location = new System.Drawing.Point(33, 106);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(103, 20);
            this.lbAccountName.TabIndex = 4;
            this.lbAccountName.Text = "AccountName";
            // 
            // lbOpenDate
            // 
            this.lbOpenDate.AutoSize = true;
            this.lbOpenDate.Location = new System.Drawing.Point(364, 38);
            this.lbOpenDate.Name = "lbOpenDate";
            this.lbOpenDate.Size = new System.Drawing.Size(81, 20);
            this.lbOpenDate.TabIndex = 6;
            this.lbOpenDate.Text = "Open Date";
            // 
            // txtRegionName
            // 
            this.txtRegionName.Location = new System.Drawing.Point(470, 106);
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.Size = new System.Drawing.Size(193, 27);
            this.txtRegionName.TabIndex = 9;
            // 
            // lbRegionName
            // 
            this.lbRegionName.AutoSize = true;
            this.lbRegionName.Location = new System.Drawing.Point(364, 113);
            this.lbRegionName.Name = "lbRegionName";
            this.lbRegionName.Size = new System.Drawing.Size(100, 20);
            this.lbRegionName.TabIndex = 8;
            this.lbRegionName.Text = "Region Name";
            // 
            // lbCustomerId
            // 
            this.lbCustomerId.AutoSize = true;
            this.lbCustomerId.Location = new System.Drawing.Point(682, 38);
            this.lbCustomerId.Name = "lbCustomerId";
            this.lbCustomerId.Size = new System.Drawing.Size(91, 20);
            this.lbCustomerId.TabIndex = 10;
            this.lbCustomerId.Text = "Customer ID";
            // 
            // txtOpenDate
            // 
            this.txtOpenDate.Location = new System.Drawing.Point(470, 35);
            this.txtOpenDate.Mask = "00/00/0000";
            this.txtOpenDate.Name = "txtOpenDate";
            this.txtOpenDate.Size = new System.Drawing.Size(193, 27);
            this.txtOpenDate.TabIndex = 12;
            this.txtOpenDate.ValidatingType = typeof(System.DateTime);
            // 
            // cbxCustomerId
            // 
            this.cbxCustomerId.FormattingEnabled = true;
            this.cbxCustomerId.Location = new System.Drawing.Point(789, 35);
            this.cbxCustomerId.Name = "cbxCustomerId";
            this.cbxCustomerId.Size = new System.Drawing.Size(151, 28);
            this.cbxCustomerId.TabIndex = 13;
            // 
            // frmAccountsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.cbxCustomerId);
            this.Controls.Add(this.txtOpenDate);
            this.Controls.Add(this.lbCustomerId);
            this.Controls.Add(this.txtRegionName);
            this.Controls.Add(this.lbRegionName);
            this.Controls.Add(this.lbOpenDate);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.lbAccountName);
            this.Controls.Add(this.txtAccountId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbAccountId);
            this.Name = "frmAccountsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccountsDetails";
            this.Load += new System.EventHandler(this.frmAccountsDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccountId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.Label lbOpenDate;
        private System.Windows.Forms.TextBox txtRegionName;
        private System.Windows.Forms.Label lbRegionName;
        private System.Windows.Forms.Label lbCustomerId;
        private System.Windows.Forms.MaskedTextBox txtOpenDate;
        private System.Windows.Forms.ComboBox cbxCustomerId;
    }
}