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
    
        public Deposit() : base (TransactionType.Deposit)
        {
        }
    }
}
