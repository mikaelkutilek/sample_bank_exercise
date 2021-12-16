using sample_bank_exercise_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_business.entities
{
    internal class DefaultTransactionRulesProcessor : ITransactionRulesProcessor
    {

        // probably could in a future state add things like maximum overdraft, rules around surcharges or something like that
        // or just strictly disallow moving funds you don't have - leaving it out for now.
        public bool canProcessTransaction(Transaction transaction, out string reason)
        {
            reason = "success";
            return true;
        }
    }
}
