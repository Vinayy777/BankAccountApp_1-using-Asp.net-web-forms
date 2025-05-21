using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp_1
{
    // inheritence concept here
    public class SavingAccount : BankAccount
    {

        public decimal InterestRate {  get; set; }
        // here base means first base class coonstructor invok than this class
        public SavingAccount(string owner ,decimal interestRate) : base(owner + " ( "+interestRate +"%)") 
        { 
        
            InterestRate = interestRate;
       
        }
        // here polymorphism applies because this () overide on parent's same method
        public override string deposit(decimal amount)
        {
            if (amount <= 0)
                return "You can't deposit " + amount;

            if (amount > 9999)
                return "You can't deposit - out of range: " + amount;

            this.Balance += amount + ((InterestRate / 100) * amount);
            return "Amount deposited successfully";
        }
        // same here
        public override string withdraw(decimal amount)
        {
            if (amount <= 0)
                return "You can't deposit " + amount;

            if (amount > 9999)
                return "You can't deposit - out of range: " + amount;

            this.Balance -= amount + ((InterestRate / 100) * amount);
            return "Amount deposited successfully";
        }
    }
}
