using sample_bank_exercise_interfaces;
using sample_bank_exercise_interfaces.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_business.entities
{
    public abstract class Account
    {

        public string Name { get; set; }

        public AccountType AccountType { get; set; }

        public List<TransactionLog> TransactionLogs { get; set; }

        public ITransactionProcessor TransactionProcessor { get; protected set; }

        public double Balance { get; private set; }


        public Account(string name, AccountType accountType)
        {
            Name = name;
            TransactionLogs = new List<TransactionLog>();
            AccountType = accountType;
            TransactionProcessor = new DefaultTransactionProcessor();
        }

        public abstract void ExecuteTransaction(ITransaction transaction);


        public virtual void AddTransactionToLog()
        {
            
        }
  

    }
}
