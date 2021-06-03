using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> list = new RoverList<string>();
            Console.WriteLine("What words would you like to add to the list? Type 'done' when you are done.");
            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
            Console.WriteLine(" ");
            list.Add("lebron");
            list.Add("hello");
            list.Add("bingbong");
            list.Add("cake");
            list.Add("cheese");
            list.Add("pizza");
            list.Add("mom");
            list.Add("joe");
            list.Add("banana");
            list.Add("playstation");
            list.Add("cool");
            list.Add("the");
            list.Add("when");
            list.Add("where");
            list.Add("rover");
            list.Add("red");
            Console.WriteLine(" ");

            // TODO:  Print out the list
            list.ListNodes();
            
            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            while (true)
            {
                
                String prompt = System.Console.ReadLine();
                if (prompt.Equals("done"))
                {
                    break;
                }
                else
                {
                    list.Add(prompt);
                }

            }
            Console.WriteLine(" ");

            // TODO:  Print out the list
            list.ListNodes();

            Console.WriteLine(" ");

            Console.WriteLine("What words would you like to add to the FRONT of the list? Type 'done' when you are done.");
            
            Console.WriteLine(" ");

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            while (true)
            {

                String prompt1 = System.Console.ReadLine();
                if (prompt1.Equals("done"))
                {
                    break;
                }
                else
                {
                    list.Add(0, prompt1);
                }

            }
            Console.WriteLine(" ");

            // TODO:  Print out the list
            list.ListNodes();
            Console.WriteLine(" ");

            // TODO:  Remove every word with an odd length
            Console.WriteLine("Press 'enter' to remove every word with an odd length.");
            System.Console.ReadLine();

            int listLength = list.Counter();

            for (int i = listLength - 1; i >= 0; i--)
            {

                string currentWord = list.ElementAt(i);
                if (currentWord.Length % 2 == 1)
                {

                    list.RemoveAt(i);
                }
            }

            Console.WriteLine("");

            // TODO:  Print out the list
            list.ListNodes();
            Console.WriteLine("");

            // TODO:  Clear the list
            Console.WriteLine("Press 'enter' to clear the list.");

            System.Console.ReadLine();

            list.Clear();

            Console.WriteLine("");

            // TODO:  Print out the list
            list.ListNodes();

            Console.WriteLine("");

            Console.WriteLine("Enter to execute the program. Have a nice day:)");
            System.Console.ReadLine();

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words

            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            // TODO:  Print out the list

            // TODO:  Remove every word with an odd length
            // TODO:  Print out the list

            // TODO:  Clear the list
            // TODO:  Print out the list


        }
    }
}
