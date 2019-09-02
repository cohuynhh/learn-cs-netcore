using System;

namespace car_horn_nodi
{
    class Program
    {
        public class Horn {
            int level;
            public Horn(int level) => this.level = level;
            public void Beep() => Console.WriteLine($"(level {level}) Beep - beep - beep ...");
        }

        public class Car {
            public void Beep()
            {
                Horn horn = new Horn(10);     // Khởi tạo với Horn với tham số level
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
