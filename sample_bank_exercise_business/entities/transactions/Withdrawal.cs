using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sample_bank_exercise_interfaces;
using sample_bank_exercise_interfaces.enums;

namespace sample_bank_exercise_business.entities
{
    public class Withdrawal : Transaction
    {
        public Withdrawal(double amount) : base(amount, TransactionType.Withdrawal)
        {

        }

        public override TransactionLogItem ExecuteTransaction(Account account, Account? targetAccount = null)
        {
            var startingBalance = account.Balance;
            account.Balance -= this.Amount;

            return new TransactionLogItem($"Transaction Type : Withdrawal. Starting balance {startingBalance} - {Amount} = {account.Balance}");
        }
    }
}
