﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorterSquashTheBugs
{
    namespace SquashTheBugs
    {
        // Class Program
        // Author: David Schuh
        // Purpose: Bug squashing exercise
        // Restrictions: None
        class Program
        {
            // Method: Main
            // Purpose: Loop through the numbers 1 through 10 
            //          Output N/(N-1) for all 10 numbers
            //          and list all numbers processed
            // Restrictions: None
            static void Main(string[] args)
            {
                // declare int counter
                int i = 0; //logical error no ; 
    
            // loop through the numbers 1 through 10
            for (i = 1; i < 10; ++i)
                {
                    // declare string to hold all numbers
                    string allNumbers = null;

                    // output explanation of calculation
                    Console.Write("i = ",i , "/" , i - 1 , " = "); //logical error: the + should be ,

                    // output the calculation based on the numbers
                    Console.WriteLine(i / (i - 1));

                    // concatenate each number to allNumbers
                    allNumbers += i + " ";

                    // increment the counter
                    i = i + 1;
                }

                // output all numbers which have been processed
                Console.WriteLine("These numbers have been processed: " allNumbers);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
