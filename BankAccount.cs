using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp_1
{
    internal class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber{ get; set; }
        public decimal Balance { get;private set; }

        public BankAccount(string Owner) 
        {
            this.Owner =Owner;
            this.AccountNumber = Guid.NewGuid();
            Balance = 0;
        
        }
        public string deposit(decimal Balance) 
        {
         if(Balance <= 0) 
                return "u cant deposit " + Balance;
            else if(Balance >9999)
                return "u cant deposit out of range " + Balance;
         else 
                this.Balance += Balance;

            return "Amount deposited successfully";
        }
        public string withdraw(decimal Balance)
        {
            if (Balance <= 0)
                return "u cant withdraw -Ve amount " + Balance;
            else if ( Balance > this.Balance)
                return "u cant withdarw out of range " + Balance;
            else
                this.Balance += Balance;

            return "Amount withdrawn successfully";
        }

    }
}
