using System;
using ef01.Product;

namespace ef01
{
    class Program
    {
        public static async void CreateDatabase() {
            using (var dbcontext = new ProductsContext()) 
            {
                bool result = await dbcontext.Database.EnsureCreatedAsync();
                string resultstring = result ? "tạo  thành  công" : "đã có trước đó";
                Console.WriteLine($"CSDL - {resultstring}");
            }
        } 

        static void Main(string[] args)
        {
            CreateDatabase();
            Console.ReadKey(); 
        }
    }
}
