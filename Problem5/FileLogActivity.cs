using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    public class FileLogActivity : IActivity
    {
        private string filePath;
        private string message;

        public FileLogActivity(string filePath, string message)
        {
            this.filePath = filePath;
            this.message = message;
        }

        public void Execute()
        {
            try
            {
                // Append the message with a timestamp to the log file
                string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}{Environment.NewLine}";
                System.IO.File.AppendAllText(filePath, logEntry);
                Console.WriteLine("Successfully logged message to file: {0}", filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging message to file: {ex.Message}");
            }
        }
    }

}
