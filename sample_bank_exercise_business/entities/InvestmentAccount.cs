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


        public InvestmentAccount(string name, InvestmentAccountType investmentAccountType) : base(name, AccountType.Investment)
        {
            this.investmentAccountType = investmentAccountType;

            switch (investmentAccountType)
            {
                case InvestmentAccountType.Individual:
                    TransactionProcessor = new IndividualInvestmentTransactionProcessor();
                    break;
                case InvestmentAccountType.Corporate:
                    default: TransactionProcessor = new DefaultTransactionProcessor();
                    break;
            }

        }

        public override void ExecuteTransaction(ITransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
