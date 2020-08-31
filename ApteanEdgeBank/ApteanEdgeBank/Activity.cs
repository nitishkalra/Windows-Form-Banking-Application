using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApteanEdgeBank
{
    class Activity
    {

        public int activityId;
        public int accountId;
        public double amount;
        public DateTime timestamp;
        public int  activityCode;
        public string note;

        public Activity(int Id, int accountId, double amount, DateTime timestamp, int activityCode, string note)
        {
            this.activityId = Id;
            this.accountId = accountId;
            this.amount = amount;
            this.timestamp = timestamp;
            this.activityCode = activityCode;
            this.note = note;
        }
    }
}
