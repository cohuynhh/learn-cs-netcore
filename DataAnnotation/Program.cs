using System;

namespace DataAnnotation
{
    public class MyClass {
        [Obsolete("Phương thức này lỗi thời, hãy  dùng phương thức Abc")]
        public static void Method1() {
            Console.WriteLine("Phương thức chạy");
        }        
    }
    class Program
    {
       static void Main(string[] args)
        {
            MyClass.Method1(); 

        }
    }
}
