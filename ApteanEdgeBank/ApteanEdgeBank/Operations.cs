using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApteanEdgeBank
{
    class Operations
    {
        #region Validations
        // Returns true if there is no other account of this accountType else false
        public bool ValidateAddAccount(int customerId, string accountType)
        {
            int count;
            int id = GetAccountTypeId(accountType);
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string sqlQuery = "select count(*) from Accounts where CustId = @custId and IsActive = @isActive and AccountTypeId = @AccountTypeId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    cmd.Parameters.AddWithValue("@isActive", 1);
                    cmd.Parameters.AddWithValue("@AccountTypeId", id);


                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            if (count == 0) return true;
            else return false;

        }
        // returns true if balance = 0 (can delete account) else if balance >0.0 returns false(cannot delete account)
        public bool ValidateDeleteAccount(int accountId)
        {
            double balance;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string sqlQuery = "select balance from Accounts where AccId = @accId and IsActive = @isActive";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@accId", accountId);
                    cmd.Parameters.AddWithValue("@isActive", 1);



                    balance = Convert.ToDouble(cmd.ExecuteScalar());
                }
            }
            if (balance > 0.0) return false;
            else return true;
        }

        #endregion


        #region Customer Operations

        public void AddCustomer(Customer cust)
        {
            int newCustId;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string sqlQuery = "Insert into Customers (Name, IsActive, DateOfJoining) Values(@name, @isActive, @datejoined);" + "Select @@Identity";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@name", cust.name);
                    cmd.Parameters.AddWithValue("@isActive", 1);
                    cmd.Parameters.AddWithValue("@datejoined", cust.dateJoined);
                    newCustId = Convert.ToInt32((decimal)cmd.ExecuteScalar());
                }
            }
            //Console.WriteLine(newCustId);

        }
        public DataTable GetAllCustomers()
        {

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {

                using (SqlCommand cmd = new SqlCommand("select * from Customers where isActive = @isActivee", connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@isActivee", true);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);
                }



            }
            return dt;

        }
        public void DeleteCustomer(int customerId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {


                string sqlQuery = "Update Customers set isActive = @isActivee where CustId = @custId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    cmd.Parameters.AddWithValue("@isActivee", 0);
                    var result = cmd.ExecuteScalar();
                }
            }
        }

        public void UpdateCustomer(int customerId, string customerName)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {


                string sqlQuery = "Update Customers set Name = @CustName where CustId = @custId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    cmd.Parameters.AddWithValue("@CustName", customerName);
                    cmd.Parameters.AddWithValue("@isActive", 1);
                    var result = cmd.ExecuteScalar();

                }
            }
        }
        public DataTable GetAccounts(int customerId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {

                using (SqlCommand cmd = new SqlCommand("select Accounts.AccId, Accounts.balance, AccountTypes.accountTypeName from Accounts inner join AccountTypes on Accounts.AccountTypeId = AccountTypes.id where isActive = @isActivee and CustId = @custId;", connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@isActivee", true);
                    cmd.Parameters.AddWithValue("@custId", customerId);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);
                }
            }
            return dt;
        }

        #endregion

        #region Account Operations
        public int GetAccountTypeId(string accountTypeName)
        {
            int id;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string sqlQuery = "select id from AccountTypes where accountTypeName = @accountTypeName";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@accountTypeName", accountTypeName);


                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return id;
        }
        public double GetTotalBankBalance()
        {
            double balance;
            int id = GetAccountTypeId("BankAccount");
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string sqlQuery = "select balance from Accounts where AccountTypeId = @AccountTypeId";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    
                    cmd.Parameters.AddWithValue("@AccountTypeId",id);


                    balance = Convert.ToDouble(cmd.ExecuteScalar());
                }
            }
            return balance;
        }

        public void UpdateTotalBankBalance(double balance)
        {
            int id = GetAccountTypeId("BankAccount");
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string sqlQuery = "Update Accounts set balance = @balance where AccountTypeId = @accountTypeId";
                using(SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@balance", balance);
                    cmd.Parameters.AddWithValue("@accountTypeId", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool AddAccount(int customerId, string accountType)
        {
            int id = GetAccountTypeId(accountType);
            if (ValidateAddAccount(customerId, accountType))
            {
                int newAccId;
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    string sqlQuery = "Insert into Accounts (balance, IsActive, AccountTypeId,CustId) Values(@balance, @isActive, @AccountTypeId, @custId);" + "Select @@Identity";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@balance", 0.0);
                        cmd.Parameters.AddWithValue("@isActive", 1);
                        cmd.Parameters.AddWithValue("@AccountTypeId", id);
                        cmd.Parameters.AddWithValue("@custId", customerId);

                        newAccId = Convert.ToInt32((decimal)cmd.ExecuteScalar());
                    }
                }
                return true;
            }
            else return false;

            // Console.WriteLine(newAccId);
        }


        // Returns true if account is deleted successfully after validation else false if balance is still there in account
        public bool DeleteAccount(int accountId)
        {
            //TODO: Add Validation before deleting account - check if balance is zero or not
            if (ValidateDeleteAccount(accountId))
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {


                    string sqlQuery = "Update Accounts set isActive = @isActivee where AccId = @accountId";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@accountId", accountId);
                        cmd.Parameters.AddWithValue("@isActivee", 0);
                        var result = cmd.ExecuteScalar();
                    }
                }
                return true;
            }
            else
            {
                return false;
            }

        }



        public double GetAccountBalance(int accId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {

                using (SqlCommand cmd = new SqlCommand("select * from Accounts where isActive = @isActivee and AccId = @accId", connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@isActivee", true);
                    cmd.Parameters.AddWithValue("@accId", accId);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);

                }
            }
            double balance = (double)dt.Rows[0].Field<Decimal>(1);
            return balance;

        }

        public void Deposit(int accId, double balance)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string sqlQuery = "Update Accounts set  balance = @balance where AccId = @accId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@balance", balance);
                    cmd.Parameters.AddWithValue("@accId", accId);
                    var result = cmd.ExecuteScalar();

                }
                
            }
        }
        public void Withdraw(int accId, double balance)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string sqlQuery = "Update Accounts set  balance = @balance where AccId = @accId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@balance", balance);
                    cmd.Parameters.AddWithValue("@accId", accId);
                    var result = cmd.ExecuteScalar();

                }
            }
        }

        #endregion
        public DataTable GetActivities(int accountId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {

                using (SqlCommand cmd = new SqlCommand("select * from Activities where AccId = @accountId", connection))
                {
                    connection.Open();
                    
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    adapt.Fill(dt);
                }
            }
            return dt;
        }
        public void AddActivity(Activity activity)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                string sqlQuery = "Insert into Activities (Amount, TimeStamp, ActivityCode,Note,AccId) Values(@amount, @timestamp, @activityCode, @note,@accId);";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    cmd.Parameters.AddWithValue("@amount", activity.amount);
                    cmd.Parameters.AddWithValue("@timestamp", activity.timestamp);
                    cmd.Parameters.AddWithValue("@activityCode", activity.activityCode);
                    cmd.Parameters.AddWithValue("@note", activity.note);
                    cmd.Parameters.AddWithValue("@accId", activity.accountId);

                    var result = cmd.ExecuteScalar();
                }
            }
        }
    }
}


