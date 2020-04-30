using System;

namespace CS15_Error
{
    class Program
    { 
        public static void UserInput(string  s) {
            if (s.Length > 10)
            {
                Exception e = new DataTooLongExeption();
                throw e;    // lỗi văng ra
            }
            //Other code - no exeption
        } 
        static void Main(string[] args)
        { 
             try {
                 UserInput("Đây là một chuỗi rất dài ...");
             }
             catch (DataTooLongExeption e) {
                 Console.WriteLine(e.Message);
             }
             catch (Exception otherExeption) {
                 Console.WriteLine(otherExeption.Message);
             }
        }
    }
}
