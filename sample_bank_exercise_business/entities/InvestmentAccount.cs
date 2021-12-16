using sample_bank_exercise_interfaces;
using sample_bank_exercise_interfaces.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_business.entities
{
    public class InvestmentAccount : Account
    {
        public InvestmentAccountType investmentAccountType { get; private set; }


        public InvestmentAccount(string name, InvestmentAccountType investmentAccountType, double startingBalance) : base(name, AccountType.Investment, startingBalance)
        {
            this.investmentAccountType = investmentAccountType;

            switch (investmentAccountType)
            {
                case InvestmentAccountType.Individual:
                    TransactionProcessor = new IndividualInvestmentTransactionRulesProcessor();
                    break;
                case InvestmentAccountType.Corporate:
                    default: TransactionProcessor = new DefaultTransactionRulesProcessor();
                    break;
            }

        }

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
