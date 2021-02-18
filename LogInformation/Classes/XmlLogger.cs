using System;
using System.Xml.Serialization;
using System.IO;

namespace LogInformation.Classes
{
    public class XmlLogger : ILogger
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
                    LoggerType = "XmlLogger",
                    LogTime = DateTime.Now.TimeOfDay
                };

                var serializer = new XmlSerializer(logObject.GetType());

                serializer.Serialize(stream, logObject);
            }
        }
    }
}
