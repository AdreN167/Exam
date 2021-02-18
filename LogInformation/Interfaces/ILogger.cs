using System;

namespace LogInformation
{
    public interface ILogger
    {
        public void LogInformation(string path, Type messageType, string message);
    }
}
