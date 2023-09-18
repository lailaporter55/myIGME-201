using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace PE7MadLibsPorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Do you want to play madLibs?");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                {

                    //create an empty madlib array 
                    string[] madLibs = null;

                    int numLibs = 0;
                    int count = 0;
                    int nChoice = 0;

                    string finalStory = "";

                    StreamReader input;
                    input = new StreamReader("c:\\Desktop\\IGME201\\PE-7 - Mad Libs attached files Sep 17, 2023\\MadLibsTemplate.txt");

                    string line = null;
                    while ((line = input.ReadLine()) != null)
                    {
                        ++numLibs;
                    }
                    input.Close();

                    madLibs = new string[numLibs];

                    input = new StreamReader("c:\\Desktop\\IGME201\\PE-7 - Mad Libs attached files Sep 17, 2023\\MadLibsTemplate.txt");
                    line = null;
                    while ((line = input.ReadLine()) != null)
                    {
                        // set this array element to the current line of the template file
                        madLibs[count] = line;

                        // replace the "\\n" tag with the newline escape character
                        madLibs[count] = madLibs[count].Replace("\\n", "\n");

                        ++count;
                    }

                    input.Close();
                    Console.WriteLine("What is your name?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter a number between 1 - {0}", numLibs);
                    string numstring = Console.ReadLine();
                    try
                    {
                        nChoice = Int32.Parse(numstring);
                    }
                    catch
                    {
                        Console.WriteLine("unable to parse");
                    }
                    string emptyMadLib = madLibs[nChoice];
                    string[] words = emptyMadLib.Split();
                    foreach (string word in words)
                    {
                        //if word is \n
                        if (word[0] == '\n')
                        {
                            finalStory += word;

                        }
                        //if word is a prompt
                        if (word[0] == '{')
                        {
                            string replaceWord = word.Replace("{", "").Replace("}", "").Replace("_", " ");
                            // prompt the user for the replacement
                            Console.Write("Input a {0}: ", replaceWord);
                            // and append the user response to the result string
                            finalStory += Console.ReadLine();
                        }
                        else
                        {
                            finalStory += word;
                        }
                    }
                }
                if (answer.ToLower() == "no")
                {
                    Console.WriteLine("GoodBye");
                    break;
                }
                else
                {
                    Console.WriteLine("Do you want to play madLibs?");
                    answer = Console.ReadLine();
                }


            }
        }
    }
}
