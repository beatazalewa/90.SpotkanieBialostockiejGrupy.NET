using System;

namespace NLogConsoleApp
{
    public class DemoClass
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public void DemoMethod()
        {
            logger.Trace("Sample trace message");
            logger.Debug("Sample debug message");
            logger.Info("Sample informational message");
            logger.Warn("Sample warning message");
            logger.Error("Sample error message");
            logger.Fatal("Sample fatal error message");

            // alternatively you can call the Log() method
            // and pass log level as the parameter.
            //logger.Log(LogLevel.Info, "Sample informational message");

            // Example of logging an exception
            try
            {

            }
            catch (Exception ex)
            {
                logger.Error(ex, "OMG!"); // render the exception with ${exception}
                throw;
            }
        }
    }
}
