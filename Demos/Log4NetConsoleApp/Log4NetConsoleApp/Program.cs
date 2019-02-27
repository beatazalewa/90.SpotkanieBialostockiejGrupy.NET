using System;

namespace Log4NetConsoleApp
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Info("Hello logging world!");
            Console.WriteLine("Please, click the Enter key");
            Console.ReadLine();
        }
    }
}
