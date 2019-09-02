using System;

namespace car_horn_nodi
{
    class Program
    {
        public class Horn {
            public void Beep() => Console.WriteLine("Beep - beep - beep ...");
        }

        public class Car {
            public void Beep()
            {
                Horn horn = new Horn();     // chức năng Beep xây dựng có định với Horn, tự tạo đối tượng horn
                horn.Beep();
            }
        }

        static void Main(string[] args)
        {
            var car = new Car();
            car.Beep();         // Beep - beep - beep ...

        }
    }
}
