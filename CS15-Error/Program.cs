using System;

namespace CS15_Error
{
    class Program
    {
        public static double Thuong(double x, double y) {
            if (y == 0) {
                // phát sinh ngoại lệ do số chia bằng 0.
                Exception myexception = new Exception("Số chia không được bằng 0");
                throw myexception;
            }
            return x / y;

        }
        static void Main(string[] args)
        { 
            double z = Thuong(100,0);
        }
    }
}
