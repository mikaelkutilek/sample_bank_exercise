using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_business.entities
{
    public class TransactionLog
    {
        List<TransactionLogItem> Log { get; set; }


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
