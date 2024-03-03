using System;
using System.Globalization;

namespace Problem1
{
    public class AssessmentProblem1
    {
        public void GenerateVariableName()
        {
            Console.WriteLine("Enter words seperated by space:");
            string input = Console.ReadLine();
            string[] wordsArray = input.ToLower().Split(' ');
            string newVariableName = string.Empty;

            foreach (string word in wordsArray)
            {
                var firstChar = word[0].ToString().ToUpper();
                var result = word.Remove(0, 1);
                newVariableName += result.Insert(0, firstChar);
            }
            Console.WriteLine($"Variable name : {newVariableName}");
        }
    }
}