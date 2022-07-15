namespace PRN211PE_SU22_TranThanhHiep
{
    partial class frmAccounts
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
            this.dgvListAccount = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lbCustomerId = new System.Windows.Forms.Label();
            this.txtRegionName = new System.Windows.Forms.TextBox();
            this.lbRegionName = new System.Windows.Forms.Label();
            this.lbOpenDate = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.txtAccountId = new System.Windows.Forms.TextBox();
            this.lbAccountId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtOpenDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListAccount
            // 
            this.dgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAccount.Location = new System.Drawing.Point(3, 318);
            this.dgvListAccount.Name = "dgvListAccount";
            this.dgvListAccount.RowHeadersWidth = 51;
            this.dgvListAccount.RowTemplate.Height = 29;
            this.dgvListAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListAccount.Size = new System.Drawing.Size(934, 178);
            this.dgvListAccount.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(117, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(448, 241);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(790, 241);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lbCustomerId
            // 
            this.lbCustomerId.AutoSize = true;
            this.lbCustomerId.Location = new System.Drawing.Point(661, 22);
            this.lbCustomerId.Name = "lbCustomerId";
            this.lbCustomerId.Size = new System.Drawing.Size(91, 20);
            this.lbCustomerId.TabIndex = 21;
            this.lbCustomerId.Text = "Customer ID";
            // 
            // txtRegionName
            // 
            this.txtRegionName.Location = new System.Drawing.Point(448, 86);
            this.txtRegionName.Name = "txtRegionName";
            this.txtRegionName.Size = new System.Drawing.Size(193, 27);
            this.txtRegionName.TabIndex = 20;
            // 
            // lbRegionName
            // 
            this.lbRegionName.AutoSize = true;
            this.lbRegionName.Location = new System.Drawing.Point(343, 86);
            this.lbRegionName.Name = "lbRegionName";
            this.lbRegionName.Size = new System.Drawing.Size(100, 20);
            this.lbRegionName.TabIndex = 19;
            this.lbRegionName.Text = "Region Name";
            // 
            // lbOpenDate
            // 
            this.lbOpenDate.AutoSize = true;
            this.lbOpenDate.Location = new System.Drawing.Point(343, 19);
            this.lbOpenDate.Name = "lbOpenDate";
            this.lbOpenDate.Size = new System.Drawing.Size(81, 20);
            this.lbOpenDate.TabIndex = 18;
            this.lbOpenDate.Text = "Open Date";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(121, 83);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(193, 27);
            this.txtAccountName.TabIndex = 17;
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Location = new System.Drawing.Point(12, 90);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(103, 20);
            this.lbAccountName.TabIndex = 16;
            this.lbAccountName.Text = "AccountName";
            // 
            // txtAccountId
            // 
            this.txtAccountId.Location = new System.Drawing.Point(121, 19);
            this.txtAccountId.Name = "txtAccountId";
            this.txtAccountId.Size = new System.Drawing.Size(193, 27);
            this.txtAccountId.TabIndex = 15;
            // 
            // lbAccountId
            // 
            this.lbAccountId.AutoSize = true;
            this.lbAccountId.Location = new System.Drawing.Point(12, 19);
            this.lbAccountId.Name = "lbAccountId";
            this.lbAccountId.Size = new System.Drawing.Size(82, 20);
            this.lbAccountId.TabIndex = 14;
            this.lbAccountId.Text = "Account ID";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(759, 19);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(178, 27);
            this.txtCustomerId.TabIndex = 23;
            // 
            // txtOpenDate
            // 
            this.txtOpenDate.Location = new System.Drawing.Point(449, 22);
            this.txtOpenDate.Name = "txtOpenDate";
            this.txtOpenDate.Size = new System.Drawing.Size(193, 27);
            this.txtOpenDate.TabIndex = 24;
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 508);
            this.Controls.Add(this.txtOpenDate);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lbCustomerId);
            this.Controls.Add(this.txtRegionName);
            this.Controls.Add(this.lbRegionName);
            this.Controls.Add(this.lbOpenDate);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.lbAccountName);
            this.Controls.Add(this.txtAccountId);
            this.Controls.Add(this.lbAccountId);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvListAccount);
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccounts";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListAccount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lbCustomerId;
        private System.Windows.Forms.TextBox txtRegionName;
        private System.Windows.Forms.Label lbRegionName;
        private System.Windows.Forms.Label lbOpenDate;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.TextBox txtAccountId;
        private System.Windows.Forms.Label lbAccountId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtOpenDate;
    }
}