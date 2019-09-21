using System;
using ef01;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

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
                // await  context.products.AddAsync(new Product 
                // {
                //     Name = "Sản phẩm 1",
                //     Provider = "Công ty 1"
                // });        
                // await  context.AddAsync(new Product() 
                // {
                //     Name = "Sản phẩm 2",
                //     Provider = "Công ty 1"
                // });

                var p1 = new  Product() {Name = "Sản phẩm 3", Provider = "CTY A"};
                var p2 = new  Product() {Name = "Sản phẩm 4", Provider = "CTY A"};
                var p3 = new  Product() {Name = "Sản phẩm 5", Provider = "CTY B"};

                await context.AddRangeAsync(new object[] {p1, p2, p3});

                int rows = await context.SaveChangesAsync();               // Thực hiện Insert vào DB
                Console.WriteLine($"Đã lưu {rows} sản phẩm");

                
            } 
        }

       public static async Task ReadProducts() 
        {
            using (var context = new ProductsContext()) 
            {
                // context.SetLogging();
                var products = await context.products.ToListAsync();
                Console.WriteLine("Tất cả sản phẩm");
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.ProductId,2} {product.Name,  10} - {product.Provider}");
                }
                Console.WriteLine();
                Console.WriteLine();

                products = await (from p in context.products
                                  where (p.Provider == "CTY A") select p
                                 )
                                .ToListAsync();

                Console.WriteLine("Sản phẩm CTY A");
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.ProductId,2} {product.Name,  10} - {product.Provider}");
                }

               
            } 
        }
        
        
       public static async Task RenameProduct(int id, string newName) 
        {
            using (var context = new ProductsContext()) 
            {
                 
                // context.SetLogging();
                var product = await (from p in context.products
                                  where (p.ProductId == id) select p
                                 )
                                .FirstOrDefaultAsync(); // Lấy  Product có  ID  chỉ  ra

                if (product != null)
                {
                    product.Name = newName;
                    Console.WriteLine($"{product.ProductId,2} có tên mới = {product.Name,  10}");
                    await context.SaveChangesAsync();
                }

               
            } 
        }
        // Xóa sản phẩm có ProductID = id        
        public static async Task DeleteProduct(int id) 
        {
            using (var context = new ProductsContext()) 
            {
                 
                context.SetLogging();
                var product = await (from p in context.products
                                  where (p.ProductId == id) select p
                                 )
                                .FirstOrDefaultAsync(); // Lấy  Product có  ID  chỉ  ra

                if (product != null)
                {
                    context.Remove(product);
                    Console.WriteLine($"Xóa {product.ProductId}");
                    await context.SaveChangesAsync();
                } 
            } 
        }       

        static void  Main(string[] args)
        {
             DeleteProduct(3).Wait(); 
             
        }
    }
}
