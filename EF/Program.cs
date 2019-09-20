using System;
using EF.Product;

namespace EF
{
   
    class Program
    {
        public static async void CreateDb() {
            using (var dbcontext = new ProductsContext()) 
            {
                bool result = await dbcontext.Database.EnsureCreatedAsync();
                string resultstring = result ? "tạo  thành  công" : "đã có trước đó";

                Console.WriteLine($"CSDL - {resultstring}");
            }
        }
        static void Main(string[] args)
        {
            CreateDb();
            Console.ReadKey();
        }
    }
}

//dotnet add package System.Data.SqlClient
// dotnet add package Microsoft.EntityFrameworkCore
// dotnet add package Microsoft.EntityFrameworkCore.SqlServer
// dotnet add package Microsoft.EntityFrameworkCore.Design
// dotnet add package Microsoft.Extensions.DependencyInjection
// dotnet add package Microsoft.Extensions.Logging.Console