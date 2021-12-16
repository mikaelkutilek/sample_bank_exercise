using sample_bank_exercise_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_business.entities
{
    public class IndividualInvestmentTransactionRulesProcessor : ITransactionRulesProcessor
    {
        public bool canProcessTransaction(Transaction transaction, out string reason)
        {

            if (transaction.TransactionType == sample_bank_exercise_interfaces.enums.TransactionType.Withdrawal)
            {
                if (transaction.Amount > 500)
                {
                    reason = "cannot withdraw more than 500";
                    return false;
                }
            }
            reason = "success";
            return true;
        }
    }
}
