using sample_bank_exercise_interfaces;
using sample_bank_exercise_interfaces.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_business.entities
{
    public class Deposit : Transaction
    {
    
        public Deposit(double amount) : base (amount, TransactionType.Deposit)
        {
        }

        public override TransactionLogItem ExecuteTransaction(Account account, Account? targetAccount = null)
        {

            var startingBalance = account.Balance;
            account.Balance += this.Amount;

            return new TransactionLogItem($"Transaction Type : Deposit.  Starting balance: {startingBalance} + deposit amount: {this.Amount} = {account.Balance}");
        }
    }
}
