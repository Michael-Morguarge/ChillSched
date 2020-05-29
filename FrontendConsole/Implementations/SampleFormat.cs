using ConsoleApp.Customize.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Customize.Implementation
{
    public class SampleFormat : ICustomConsoleColor
    {
        public void DisplayText(string text)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(text);

            Console.ResetColor();
        }

        public void Actions()
        {
            string dogName = string.Empty;
            bool dogNameSet = false;

            while (!dogNameSet)
            {
                Console.Beep();
                Console.WriteLine("What is your dog's name?");
                dogName = Console.ReadLine().Trim();
                Console.WriteLine();

                if (!string.IsNullOrEmpty(dogName) && dogName.Length > 3 && dogName.Distinct().Count() > 3)
                {
                    dogNameSet = true;
                    Console.WriteLine($"Pretend your {dogName} is king.\r\n");
                }
                else
                {
                    Console.WriteLine("Please enter a valid dog name.\r\n");
                }
            }

            int attempts = 3;
            bool respectsNotPaid = true;
            string firstLetter = dogName.First().ToString().ToLower();
            string hintDogName = dogName.Replace(firstLetter, firstLetter.ToUpper());

            while (respectsNotPaid)
            {
                Console.Beep();
                Console.WriteLine($"{hintDogName} wants you to pay respects.");
                string input = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (input == firstLetter || input == firstLetter.ToUpper())
                {
                    respectsNotPaid = false;
                    Console.WriteLine($"You have officially paid respects to {hintDogName}. {hintDogName} is pleased. You are dismissed.\r\n");
                }
                else
                {
                    Console.WriteLine($"{hintDogName} is not pleased. You have {--attempts} left.");
                }

                if (attempts == 0)
                {
                    respectsNotPaid = false;
                    Console.WriteLine($"{hintDogName} is done with your lack of respect. You have been executed.");
                }
            }
        }
    }
}
