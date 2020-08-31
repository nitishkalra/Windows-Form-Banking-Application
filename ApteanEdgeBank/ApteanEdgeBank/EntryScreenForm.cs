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
    public partial class EntryScreenForm : Form
    {
        private BindingSource _customerBindingSource = new BindingSource();
        private BindingSource _accountBindingSource = new BindingSource();
        Operations operations;
        //private Bank myBank;
        public EntryScreenForm()
        {
            
            InitializeComponent();
            operations = new Operations();
            System.Drawing.Icon bankIco = new System.Drawing.Icon("C:\\Users\\nkalra\\source\\repos\\ApteanEdgeBank\\ApteanEdgeBank\\bank.ico");
            this.Icon = bankIco;
            System.Drawing.Icon ico = new System.Drawing.Icon("C:\\Users\\nkalra\\source\\repos\\ApteanEdgeBank\\ApteanEdgeBank\\addCustomer.ico");
            this.AddCustomerToolStripButton.Image = ico.ToBitmap();
            System.Drawing.Icon deleteIco = new System.Drawing.Icon("C:\\Users\\nkalra\\source\\repos\\ApteanEdgeBank\\ApteanEdgeBank\\deleteCustomer.ico");
            this.DeleteCustomerToolStripButton.Image = deleteIco.ToBitmap();

        }

        private void EntryScreenForm_Load(object sender, EventArgs e)
        {
            _customerBindingSource.DataSource = operations.GetAllCustomers();
            

            CustomerListBox.DisplayMember = "name";
            CustomerListBox.ValueMember = "custId";
            CustomerListBox.DataSource = _customerBindingSource;
            Console.WriteLine(operations.GetTotalBankBalance());
        }

        

        private void CustomerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedValue != null)
            {
                int id = (int)CustomerListBox.SelectedValue;
                Console.WriteLine(id);

                _accountBindingSource.DataSource = operations.GetAccounts(id);
                AccountListBox.DataSource = _accountBindingSource;
                AccountListBox.DisplayMember = "accountTypeName";
                AccountListBox.ValueMember = "AccId";
            }
            
            

        }



        private void AddCustomerToolStripButton_Click(object sender, EventArgs e)
        {
            
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
            _customerBindingSource.DataSource = operations.GetAllCustomers();
        }

        private void DeleteCustomerToolStripButton_Click(object sender, EventArgs e)
        {
            if (CustomerListBox.SelectedValue != null)
            {
                int id = (int)CustomerListBox.SelectedValue;
                operations.DeleteCustomer(id);
                _customerBindingSource.DataSource = operations.GetAllCustomers();
            }
            
        }

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            int custId = (int)CustomerListBox.SelectedValue;
            AccountTypeForm form = new AccountTypeForm(custId);
            form.ShowDialog();
            _accountBindingSource.DataSource = operations.GetAccounts(custId);

        }

        private void DeleteAccountButton_Click(object sender, EventArgs e)
        {
            if (AccountListBox.SelectedValue != null)
            {
                int accId = (int)AccountListBox.SelectedValue;
                int custId = (int)CustomerListBox.SelectedValue;
                if (operations.DeleteAccount(accId))
                {
                    _accountBindingSource.DataSource = operations.GetAccounts(custId);
                }
                else
                {
                    MessageBox.Show("Cannot Delete Account balance is not 0.0");
                }
            }
            
            
            
        }

        private void AccountListBox_DoubleClick(object sender, EventArgs e)
        {
            int accId = (int)AccountListBox.SelectedValue;
            string accountType = AccountListBox.GetItemText(AccountListBox.SelectedItem);
            AccountInfoForm form = new AccountInfoForm(accId,accountType);
            form.Show();
        }

        private void TotalBankBalanceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(operations.GetTotalBankBalance().ToString());
        }
    }
}
