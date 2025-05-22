using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp_1
{
    public interface ICustomer //*** planning
    {
        // interfaces are just signature or structure 
        // everything should be public and shoudnt half defined and no logic
        // only child or  derived classes can impllement body and logic.
        // one more difference is that every fiels property, method must implement by derived -
        // class which implement interface, rrmeber this 
        decimal Discount(); // by default interfaces atre public
    }
    public interface ICustomer2Enquiry //*** planning
    {
        //  2nd interface
        public string Name { get; set; }
        public void Enquiry();
    }
    public abstract class Abstract___interface_classes : ICustomer //** define common logic***
    {
        // Abstract class is half defined / partial base parent class.

        public string name { get; set; }
        
        public abstract decimal Discount();
        // this is abstarct () , it wont hv body means this will define in sub class
    }
    public abstract class Abstract___interface_classes2   //** define common logic***
    {
        // this is 2nd abstract class where everything is abstact means 
        // derived class will give body

        public abstract string name { get; set; }
        public abstract void Enquiry();
    }

    public class foreignCustomer : Abstract___interface_classes, Abstract___interface_classes2 // now this is multiple inheriitence
                                                                                               // whichis not possible in .net framwork
                                                                                               //but multiple interface can hve
    {
        public override decimal Discount()
        {
            throw new NotImplementedException();
        }
    }
    public class LocalCustomer : Abstract___interface_classes //* full class or concrete class
    {                                                           // which will write main code or logic                    
        public override decimal Discount()
        {
            throw new NotImplementedException();
        }
    }
    public class EnquireCustomer : ICustomer, ICustomer2Enquiry
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal Discount()
        {
            throw new NotImplementedException();
        }

        public void Enquiry()
        {
            throw new NotImplementedException();
        }
    }
    public class StanderdCustomer : Abstract___interface_classes
    {
        public override decimal Discount()
        {
            throw new NotImplementedException();
        }
    


    public static void Main(String[] args)
        {              // reference variable  
            ICustomer customer1 = new LocalCustomer(); // object initilise of localcustomer clas
            customer1.Enquiry();

            ICustomer customer2 = new StanderdCustomer(); // object initilise of standerdcustomer clas
            customer2.Enquiry();
        }

    }

}
