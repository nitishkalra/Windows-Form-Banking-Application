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
    public partial class AccountTypeForm : Form
    {
        private int CustomerId;
        public AccountTypeForm()
        {
            InitializeComponent();
        }
        public AccountTypeForm(int custId)
        {
            this.CustomerId = custId;
            InitializeComponent();
        }

        private void ChequingAccountButton_Click(object sender, EventArgs e)
        {
            Operations opr = new Operations();
            if (opr.AddAccount(CustomerId, "Chequing"))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("ChequingAccount Already Present");
            }
            

        }

        private void LiabilityAccountButton_Click(object sender, EventArgs e)
        {
            Operations opr = new Operations();
            if (opr.AddAccount(CustomerId, "Liability"))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("LiabilityAccount Already Present");
            }
        }

        private void TaxFreeAccountButton_Click(object sender, EventArgs e)
        {
            Operations opr = new Operations();
            if (opr.AddAccount(CustomerId, "TaxFree"))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("TaxFreeAccount Already Present");
            }
        }
    }
}
