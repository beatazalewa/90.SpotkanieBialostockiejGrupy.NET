using System;
namespace NLogConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info("Hello World");
            Console.ReadLine();
        }
    }
}
