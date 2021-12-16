using sample_bank_exercise_interfaces;
using sample_bank_exercise_interfaces.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_business.entities
{
    public class CheckingAccount : Account
    {

        public CheckingAccount(string name, double startingBalance) : base(name, AccountType.Checking, startingBalance)
        {
            TransactionProcessor = new DefaultTransactionRulesProcessor();
        }


        //consolidate these in base? shared between account subclasses.
        public override bool ExecuteTransaction(Transaction transaction)
        {
            string reason = "";
            if (TransactionProcessor.canProcessTransaction(transaction, out reason))
            {
                this.TransactionLogs.Log.Add(transaction.ExecuteTransaction(this));
                return true;
            }
            else
            {
                this.TransactionLogs.Log.Add(new TransactionLogItem(reason));
                return false;
            }
        }

        public override bool ExecuteTransaction(Transaction transaction, Account targetAccount)
        {
            string reason = "";
            if (TransactionProcessor.canProcessTransaction(transaction, out reason))
            {
                this.TransactionLogs.Log.Add(transaction.ExecuteTransaction(this, targetAccount));
                return true;
            }
            else
            {
                this.TransactionLogs.Log.Add(new TransactionLogItem(reason));
                return false;
            }
        }

    }
}
