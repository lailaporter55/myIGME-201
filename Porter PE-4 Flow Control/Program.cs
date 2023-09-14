using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porter_PE_4_Flow_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            string sNum1 = Console.ReadLine();
            int intNum1 = Convert.ToInt32(sNum1);
            
            Console.WriteLine("Enter a Number");
            string sNum2 = Console.ReadLine();
            int intNum2 = Convert.ToInt32(sNum2);
            
            if(((intNum1 < 10 &&  intNum2 < 10)||(intNum1 < 10 && intNum2 <= 10)||(intNum1 <=10 && intNum2 < 10 )) 
            {
                Console.WriteLine("true"); 
            }
            else { Console.WriteLine("false"); }
            
        }
    }
}
