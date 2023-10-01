//Laila Porteer Exam 1, question1 10/1/23
//Create a console application that enhances the attached "Math Quiz Application"
//to include division.  Note that you will have to replace the int variables with
//doubles and you should round the quotient to 2 decimal places and indicate that the
//user should enter their answer to 2 decimal places.  (dAnswer = Math.Round(dAnswer,2))

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz
{
    static class Program
    {
        static void Main()
        {
            // store user name
            string myName = "";

            // string and int of # of questions
            string sQuestions = "";
            int nQuestions = 0;

            // string and base value related to difficulty
            string sDifficulty = "";
            // double for division
            double nMaxRange = 0.0;

            // constant for setting difficulty with 1 variable
            // double for divison 
            const double MAX_BASE = 10.0;

            // question and # correct counters
            int nCntr = 0;
            int nCorrect = 0;

            // operator picker
            int nOp = 0;

            // operands and solution
            //change val1, val2, and answer to doubles so they work w division
            double val1 = 0.0;
            double val2 = 0.0;
            double dAnswer = 0.0;

            // string and int for the response
            string sResponse = "";
            Int32 nResponse = 0;

            // play again?
            string sAgain = "";

            bool bValid = false;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            // seed the random number generator
            Random rand = new Random();

            Console.WriteLine("Math Quiz!");
            Console.WriteLine();

            // fetch the user's name into myName
            while (true)
            {
                Console.Write("What is your name-> ");
                myName = Console.ReadLine();

                int len = myName.Length;
                //if( !len )
                if (myName.Length > 0)
                {
                    break;
                }
            }

        // label to return to if they want to play again
        start:

            // initialize correct responses for each time around
            nCorrect = 0;

            Console.WriteLine();

            // ask how many questions until they enter a valid number
            do
            {
                Console.Write("How many questions-> ");
                sQuestions = Console.ReadLine();
                bValid = int.TryParse(sQuestions, out nQuestions);
            } while (!bValid);

            Console.WriteLine();

            // ask difficulty level until they enter a valid response
            do
            {
                Console.Write("Difficulty level (easy, medium, hard)-> ");
                sDifficulty = Console.ReadLine();
                sDifficulty = sDifficulty.ToLower().Trim();

                //sDifficulty.ToLower();  does NOT change the contents of sDifficulty!
            } while (sDifficulty != "easy" &&
                      sDifficulty != "medium" &&
                      sDifficulty != "hard");

            Console.WriteLine();

            // if they choose easy, then set nMaxRange = MAX_BASE, unless myName == "David", then set difficulty to hard
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3
            switch (sDifficulty)
            {
                case "easy":
                    nMaxRange = MAX_BASE;

                    if (myName.ToLower() == "laila")
                    {
                        goto case "hard";
                    }
                    break;

                case "medium":
                case "med":
                    nMaxRange = MAX_BASE * 2.0;
                    break;

                case "hard":
                    nMaxRange = MAX_BASE * 3.0;
                    break;
            }

            // ask each question
            for (nCntr = 0; nCntr < nQuestions; ++nCntr)
            {
                // generate a random number between 0 inclusive and 3 exclusive to get the operation
                nOp = rand.Next(0, 3);
                //needs to be double for division 
                //rand.NextDouble only allows for a range of 0.0-1.0 so multiply nMaxRange, then add nMaxRange to get the correct value
                //https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers
                val1 = (rand.NextDouble() * nMaxRange) + nMaxRange; 
                val2 = rand.NextDouble() * nMaxRange;

                // if either argument is 0, pick new numbers
                if (val1 == 0 || val2 == 0)
                {
                    --nCntr;
                    continue;
                }

                // if nOp == 0, then addition
                // if nOp == 1, then subtraction
                // else multiplication
                if (nOp == 0)
                {
                    dAnswer = val1 + val2;
                    dAnswer = Math.Round(dAnswer, 2); 
                    sQuestions = $"Question #{nCntr + 1}: {val1} + {val2} => ";
                }
                else if (nOp == 1)
                {
                    dAnswer = val1 - val2;
                    dAnswer = Math.Round(dAnswer, 2);
                    sQuestions = $"Question #{nCntr + 1}: {val1} - {val2} => ";

                }
                else if (nOp == 2)
                {
                    dAnswer = val1 * val2;
                    dAnswer = Math.Round(dAnswer, 2);
                    sQuestions = $"Question #{nCntr + 1}: {val1} * {val2} => ";
                }
                else 
                {
                    dAnswer = val1 / val2;
                    dAnswer = Math.Round(dAnswer, 2);
                    sQuestions = $"Question #{nCntr + 1}: {val1} / {val2} => ";
                }

                bValid = false;

                // display the question and prompt for the answer until they enter a valid number
                do
                {
                    Console.Write(sQuestions);
                    sResponse = Console.ReadLine();

                    try
                    {
                        nResponse = int.Parse(sResponse);
                        bValid = true;
                    }
                    catch
                    {
                        Console.WriteLine("please enter an integer.");
                        bValid = false;
                    }
                } while (!bValid);

                // if response == answer, output flashy reward and increment # correct
                // else output stark answer
                if (nResponse == dAnswer)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Well done, {0}!!", myName);
                    ++nCorrect;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I'm sorry {0}, the answer is {1}", myName, dAnswer);
                }

                // restore the screen colors
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
            }

            Console.WriteLine();

            // output how many they got correct and their score
            Console.WriteLine("You got {0} correct out of {1}, which is a score of {2:P2}", nCorrect, nQuestions, (double)nCorrect / nCntr);

            Console.WriteLine();

            do
            {
                // prompt if they want to play again
                Console.Write("Do you want to play again? ");

                sAgain = Console.ReadLine();

                // if they type y or yes then play again
                // else if they type n or no then leave this loop
                if (sAgain.ToLower().Trim().StartsWith("y"))
                {
                    goto start;
                }
                else
                {
                    break;
                }
            } while (true);
        }
    }
}
