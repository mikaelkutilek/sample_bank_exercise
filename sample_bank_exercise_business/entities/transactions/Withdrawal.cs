using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sample_bank_exercise_interfaces.enums;

namespace sample_bank_exercise_business.entities
{
    public class Withdrawal : Transaction
    {
        public Withdrawal() : base(TransactionType.Withdrawal)
        {

        }
    }
}
