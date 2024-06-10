using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLab
{
    internal class ValidatedAnswer
    {
        public static string getValidatedAnswer()
        {
            while (true)
            {
                string input = Console.ReadLine()?.Trim().ToUpper();
                if (input == "A" || input == "B" || input == "C" || input == "D")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter A, B, C, or D.");
                }
            }
        }
    }
}
