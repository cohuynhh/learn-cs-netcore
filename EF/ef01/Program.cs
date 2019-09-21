using System;
using ef01;
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
        public static async void DeleteDatabase() 
        {
            Console.Write("Có chắc chắn xóa DB (y) ? "); 
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                using (var context = new ProductsContext()) 
                {
                    bool deleted = await context.Database.EnsureDeletedAsync(); 
                    string deletionInfo = deleted ? "đã xóa db" : "không xóa được db"; 
                    Console.WriteLine($"{deletionInfo}");
                } 
            }
        }

        public static async void InsertProduct() 
        {
            using (var context = new ProductsContext()) 
            {
                await  context.products.AddAsync(new Product {
                    Name = "Sản phẩm 1",
                    Provider = "Công ty 1"
                });        
                await  context.AddAsync(new Product() {
                    Name = "Sản phẩm 2",
                    Provider = "Công ty 1"
                });

                int rows = await context.SaveChangesAsync();               // Thực hiện Insert vào DB
                Console.WriteLine($"Đã lưu {rows} sản phẩm");
            } 
        }

        static void Main(string[] args)
        {
            InsertProduct();
            Console.ReadKey(); 
        }
    }
}
