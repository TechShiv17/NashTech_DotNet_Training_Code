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
        private string text;

        public FileLogActivity(string filePath, string text)
        {
            this.filePath = filePath;
            this.text = text;
        }

        public void Execute()
        {
            try
            {
                // Append the text with a timestamp to the log file
                string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {text}";
                System.IO.File.AppendAllText(filePath, logEntry);
                Console.WriteLine("Successfully logged text to file: {0}", filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging text to file: {ex.Message}");
            }
        }
    }

}
