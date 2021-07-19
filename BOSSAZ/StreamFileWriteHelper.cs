using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSSAZ
{
    public static class StreamFileWriteHelper
    {
        private static string logErrorFile = $"../Log Errors {DateTime.Now.Year}/LogErrorTime - {DateTime.Now.ToLongDateString()}.txt";

        private static void PrepareFile()
        {
            if (!Directory.Exists($"../Log Errors {DateTime.Now.Year}"))
                Directory.CreateDirectory($"../Log Errors {DateTime.Now.Year}");

            string[] log = logErrorFile.Split('-');

            DateTime now = Convert.ToDateTime(log[1].Substring(0, log[1].IndexOf('.') - 1).Trim());

            if (now.Date.CompareTo(DateTime.Now.Date) < 0)
                logErrorFile = $"../Log Errors {DateTime.Now.Year}/LogErrorTime - {DateTime.Now.ToLongDateString()}.txt";
        }
        public static void WriteLogErrorFile(in string message)
        {
            PrepareFile();
            using (StreamWriter writetext = new StreamWriter(logErrorFile, true))
            {
                writetext.WriteLine($"{message}, Time  {DateTime.Now.Hour}:{DateTime.Now.Minute} \"Format(Hour:Minute)\"\n");
            }
        }
    }
}

