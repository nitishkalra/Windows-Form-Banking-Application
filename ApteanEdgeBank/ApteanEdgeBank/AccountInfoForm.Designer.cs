namespace ApteanEdgeBank
{
    partial class AccountInfoForm
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
            this.CurrentBalanceLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.ShowBalanceLabel = new System.Windows.Forms.Label();
            this.EnterAmountLabel = new System.Windows.Forms.Label();
            this.ViewLedgerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentBalanceLabel
            // 
            this.CurrentBalanceLabel.AutoSize = true;
            this.CurrentBalanceLabel.Location = new System.Drawing.Point(27, 16);
            this.CurrentBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.Size = new System.Drawing.Size(86, 13);
            this.CurrentBalanceLabel.TabIndex = 0;
            this.CurrentBalanceLabel.Text = "Current Balance:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(225, 47);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(68, 20);
            this.AmountTextBox.TabIndex = 1;
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(19, 103);
            this.DepositButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(132, 35);
            this.DepositButton.TabIndex = 2;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(209, 103);
            this.WithdrawButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(131, 35);
            this.WithdrawButton.TabIndex = 3;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // ShowBalanceLabel
            // 
            this.ShowBalanceLabel.AutoSize = true;
            this.ShowBalanceLabel.Location = new System.Drawing.Point(127, 16);
            this.ShowBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowBalanceLabel.Name = "ShowBalanceLabel";
            this.ShowBalanceLabel.Size = new System.Drawing.Size(0, 13);
            this.ShowBalanceLabel.TabIndex = 4;
            // 
            // EnterAmountLabel
            // 
            this.EnterAmountLabel.AutoSize = true;
            this.EnterAmountLabel.Location = new System.Drawing.Point(27, 49);
            this.EnterAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterAmountLabel.Name = "EnterAmountLabel";
            this.EnterAmountLabel.Size = new System.Drawing.Size(188, 13);
            this.EnterAmountLabel.TabIndex = 5;
            this.EnterAmountLabel.Text = "Enter Amount To Deposit Or Withdraw";
            // 
            // ViewLedgerButton
            // 
            this.ViewLedgerButton.Location = new System.Drawing.Point(119, 154);
            this.ViewLedgerButton.Name = "ViewLedgerButton";
            this.ViewLedgerButton.Size = new System.Drawing.Size(107, 31);
            this.ViewLedgerButton.TabIndex = 6;
            this.ViewLedgerButton.Text = "View Ledger";
            this.ViewLedgerButton.UseVisualStyleBackColor = true;
            this.ViewLedgerButton.Click += new System.EventHandler(this.ViewLedgerButton_Click);
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 197);
            this.Controls.Add(this.ViewLedgerButton);
            this.Controls.Add(this.EnterAmountLabel);
            this.Controls.Add(this.ShowBalanceLabel);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.CurrentBalanceLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AccountInfoForm";
            this.Text = "AccountInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentBalanceLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Label ShowBalanceLabel;
        private System.Windows.Forms.Label EnterAmountLabel;
        private System.Windows.Forms.Button ViewLedgerButton;
    }
}