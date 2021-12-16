using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sample_bank_exercise_interfaces;
using sample_bank_exercise_interfaces.enums;

namespace sample_bank_exercise_business.entities
{
    public class Transfer : Transaction
    {

        public Transfer(double amount) : base(amount, TransactionType.Transfer) { 
        
        
        }

        //hmmm - this should probably be shared between the accounts....
        public override TransactionLogItem ExecuteTransaction(Account account, Account? targetAccount = null)
        {
            if (targetAccount == null)
                return new TransactionLogItem("Transfer requires an initiator account and a target account");

            var originStartBalance = account.Balance;
            var targetStartBalance = targetAccount.Balance;

            account.Balance -= this.Amount;
            targetAccount.Balance += this.Amount;

            return new TransactionLogItem($"Transaction : Transfer of {this.Amount} from Account {account.Name} to Account {targetAccount.Name}. " +
                $" Initial balance for Account : {account.Name} - {originStartBalance} \n " +
                $" Initial balance for Account : {targetAccount.Name} - {targetStartBalance} \n" +
                $" Final Balances {account.Name} - {account.Balance} ||| {targetAccount.Name} - {targetAccount.Balance}");
        }
    }
}
