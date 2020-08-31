using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApteanEdgeBank
{
    public partial class AccountInfoForm : Form
    {
        private int accountId;
        private string accountType;
        Operations operations ;
        public AccountInfoForm()
        {
            InitializeComponent();
            
        }
        public AccountInfoForm(int accId,string accountType)
        {
            operations = new Operations();
            this.accountId = accId;
            this.accountType = accountType;
            InitializeComponent();
            ShowBalanceLabel.Text = operations.GetAccountBalance(accId).ToString();
            if(accountType == "Liability")
            {
                DepositButton.Text = "Repay Loan";
                WithdrawButton.Text = "Take Loan";
            }
            
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            
            double amount = double.Parse(AmountTextBox.Text);
            double balance = double.Parse(ShowBalanceLabel.Text);
            switch (accountType)
            {
                case "TaxFree":
                    if(balance + amount <= 5000.0)
                    {
                        balance += amount;
                        operations.Deposit(accountId, balance);
                        operations.UpdateTotalBankBalance(operations.GetTotalBankBalance() + amount);
                        operations.AddActivity(new Activity(1,accountId, amount, DateTime.Now, 1, "Deposited"));
                    }
                    else
                    {
                        MessageBox.Show("TaxFree Account Cannot have more than 5000.0 balance");
                    }
                    break;
                case "Chequing":
                    balance += amount;
                    operations.Deposit(accountId, balance);
                    operations.UpdateTotalBankBalance(operations.GetTotalBankBalance() + amount);
                    operations.AddActivity(new Activity(1,accountId, amount, DateTime.Now, 1, "Deposited"));
                    break;
                case "Liability":
                    if(balance - amount >= 0)
                    {
                        balance -= amount;
                        operations.Deposit(accountId, balance);
                        operations.UpdateTotalBankBalance(operations.GetTotalBankBalance() + amount);
                        operations.AddActivity(new Activity(1,accountId, amount, DateTime.Now, 1, "Payed Loan"));
                    }
                    else
                    {
                        MessageBox.Show("Need to pay only "+balance);
                    }
                    break;
            }
            Console.WriteLine(operations.GetTotalBankBalance());
            this.Close();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(AmountTextBox.Text);
            double balance = double.Parse(ShowBalanceLabel.Text);
            switch (accountType)
            {
                case "Liability":
                    
                    
                    
                    double bankBalance = operations.GetTotalBankBalance();
                    //Console.WriteLine(bankBalance);
                    if(bankBalance - amount < 0)
                    {
                        MessageBox.Show("Cannot Lend Loan!");
                    }
                    else
                    {
                        balance += amount;
                        operations.Withdraw(accountId, balance);
                        operations.UpdateTotalBankBalance(bankBalance - amount);
                        operations.AddActivity(new Activity(2,accountId, amount, DateTime.Now, 2, "Took Loan"));
                    }
                    break;
                default:
                    if (balance - amount >= 0)
                    {
                        balance -= amount;
                        operations.Withdraw(accountId, balance);
                        operations.UpdateTotalBankBalance(operations.GetTotalBankBalance() - amount);
                        operations.AddActivity(new Activity(2,accountId, amount, DateTime.Now, 1, "Withdrawn"));
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Balance");
                    }
                    break;
            }
            
            this.Close();  
        }

        private void ViewLedgerButton_Click(object sender, EventArgs e)
        {
            AccountLedgerForm form = new AccountLedgerForm(accountId);
            form.ShowDialog();
        }
    }
}
