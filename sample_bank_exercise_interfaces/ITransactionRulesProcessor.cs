using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_interfaces
{
    public interface ITransactionRulesProcessor
    {
        public bool canProcessTransaction(Transaction transaction, out string reason);
    }
}
