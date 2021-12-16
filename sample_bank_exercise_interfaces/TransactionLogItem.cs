using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_interfaces
{
    public class TransactionLogItem
    {
        private string logentry;

        public TransactionLogItem(string logEntryMessage)
        {
            logentry = logEntryMessage;
        }

        public void displayLogEntry()
        {
            Console.Write(logentry);
        }


    }
}
