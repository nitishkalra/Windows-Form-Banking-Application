using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApteanEdgeBank
{
    abstract class Account
    {

        public string id;
        public double balance;
        public bool isActive;
       
        #region Contructors
        public Account(string id, double balance)
        {
            this.id = id;

            this.balance = balance;

            this.isActive = true;

        }

        #endregion
        abstract public void Deposit(double amount);
        abstract public bool WithDraw(double amount);


    }
}
