using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp_1
{
    public class BankAccount
    {
        // fiels or u can say variable holds value
        public string Owner { get; set; }
        public Guid AccountNumber{ get; set; }
        public decimal Balance { get;protected set; }

        // constructor
        public BankAccount(string Owner) 
        {
            this.Owner =Owner;
            this.AccountNumber = Guid.NewGuid();
            Balance = 0;
        
        }
        // incaptulazation concept here applying likr if any body 
        // wants to access properties than need to follow condition which wriiten inside this function

        // also making it virtual because this () inherit in derived class where it will not called instead its derived ()
        // wiil call because that has diifereent logic compare to this.
        public virtual string deposit(decimal Balance) 
        {
         if(Balance <= 0) 
                return "u cant deposit " + Balance;
            else if(Balance >9999)
                return "u cant deposit out of range " + Balance;
         else 
                this.Balance += Balance;

            return "Amount deposited successfully";
        }
       // same here
        public virtual string withdraw(decimal Balance)
        {
            if (Balance <= 0)
                return "u cant withdraw -Ve amount " + Balance;
            else if ( Balance > this.Balance)
                return "u cant withdarw out of range " + Balance;
            else
                this.Balance -= Balance;

            return "Amount withdrawn successfully";
        }

    }
}
