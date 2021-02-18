using System;
using System.IO;
using Newtonsoft.Json;

namespace LogInformation.Classes
{
    public class JsonLogger : ILogger
    {
        public void LogInformation(string path, Type messageType, string message)
        {
            var fileMode = (File.Exists(path)) ? FileMode.Append : FileMode.Create;

            using (var stream = File.Open(path, fileMode))
            {
                var logObject = new LogObject
                {
                    MessageType = messageType,
                    Message = message,
                    LoggerType = "JsonLogger",
                    LogTime = DateTime.Now.TimeOfDay
                };

                var data = JsonConvert.SerializeObject(logObject);
                stream.Write(System.Text.Encoding.UTF8.GetBytes(data), 0, data.Length);
            }
        }
    }
}
