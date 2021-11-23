using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema68.Entity
{
    class AccountLog
    {
        int log_ID { get; set; }
        DateTime datetime { get; set; }
        string Event { get; set; }
        
        public AccountLog(int logID, DateTime Datetime, string Evnt)
        {
            log_ID = logID;
            datetime = Datetime;
            Event = Evnt;
        }


    }
}
