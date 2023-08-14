using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving01_C_
{
    internal class BonusTask
    {
        private string userInput = "";
        private bool doAnother = true;
        
        public void AlertToBonus()
        {
            Console.WriteLine("");
            Console.WriteLine("Wait!  There's a bonus...");
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Here's a bonus program that will take the text you enter and condense it into groups of repeated characters.");
            Console.WriteLine("Try a random string of characters with random groupings of repeats. ex. aaakkeeeehssssssnnne");
        }

        public string RequestForInput()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter text to be condensed:");
            userInput = Console.ReadLine();
            return userInput;

        }

        public void CompressInput()
        {
            char[] inputCharArray = userInput.ToCharArray();
            int length = inputCharArray.Length;
            Console.WriteLine(""); Console.WriteLine("...");
            int count = 1;
            
            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    if (inputCharArray[i] == inputCharArray[i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        Console.Write(inputCharArray[i] + " ");
                    }
                }
                else if (i == length - 1)
                {
                    if (inputCharArray[i] == inputCharArray[i - 1] && count > 1)
                    {
                        Console.Write(count);
                    }
                    Console.WriteLine(inputCharArray[i]);
                }
                else if (inputCharArray[i] == inputCharArray[i + 1])
                {
                    count++;
                }
                else
                {
                    if (inputCharArray[i] == inputCharArray[i - 1] && count > 1)
                    {
                        Console.Write(count);
                        count = 1;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write(inputCharArray[i] + " ");
                }
            }
        }

        public bool DoAnotherOne()
        {
            Console.WriteLine("Would you like to do another? y/n");
            string tryAgainInput = Console.ReadLine();
            if (tryAgainInput == "y" || tryAgainInput == "Y")
            {
                doAnother = true;
            }
            else if (tryAgainInput == "n" || tryAgainInput == "N")
            {
                doAnother = false;
            }
            else
            {
                Console.WriteLine("Invalid response.  Please enter either a 'y' or an 'n'.");
                DoAnotherOne();
            }
            return doAnother;
        }

        public void SayGoodBye()
        {
            Console.WriteLine("");
            Console.WriteLine("Thank you for taking the time to check this out.");
            Console.WriteLine("I really hope you enjoyed it. Good Bye.");
        }
        public void RunBonus()
        {
            AlertToBonus();

            while (doAnother == true)
            {
                RequestForInput();
                CompressInput();
                DoAnotherOne();
            }
            SayGoodBye();

        }
    }
}
