namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public static class Logger
    {
        private static string log;

        public static void WriteLogLine(string message)
        {
            log += message + "\n\r";
        }

        public static void WriteLog(string message)
        {
            log += message;
        }

        public static void ReagLog()
        {
            Console.WriteLine(log);
        }
    }
}