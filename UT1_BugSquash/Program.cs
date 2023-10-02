//Laila Porter 10/1/23
//Q14 Debugging 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        //static void Main(string[] args)
       // {
           // string sNumber;
           
            //int nY compile-time error does not conatin ; 
            //int nX; 
            //int nY; 
            //int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); compile-time error, missing ""
            //Console.WriteLine("This program calculates x ^ y.");

            // logical error main function must come after the Power function especially since Power is being called in main 
            //do
            //{
              //  Console.Write("Enter a whole number for x: ");
               // //Console.ReadLine(); needs to contain sNumber so that there is a local variable, logical error
             // //  sNumber = Console.ReadLine();
            //} 
            //while (!int.TryParse(sNumber, out nX));
            //do
           // {
                //Console.Write("Enter a positive whole number for y: ");
              //  sNumber = Console.ReadLine();
            //} //while (int.TryParse(sNumber, out nX)); logical error
            //while (int.TryParse(sNumber, out nY));

            // // compute the exponent of the number using a recursive function
            //nAnswer = Power(nX, nY);

          //  Console.WriteLine("{0}^{1} = {3}" ,nX, nY, nAnswer); //logical error, needs to put the values for the place holders, and place holders should be numbers
        //}


        int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 0;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                nextVal = Power(nBase, nExponent + 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            // returnVal; compile-time error, needs to say return 
            return returnVal; 
        }
            static void Main(string[] args)
            {
                string sNumber;

                //int nY compile-time error does not conatin ; 
                int nX;
                int nY;
                int nAnswer;

                //Console.WriteLine(This program calculates x ^ y.); compile-time error, missing ""
                Console.WriteLine("This program calculates x ^ y.");

                do
                {
                    Console.Write("Enter a whole number for x: ");
                    //Console.ReadLine(); needs to contain sNumber so that there is a local variable, logical error
                    sNumber = Console.ReadLine();
                }
                while (!int.TryParse(sNumber, out nX));
                do
                {
                    Console.Write("Enter a positive whole number for y: ");
                    sNumber = Console.ReadLine();
                } //while (int.TryParse(sNumber, out nX)); logical error
                while (int.TryParse(sNumber, out nY));

                // compute the exponent of the number using a recursive function
                nAnswer = Power(
                    nX, nY);

                Console.WriteLine("{0}^{1} = {3}", nX, nY, nAnswer); //logical error, needs to put the values for the place holders, and place holders should be numbers
            }
        }
}

