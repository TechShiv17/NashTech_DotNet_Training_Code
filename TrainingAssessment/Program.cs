using Problem1;
using Problem2;
using Problem3;
using Problem4;
using Problem5;
using System;

namespace Dotnet_Training
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Problem 1 -

            AssessmentProblem1 assessmentProblem1 = new();

            //assessmentProblem1.GenerateVariableName();

            // Problem 2 -

            AssessmentProblem2 assessmentProblem2 = new();

            //assessmentProblem2.DisplayLikeCount();

            // Problem 3 -
            
            Stopwatch stopwatch = new();

            /*
            stopwatch.Start();
            //Uncomment below to start Stopwatch twice so it throws InvalidOperationException;
            //stopwatch.Start();
            stopwatch.Stop();
            var duration = stopwatch.GetElapsedTime();
            Console.WriteLine($"Elapsed time: {duration}");

            // Start the stopwatch again
            stopwatch.Start();
            stopwatch.Stop();

            duration = stopwatch.GetElapsedTime();
            Console.WriteLine($"Elapsed time: {duration}");
            */

            // Problem 4 -

            Post post = new Post("Sample Title", "Sample Description");

            /*
            post.Upvote();
            post.Upvote();
            post.Downvote();
            post.Display();
            */

            // Problem 5 -

            /*
            IActivity[] fileLogActivity = new IActivity[] {new FileLogActivity("data.txt", "sample file is written") };
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(fileLogActivity);
            */

        }
    }
}