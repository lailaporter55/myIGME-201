using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public interface IMood
    {
        string Mood { get; }
    }
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        public byte sugar;
        public string size;
        public Customer customer;

        public virtual void AddSugar(byte amount)
        {
            Console.WriteLine("add {0} amount of sugar", amount);
        }
        public abstract void Steam();

        public HotDrink(string brand)
        {
            
        }
    }

    public interface ITakeOrder
    {
        void IakeOrder();
    }

    public class Waiter : IMood
    {
        public string name; 
        public string Mood
        {
            get
            {
                return this.Mood;
            }
        }
        public void ServeCustomer(HotDrink cup)
        {
            Console.WriteLine("customer is served {cup}", cup);
        }
    }
    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber; 
        public string Mood
        {
            get
            {
                return this.Mood; 
            }
        }
    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType; 
        public void IakeOrder()
        {
            Console.WriteLine("What would you like to order?");
        }

        public override void Steam()
        {
            Console.WriteLine("Steaming the milk");
        }

        public CupOfCoffee(string brand) :  base(brand) 
        {
            
        }
    }
    
    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;

        public CupOfTea(string brand) : base(brand)
        {
        }

        public void IakeOrder()
        {
            throw new NotImplementedException();
        }

        public override void Steam()
        {
            throw new NotImplementedException();
        }
        public CupOfTea(bool customerIsWealthy)
        {
        }

    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        public CupOfCocoa() : this(false)
        {
        }
        public CupOfCocoa(bool marshmellows) : base("Expensive Organic Brand")
        {

        }

        public void IakeOrder()
        {
            throw new NotImplementedException();
        }

        public override void Steam()
        {
            throw new NotImplementedException();
        }
    }
}
