using System;
using A.B;

namespace A {
    // Định nghĩa các lớp, cấu trúc ...
    namespace B {
        // Định nghĩa các lớp, cấu trúc ...
    }
}

namespace CS13_Inheritance
{

    class Animal {
        protected int Legs {get; set;}
        public float Weight {get; set;}

        public void ShowLegs() 
        {
            Console.WriteLine($"Legs: {Legs}");
        }
    }

    class Cat : Animal {
        public string food;
        public Cat() 
        {
            Legs = 4; // Thuộc tính Legs có sẵn - vì nó kế thừa từ Animal
            food = "Mouse";
        }

        public void Eat() 
        {
            Console.WriteLine(food);
        }
        
    }

     
    class Program
    {
        class A {

        };
        class B : A {

        };

        class C : B {

        }

        static void Main(string[] args)
        { 
            C c = new C();
            A a =  (A)c;

              a = c;  
              a = new C();

           
        }


    }
}
