namespace CourseApp
{
    using System.Collections.Generic;

    public class Logger
    {
        private string logs;

        public void WriteLogLine(string log)
        {
            logs += log + "\n\r";
        }

        public void WriteLog(string log)
        {
            logs += log;
        }

        public string ReadLog()
        {
            return logs;
        }

        public void CleanLog()
        {
            logs = string.Empty;
        }
    }
}