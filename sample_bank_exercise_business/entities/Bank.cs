using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_bank_exercise_business.entities
{
    public class Bank
    {
        public string Name { get; set; }    
        public List<Account> Accounts { get; set; }

        public Bank(string name)
        { 
            Name = name;
            Accounts = new List<Account>();

        }

        public void AddAccountToBank(Account account)
        { 
            Accounts.Add(account);  
        }
    }
}
