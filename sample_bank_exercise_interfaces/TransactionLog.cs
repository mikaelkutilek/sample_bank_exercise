using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//normally this would be like an ILogger - but i got lazy.

namespace sample_bank_exercise_interfaces
{
    public class TransactionLog
    {
        public List<TransactionLogItem> Log { get; private set; }


        public TransactionLog()
        {
            Log = new List<TransactionLogItem>();
        }

        public void DisplayLog()
        {
            Log.ForEach(item => item.displayLogEntry());
        }
    }
}
