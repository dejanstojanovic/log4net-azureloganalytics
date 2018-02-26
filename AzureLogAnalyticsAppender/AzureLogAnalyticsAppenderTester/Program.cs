using System;
using log4net;

namespace AzureLogAnalyticsAppenderTester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            var logger = LogManager.GetLogger(typeof(Program));
            for (int i = 0; i < 10; i++)
            {
                logger.Info($"INFO message {i}");
            }
            //logger.Debug("Debug message.");
            //logger.Warn("Warning  message.");
            //logger.Error("Error message.", new ArgumentNullException(nameof(args)));
            //logger.Fatal("Fatal message.", new ArgumentNullException(nameof(args)));

            Console.ReadKey();
        }
    }
}
