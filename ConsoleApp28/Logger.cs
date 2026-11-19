using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp28
{
    internal class Logger
    {
        string Everthing = string.Empty;
        public void LogA(string value)
        {
            Everthing += $"{DateTime.Now}    User set a to {value} \n";
        }
        public void LogB(string value)
        {
            Everthing += $"{DateTime.Now}    User set b to {value} \n";
        }
        public void LogRes(string value)
        {
            Everthing += $"{DateTime.Now}    User got result {value} \n";
        }
        public void ConWrite()
        {
            Console.WriteLine(Everthing);
        }
        public void FileWrite()
        {
            File.AppendAllText("Logs.log", Everthing);
            Console.WriteLine("All logs in Logs.log");
        }
    }
}
