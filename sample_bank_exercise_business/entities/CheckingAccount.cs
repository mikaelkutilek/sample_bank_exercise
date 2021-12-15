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

        public CheckingAccount(string name) : base(name, AccountType.Checking)
        {
            // no extra work here - since this is using the default processor.
        }



        public override void ExecuteTransaction(ITransaction transaction)
        {

            throw new NotImplementedException();
        }
    }
}
