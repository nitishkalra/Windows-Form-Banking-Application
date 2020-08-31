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
    public partial class AccountLedgerForm : Form
    {
        private int accountId;
        private Operations operations;
        public AccountLedgerForm()
        {
            InitializeComponent();
        }
        public AccountLedgerForm(int accId)
        {
            this.accountId = accId;
            InitializeComponent();
            operations = new Operations();
            ActivityGridView.DataSource = operations.GetActivities(accountId);
        }

    }
}
