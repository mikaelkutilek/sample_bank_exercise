using sample_bank_exercise_interfaces;
using sample_bank_exercise_interfaces.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_interfaces
{
    public abstract class Account
    {

        public string Name { get; set; }

        public Owner Owner { get; set; }
        public AccountType AccountType { get; set; }

        public TransactionLog TransactionLogs { get; set; }

        public ITransactionRulesProcessor TransactionProcessor { get; protected set; }

        public double Balance { get;  set; }


        public Account(string name, AccountType accountType)
        {
            Name = name;
            TransactionLogs = new TransactionLog();
            AccountType = accountType;
            Balance = 0;
        }

        public Account(string name, AccountType accountType, double startingBalance) : this (name, accountType)
        {
            Balance = startingBalance;
        }

        public abstract bool ExecuteTransaction(Transaction transaction);

        public abstract bool ExecuteTransaction(Transaction transaction, Account targetAccount);

    }

    //leaving this here since none of the requirements at this time actually use it.   may expand later.
    public class Owner
    {
    }
}
