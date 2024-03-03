using System;

namespace Problem2
{
    public class AssessmentProblem2
    {
        public void DisplayLikeCount()
        {
            List<string> namesList = new List<string>();
            string name = string.Empty;

            do
            {
                Console.WriteLine("Enter a name (press Enter to finish):");
                name = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(name))
                {
                    namesList.Add(name);
                }
            } 
            while (name.Length > 0);
            switch (namesList.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"{namesList[0]} likes your post.");
                    break;
                case 2:
                    Console.WriteLine($"{namesList[0]} and {namesList[1]} like your post.");
                    break;
                case >2:
                    Console.WriteLine($"{namesList[0]}, {namesList[1]} and {namesList.Count - 2} others like your post."); 
                    break;
            }
        }
    }
}
