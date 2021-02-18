using System.IO;
using System;

namespace LogInformation.Classes
{
    public class FileLogger : ILogger
    {
        public void LogInformation(string path, Type messageType, string message)
        {
            var fileMode = (File.Exists(path)) ? FileMode.Append : FileMode.Create;

            using (var stream = File.Open(path, fileMode))
            {
                var data = $"[{DateTime.Now.TimeOfDay}] [FileLogger] [{messageType}] [{message}]\n";
                stream.Write(System.Text.Encoding.UTF8.GetBytes(data), 0, data.Length);
            }
        }
    }
}
