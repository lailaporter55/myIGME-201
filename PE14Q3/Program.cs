using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14Q3
{
    //use interface and 2 classes from #2
    public interface IPorter
    {
        void write();
    }
    public class FirstName : IPorter
    {

        public void write()
        {
            throw new NotImplementedException();
            Console.WriteLine("Laila");
        }
    }
    public class LastName : IPorter
    {


        public void write()
        {
            throw new NotImplementedException();
            Console.WriteLine("Porter");
        }
    }
    internal class Program
    {
        //create a method that uses the interface to call the common method name (.write())
        public static void MyMethod(object myObject)
        {
            if(myObject.GetType() is IPorter iPorter)
            {
                iPorter.write();
            }
            else
            {
                Console.WriteLine("null");
            }
        }
        static void Main(string[] args)
        {
            //create instances of classes 
            FirstName laila = new FirstName();
            LastName porter = new LastName();
            
            //implement method using the classes
            MyMethod(laila);
            MyMethod(porter);
        }
    }
}
