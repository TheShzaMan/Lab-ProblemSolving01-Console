using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ProblemSolving01_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Steps to Reverse a String: Write code that takes a string as input and returns the string reversed
            //1. ask user for input by writing the request to the console
            //2. create a string variable to store the user input and assign the user input as the value of this variable
            //3. find the appropriate coding to use to accomplish the task of reversing the string
            //3a. test different ideas based on what has been learned so far. debug debug debug 
            //3b. if a block is hit use resourses to find appropriate code
            //4. write the code
            //5. test the code
            //6. print finished result

            Console.WriteLine("For my next trick, I will attempt to reverse whatever you enter next!");
            Console.WriteLine("What would you like me to reverse?");

            string userInput = Console.ReadLine();
            string userInputPlus = userInput + " ";
            char[] inputAsChars = userInputPlus.ToCharArray();
            int inputLength = inputAsChars.Length;

            for (int i = 0; i < inputLength; i++)
            {
                int x = (inputAsChars.Length - 1) - i;
                Console.Write(inputAsChars[x]);
            }
            Console.WriteLine("");
            Console.WriteLine("Ta-daa!  Thank you.");

            //1.read and understand the task
            //2.need to find a way that will capitalize the last letter of ea. word in a string
            //3.experiment with different ideas on how to do this
            //4.use resources to learn different approaches not yet learned
            //5.once a method is found that works, write it out, instruct the user to provide input through printing to console, execute code and print results.

            Console.WriteLine("");
            Console.WriteLine("And now I will attempt to capitalize only the last letter of each word that you typed...");
            Console.WriteLine("Please press ENTER to see what happens"); Console.ReadLine();
            for (int i = 0; i < inputLength - 1; i++)
            {
                if ((short)inputAsChars[i + 1] == 32)
                {
                    Console.Write(char.ToUpper(inputAsChars[i]));

                }
                else
                {
                    Console.Write(inputAsChars[i]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Thank you, thank you.");
            Console.WriteLine("");


            //1. read and understand what is needed
            //2.produce user input using .ReadLine
            //3.use task 1 to reverse the string
            //4.compare reversed string to original input
            //5.report whether or not the input is a palindrome (equal to reversed)




            PdromeTest test1 = new PdromeTest(); BonusTask bonus = new BonusTask();

            test1.RunTest();

            ////1. read and understand what is needed
            ////2. problem: how to compress a string of characters
            ////3. create a class called RunBonus and instantiate after RunTest
            ////4. research options on compressing a string
            ////5. when called RunBonus will alert the user that there is a bonus and what it is, 
            ////   prompt user to enter a string of characters with random groups sizes of repeated characters,
            ////   compress the groups and print the condensed version of the string, ask user if they would like to
            ////   to do another one, and finally thank them.
            
            bonus.RunBonus();
            
            //inputAsChars = userInput.ToCharArray();
            //inputLength = inputAsChars.Length;
            //bool isPalindrome;
            //int x = (inputAsChars.Length - 1) - i;

            //for (int i = 0; i < inputLength; i++)
            //{
            //    Console.Write(inputAsChars[x]);
            //    Console.WriteLine(x);
            //}
        }
    }
}