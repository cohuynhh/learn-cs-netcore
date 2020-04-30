using System;

namespace CS08_Anonymous
{
    class Program
    { 
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

        static void TinhTong(int a, int b, Action<string> callback)
        {
            int c = a + b;
            callback("Tổng là: "  + c);
            
        }
      
        
        static void Main(string[] args)
        { 
             TinhTong(5, 7, Info);
             TinhTong(3, 4, Warning); 
        }
    }
}
