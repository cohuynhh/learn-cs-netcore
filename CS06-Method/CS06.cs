using System;
namespace CS06_Method
{
    public class CS06
    { 
        static public void XinChao() 
        {
            Console.WriteLine("Xin chào C# \n");
        }

        public static int SoLon(int num1, int num2)
        {
            int max = (num1 > num2) ? num1 : num2;
            return max;
        }

        public static double TheTich(double cao, double dai = 1, double rong = 1)
        {
             return cao * dai * rong;
        }

        public static string FullName(string ho, string ten, string tendem ="")
        {
            return  ho + (tendem != "" ? " " + tendem :"")  + " " + ten; 
        }
    }
}