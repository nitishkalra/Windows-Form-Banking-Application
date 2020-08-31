namespace ApteanEdgeBank
{
    partial class AccountTypeForm
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
            this.ChequingAccountButton = new System.Windows.Forms.Button();
            this.LiabilityAccountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TaxFreeAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChequingAccountButton
            // 
            this.ChequingAccountButton.Location = new System.Drawing.Point(42, 39);
            this.ChequingAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChequingAccountButton.Name = "ChequingAccountButton";
            this.ChequingAccountButton.Size = new System.Drawing.Size(164, 57);
            this.ChequingAccountButton.TabIndex = 0;
            this.ChequingAccountButton.Text = "Chequing Account";
            this.ChequingAccountButton.UseVisualStyleBackColor = true;
            this.ChequingAccountButton.Click += new System.EventHandler(this.ChequingAccountButton_Click);
            // 
            // LiabilityAccountButton
            // 
            this.LiabilityAccountButton.Location = new System.Drawing.Point(42, 115);
            this.LiabilityAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LiabilityAccountButton.Name = "LiabilityAccountButton";
            this.LiabilityAccountButton.Size = new System.Drawing.Size(164, 60);
            this.LiabilityAccountButton.TabIndex = 1;
            this.LiabilityAccountButton.Text = "Liability Account";
            this.LiabilityAccountButton.UseVisualStyleBackColor = true;
            this.LiabilityAccountButton.Click += new System.EventHandler(this.LiabilityAccountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Account Type";
            // 
            // TaxFreeAccountButton
            // 
            this.TaxFreeAccountButton.Location = new System.Drawing.Point(42, 203);
            this.TaxFreeAccountButton.Name = "TaxFreeAccountButton";
            this.TaxFreeAccountButton.Size = new System.Drawing.Size(164, 60);
            this.TaxFreeAccountButton.TabIndex = 3;
            this.TaxFreeAccountButton.Text = "TaxFree Account";
            this.TaxFreeAccountButton.UseVisualStyleBackColor = true;
            this.TaxFreeAccountButton.Click += new System.EventHandler(this.TaxFreeAccountButton_Click);
            // 
            // AccountTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 294);
            this.Controls.Add(this.TaxFreeAccountButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LiabilityAccountButton);
            this.Controls.Add(this.ChequingAccountButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AccountTypeForm";
            this.Text = "AccountType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChequingAccountButton;
        private System.Windows.Forms.Button LiabilityAccountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TaxFreeAccountButton;
    }
}