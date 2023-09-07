using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3VariablesAndExpressions
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask the user for 4 numbers
            //multiply the four numbers
            //print out the product
            Console.WriteLine("input a number"); //ask the user to input a number
            string inputNum1 = Console.ReadLine(); //initialize a variable for the users input 
            int num1 = Convert.ToInt32(inputNum1); //convert the string to an int 
            Console.WriteLine("input another number");
            string inputNum2 = Console.ReadLine();
            int num2 = Convert.ToInt32(inputNum2);
            Console.WriteLine("input yet another number");
            string inputNum3 = Console.ReadLine();
            int num3 = Convert.ToInt32(inputNum3);
            Console.WriteLine("input one final number");
            string inputNum4 = Console.ReadLine();
            int num4 = Convert.ToInt32(inputNum4);
            int product = num1 * num2 * num3 * num4; //multiplies the numbers together
            Console.WriteLine("The product of the your numbers =" +  product); //displays the product 
        }
    }
}
