using AutomationFramework.Config;
using System;
using System.IO;
namespace AutomationFramework.Helpers
{
    public class LogHelper
    {

        //Global Declaration
        private static string logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter streamw = null;

        //Create a file to store the log information
        public static void CreateLogFile()
        {
          
            string dir = Setting.LogPath;
            if (Directory.Exists(dir))
            {
                streamw = File.AppendText(dir + logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                streamw = File.AppendText(dir + logFileName + ".log");
            }

        }

        //Create a method to write the text in the log file
        public static void Write(string logMessage)
        {
            streamw.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            streamw.WriteLine("   {0}", logMessage);
            streamw.Flush();
        }
    }
}
