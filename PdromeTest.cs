using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving01_C_
{
    internal class PdromeTest
    {
        public string userInput;
        public string reversedString;
        public bool tryAgain;

        public void IntroducePdromeTest()
        {
            Console.WriteLine("");
            Console.WriteLine("Now, check out this program I made that will take text you enter, analyze it and report back as to whether or not it is a palindrome.");
        }

        public string InputText()
        {
            Console.WriteLine("Enter text to be palindrome tested:");
            userInput = Console.ReadLine();
            return userInput;
        }

        public void Analyze(string userInput)
        {
            
            char[] inputAsChars = userInput.ToCharArray();
            int inputLength = inputAsChars.Length;
            int x = 0;
            bool isPdrome = true;
            for (int i = 0; i < inputLength; i++)
            {
                x = (inputAsChars.Length - 1) - i;
                //Console.Write(inputAsChars[x]);
                if (inputAsChars[i] == inputAsChars[x])
                {
                    isPdrome = true;
                }
                else
                {
                    isPdrome = false;
                    break;
                }
            }
            if (isPdrome)
            {
                Console.WriteLine("YES! Palindrome");
            }
            else
            {

                Console.WriteLine("nope, Sorry. Plain ol' normal text.");
            }

            //return isPdrome;
        }   
        public bool TryAnother()
        {
            Console.WriteLine("Want to try another one?  y/n");
            string tryAgainInput = Console.ReadLine();
            //bool tryAgain = false;
            if (tryAgainInput == "y" || tryAgainInput == "Y")
            {
                Console.WriteLine("Okay, cool!");
                tryAgain = true;
            }
            else if (tryAgainInput == "n" || tryAgainInput == "N")
            {
                Console.WriteLine("Okay, thank you and I hope you liked it. ");
                tryAgain = false;
                
            }
            else
            {
                Console.WriteLine("Invalid response.  Please enter either a 'y' or an 'n'.");
                TryAnother();
            }
            return tryAgain;
        }
        

        public void RunTest()
        {
         //   bool tryAgain = tryAgain;

            IntroducePdromeTest();
            InputText();
            Analyze(userInput);
            TryAnother();           
            while (tryAgain == true)  //not exiting the loop when n is selected
            {
                InputText();
                Analyze(userInput);
                TryAnother();           
            }


        }
    }
}
