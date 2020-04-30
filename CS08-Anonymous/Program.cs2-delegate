using System;

namespace CS08_Anonymous
{
    class Program
    {
        public delegate void ShowLog(string message);

        static public void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", s));
            Console.ResetColor();
        }

        static public void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Waring: {0}", s));
            Console.ResetColor();
        }

        static void Main(string[] args)
        { 
            ShowLog showLog;

            showLog = null;
            showLog += Warning;         // Nối thêm Warning vào delegate
            showLog += Info;            // Nối thêm Info vào delegate
            showLog += Warning;         // Nối thêm Warning vào delegate

            //Một lần gọi thi hành tất cả các phương thức trong chuỗi delegate
            showLog("TestLog");

        }
    }
}
