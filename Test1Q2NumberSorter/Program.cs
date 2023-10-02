//Laila Porter IGME201 Unit test 1 10/1/2023
//Question 2
//Create a console application that modifies the attached "Number Sorter" application
//to request sentences and sort the words in the sentence in ascending or descending
//alphabetical order.

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSortV1
{
    /// delegate steps
    /// 1. define the delegate method data type based on the method signature
    ///         delegate double MathFunction(double n1, double n2);
    /// 2. declare the delegate method variable
    ///         MathFunction processDivMult;
    /// 3. point the variable to the method that it should call
    ///         processDivMult = new MathFunction(Multiply);
    /// 4. call the delegate method
    ///         nAnswer = processDivMult(n1, n2);

    static class Program
    {
        delegate string LowestOrHighestFunction(string[] a);

        static void Main(string[] args)
        {
            // declare the unsorted and sorted arrays
            List<string> aUnsorted = new List<string>();
            List<string> aSorted = new List<string>();

        // a label to allow us to easily loop back to the start if there are input issues
        start:
            //have the user enter a sentance for the program to sort in alphabetical order
            Console.WriteLine("Enter a sentance");

            // read the space-separated string
            string sSentanceString = Console.ReadLine();

            // split the string into the an array of strings from where each word ends
            string[] sSentance = sSentanceString.Split(' ');

            // initialize the size of the unsorted array to 0
            int nUnsortedLength = 0;

 

            

            // now we know how many unsorted numbers there are
            // allocate the size of the unsorted array
            //aUnsorted = new double[nUnsortedLength];

            // reset nUnsortedLength back to 0 to use as the index to store the numbers in the unsorted array
            nUnsortedLength = 0;
           
            foreach (string word in sSentance)
            {
               
                // still skip the blank strings
                if (word.Length == 0)
                {
                    continue;
                }


                // store the value into the array
                //aUnsorted[nUnsortedLength] = nThisNumber;
                aUnsorted.Add(word);

                // increment the array index
                nUnsortedLength++;
            }

            // allocate the size of the sorted array
            //aSorted = new double[nUnsortedLength];

            aSorted = aUnsorted.GetRange(0, aUnsorted.Count);

            string sAscDesc = null;

            Console.Write("Sort in alphabetical order: ");
            sAscDesc = Console.ReadLine();

            LowestOrHighestFunction lowestOrHighestFunction;
            
            if (sAscDesc.ToLower().StartsWith("a"))
            {
                //lowestOrHighestFunction = new LowestOrHighestFunction(FindLowestValue);
                aSorted.Sort();
            }
            else
            {
                //lowestOrHighestFunction = new LowestOrHighestFunction(FindHighestValue);
                aSorted.Sort();
                aSorted.Reverse();
            }

            // start the sorted length at 0 to use as sorted index element
            int nSortedLength = 0;

            // while there are unsorted values to sort
            //while (aUnsorted.Length > 0)
            //{
            //    // store the lowest unsorted value as the next sorted value
            //    //aSorted[nSortedLength] = FindLowestValue(aUnsorted);
            //    aSorted[nSortedLength] = lowestOrHighestFunction(aUnsorted);
            //
            //    // remove the current sorted value
            //    RemoveUnsortedValue(aSorted[nSortedLength], ref aUnsorted);
            //
            //    // increment the number of values in the sorted array
            //    ++nSortedLength;
            //}


            // write the sorted array of numbers
            Console.WriteLine("The sorted list is: ");
            foreach (string word in aSorted)
            {
                Console.Write(word);
            }

            for (int i = 0; i < aSorted.Count; ++i)
            {
                Console.Write(aSorted[i]);
            }


            Console.WriteLine();
        }

        // find the lowest value in the array of ints
        // the method "signature" defines a method and consists of the return type (double) and method arguments (double[] array)
        static string FindLowestValue(string[] array)
        {
            // define return value
            string returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (string word in array)
            {
                // if the current value is less than the saved lowest value

                if (word.CompareTo(returnVal) < 0)
                {
                    // save this as the lowest value
                    returnVal = word;
                }
            }

            // return the lowest value
            return (returnVal);
        }


        static string FindHighestValue(string[] array)
        {
            string returnVal;

            returnVal = array[0];

            foreach (string word in array)
            {
                if (word.CompareTo(returnVal) > 0)
                {
                    returnVal = word;
                }
            }

            return (returnVal);
        }


        // remove the first instance of a value from an array
        static void RemoveUnsortedValue(string removeValue, ref string[] array)
        {
            // allocate a new array to hold 1 less value than the source array
            string[] newArray = new string[array.Length - 1];

            // we need a separate counter to index into the new array, 
            // since we are skipping a value in the source array
            int dest = 0;

            // the same value may occur multiple times in the array, so skip subsequent occurrences
            bool bAlreadyRemoved = false;

            // iterate through the source array
            foreach (string word in array)
            {
                // if this is the number to be removed and we didn't remove it yet
                if (word.ToLower() == removeValue && !bAlreadyRemoved)
                {
                    // set the flag that it was removed
                    bAlreadyRemoved = true;

                    // and skip it (ie. do not add it to the new array)
                    continue;
                }

                // insert the source number into the new array
                newArray[dest] = word;

                // increment the new array index to insert the next number
                ++dest;
            }

            // set the ref array equal to the new array, which has the target number removed
            // this changes the variable in the calling function (aUnsorted in this case)
            array = newArray;

        }
        
    }
    

}
