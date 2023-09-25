using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PE8_MoreABTVarPorterQ7
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            char[] reversed;

            Console.WriteLine("Enter a word");
            string sWord = Console.ReadLine();
            char[] wordChar = sWord.ToCharArray();
             reversed = char[].Reverse(wordChar);
            Console.WriteLine("reversed = " reversed);

        }
    }
}
