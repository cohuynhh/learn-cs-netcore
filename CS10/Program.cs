using System;

namespace CS10
{
    

    class Program
    {
        class Dog
        {
            string[] A = new string[] {};
            public Dog() {
                Console.WriteLine("Constructor");
            }
            ~Dog() {
                Console.WriteLine("Destructor");
            }
        }

        class C {
            public C() {
                Dog d = new Dog();

            }
        }
        static void abc()
        {
            var a = new Dog();
        }
        static void Main(string[] args)
        {
            new Dog(); 
        }
    }
}
