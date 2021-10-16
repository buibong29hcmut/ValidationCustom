using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace LoggingComponent
{
    public class Logging
    {
        // [Conditional("LOG_INFO")]
        [Obsolete("The LogToScreen method has now been deprecated. Please use the 'LogToFile' method instead",false)]
        public static void LogToScreen(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void LogToFile(string msg)
        {
            Console.WriteLine("Simulating logging text to file, " + msg);
        }
    }
}
