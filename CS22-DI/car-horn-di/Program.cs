using System;

namespace car_horn_nodi
{
    class Program
    {
        public class Horn {
            public void Beep() => Console.WriteLine("Beep - beep - beep ...");
        }

        public class Car 
        {
            Horn horn;                                      // horn là một Dependecy của Car
            public Car(Horn horn) => this.horn = horn;      // horn được Inject (bơm vào) bằng hàm khởi tạo

            public void Beep()
            {
                horn.Beep();
            }
        }

        static void Main(string[] args)
        {
            Horn horn = new Horn(); 

            var car = new Car(horn);
            car.Beep();

        }
    }
}
