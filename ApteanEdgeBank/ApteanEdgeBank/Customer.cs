using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ApteanEdgeBank
{
    class Customer
    {
        public string id;
        public DateTime dateJoined;
        public string name { get; set; }
        public bool isActive;
        

        #region Constructors
        public Customer(string id, string name, DateTime dateofjoining)
        {

            this.id = id;
            this.name = name;
            this.dateJoined = dateofjoining;
            this.isActive = true;
        }
        #endregion

        

    }
}
