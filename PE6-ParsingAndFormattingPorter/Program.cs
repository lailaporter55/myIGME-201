using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PE6_ParsingAndFormattingPorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //generates a random num btw 0 (inclusive) and 101 (exclusive) (0->100)
            string stringGuess = "";
            Int32 intGuess = 0;
            int randomNumber = rand.Next(0, 101);
            int count = 0; 
            Console.WriteLine("random number=" + randomNumber);
            for(int i = 0; i < 8;  i++)
            {
                Console.WriteLine("Turn #{0}: Enter your guess:", i);
                stringGuess = Console.ReadLine();
                bool bValid = false; 
                try
                {
                    intGuess = int.Parse(stringGuess);
                    bValid = true;
                }
                catch
                {
                    Console.WriteLine("please enter an integer.");
                    bValid = false;
                }
                while (bValid)
                {   
                    //if the guess is correct 
                    if (intGuess == randomNumber)
                    {
                        Console.WriteLine("Correct!");
                        break;
                    }
                    //if the guess is lower than random number  
                    else if (intGuess < randomNumber) 
                    {
                        Console.WriteLine("Too low");
                    }
                    //if the guess is higher than random number
                    else if (intGuess > randomNumber) 
                    {
                        Console.WriteLine("Too high");
                    }
                    //if the guess is an invalid number (i.e smaller than 0, larger than 100) 
                    else
                    {
                        Console.WriteLine("Invalid guess - try again");
                    }
                    count++; 
                }
            }
            if (count == 8)
            {
                Console.WriteLine("You ran out of turns. The number was {0}.", randomNumber);
            }
            Console.WriteLine("Correct! You won in {0} turns.", count);

        }
    }
}
// To make this program better we could code a way for the user to quit and play again
