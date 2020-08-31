namespace ApteanEdgeBank
{
    partial class EntryScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryScreenForm));
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddCustomerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteCustomerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AccountListBox = new System.Windows.Forms.ListBox();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.TotalBankBalanceButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.ItemHeight = 20;
            this.CustomerListBox.Location = new System.Drawing.Point(16, 51);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(332, 404);
            this.CustomerListBox.TabIndex = 0;
            this.CustomerListBox.SelectedIndexChanged += new System.EventHandler(this.CustomerListBox_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCustomerToolStripButton,
            this.DeleteCustomerToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(780, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddCustomerToolStripButton
            // 
            this.AddCustomerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddCustomerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddCustomerToolStripButton.Image")));
            this.AddCustomerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCustomerToolStripButton.Name = "AddCustomerToolStripButton";
            this.AddCustomerToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.AddCustomerToolStripButton.Text = "toolStripButton1";
            this.AddCustomerToolStripButton.ToolTipText = "Add Customer";
            this.AddCustomerToolStripButton.Click += new System.EventHandler(this.AddCustomerToolStripButton_Click);
            // 
            // DeleteCustomerToolStripButton
            // 
            this.DeleteCustomerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteCustomerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCustomerToolStripButton.Image")));
            this.DeleteCustomerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCustomerToolStripButton.Name = "DeleteCustomerToolStripButton";
            this.DeleteCustomerToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.DeleteCustomerToolStripButton.Text = "toolStripButton1";
            this.DeleteCustomerToolStripButton.ToolTipText = "Delete Customer";
            this.DeleteCustomerToolStripButton.Click += new System.EventHandler(this.DeleteCustomerToolStripButton_Click);
            // 
            // AccountListBox
            // 
            this.AccountListBox.FormattingEnabled = true;
            this.AccountListBox.ItemHeight = 20;
            this.AccountListBox.Location = new System.Drawing.Point(396, 49);
            this.AccountListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccountListBox.Name = "AccountListBox";
            this.AccountListBox.Size = new System.Drawing.Size(319, 404);
            this.AccountListBox.TabIndex = 2;
            this.AccountListBox.DoubleClick += new System.EventHandler(this.AccountListBox_DoubleClick);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(423, 268);
            this.AddAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(279, 52);
            this.AddAccountButton.TabIndex = 3;
            this.AddAccountButton.Text = "New Account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(423, 349);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(279, 65);
            this.DeleteAccountButton.TabIndex = 4;
            this.DeleteAccountButton.Text = "Delete";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // TotalBankBalanceButton
            // 
            this.TotalBankBalanceButton.Location = new System.Drawing.Point(263, 9);
            this.TotalBankBalanceButton.Name = "TotalBankBalanceButton";
            this.TotalBankBalanceButton.Size = new System.Drawing.Size(210, 32);
            this.TotalBankBalanceButton.TabIndex = 5;
            this.TotalBankBalanceButton.Text = "Total Bank Balance";
            this.TotalBankBalanceButton.UseVisualStyleBackColor = true;
            this.TotalBankBalanceButton.Click += new System.EventHandler(this.TotalBankBalanceButton_Click);
            // 
            // EntryScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 474);
            this.Controls.Add(this.TotalBankBalanceButton);
            this.Controls.Add(this.DeleteAccountButton);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.AccountListBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CustomerListBox);
            this.Name = "EntryScreenForm";
            this.Text = "Aptean Edge Bank";
            this.Load += new System.EventHandler(this.EntryScreenForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddCustomerToolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteCustomerToolStripButton;
        private System.Windows.Forms.ListBox AccountListBox;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.Button TotalBankBalanceButton;
    }
}

