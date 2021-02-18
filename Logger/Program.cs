using LogInformation;
using LogInformation.Classes;
using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            ILogger jsonLogger = new FileLogger();
            ILogger xmlLogger = new XmlLogger();

            string pathFile = "logFile.log";
            string pathJson = "logJson.log";
            string pathXml = "logXml.log";

            try
            {
                throw new NullReferenceException();
            }
            catch (Exception ex)
            {
                try
                {
                    fileLogger.LogInformation(pathFile, typeof(Exception), ex.Message);
                    jsonLogger.LogInformation(pathJson, typeof(Exception), ex.Message);
                    xmlLogger.LogInformation(pathXml, typeof(Exception), ex.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return;
            }
        }
    }
}
