namespace CourseApp
{
    using System;

    public static class Logger
    {
        private static string log;

        public static void WriteLogLine(string message)
        {
            log += message + Environment.NewLine;
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
