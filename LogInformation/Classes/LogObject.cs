using System;

namespace LogInformation.Classes
{
    public class LogObject
    {
        public Type MessageType { get; set; }
        public string Message { get; set; }
        public string LoggerType { get; set; }
        public TimeSpan LogTime { get; set; }
    }
}
