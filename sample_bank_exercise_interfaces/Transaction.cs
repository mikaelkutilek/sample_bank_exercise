using sample_bank_exercise_interfaces.enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_interfaces
{
    public  abstract class Transaction
    {
        public double Amount { get; private set; }
        public TransactionType TransactionType { get; set; }

        public Transaction(Double amount, TransactionType transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
        }

        //sloppy
        public abstract TransactionLogItem ExecuteTransaction(Account account, Account? targetAccount = null);
 
    }
}
