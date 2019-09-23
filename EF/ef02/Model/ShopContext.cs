using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace ef02.Model
{
    public class ShopContext : DbContext
    {
        protected string connect_str = @"Data Source=localhost,1433;
                                         Initial Catalog=shopdata;
                                         User ID=SA;Password=Password123";
        public DbSet<Product> products {set; get;}
        public DbSet<Category> categories {set; get;}


        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connect_str);
            // optionsBuilder.UseLazyLoadingProxies();
    
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity => {
               

            });

            
            
            // Các Fluent API

            // modelBuilder.Entity<Product>()
            // .HasOne(b => b.Category)
            // .WithMany(b => b.Products)
            // .OnDelete(DeleteBehavior.Cascade);

            // modelBuilder.Entity<Product>().HasIndex(p => p.Name);

        }

        public static void EnableLogging()
        {
            using (var c = new ShopContext())  {
                IServiceProvider provider = c.GetInfrastructure<IServiceProvider>();
                ILoggerFactory loggerFactory = provider.GetService<ILoggerFactory>();
                loggerFactory.AddConsole();
            }

        }
         
        public static async Task DeleteDatabase()
        {
            using (var context = new ShopContext())
            {
                bool deleted = await context.Database.EnsureDeletedAsync();
                string deletionInfo = deleted ? "đã xóa db" : "không xóa được db";
                Console.WriteLine($"{deletionInfo}");
            } 
        }
        // Xóa database
        public static async Task CreateDatabase()
        {
            using (var context = new ShopContext())
            {
                bool created = await context.Database.EnsureCreatedAsync();
                string createdInfo = created ? "Đã tạo mới" : "Đã tồn tại";
                Console.WriteLine($"{createdInfo}");
            } 
        } 

        public static async Task InsertSampleData()  
        {
            using (var context = new ShopContext())
            {
                await context.AddRangeAsync(
                    new Category() {Name = "Cate1", Description = "Description1"},
                    new Category() {Name = "Cate2", Description = "Description2"}
                );
                await context.SaveChangesAsync();
                Category cate2 = await  (from c  in context.categories where c.Name == "Cate2" select c)
                                        .FirstOrDefaultAsync();
                Category cate1 = await  (from c  in context.categories where c.Name == "Cate1" select c)
                                        .FirstOrDefaultAsync();
                                       
                await  context.AddRangeAsync(
                    new Product()  {Name = "Sản phẩm 1",    Price=12, Category = cate2},
                    new Product()  {Name = "Sản phẩm 2",    Price=11, Category = cate2},
                    new Product()  {Name = "Sản phẩm 3",    Price=33, Category = cate2},
                    new Product()  {Name = "Sản phẩm 4(1)", Price=323, Category = cate1},
                    new Product()  {Name = "Sản phẩm 5(1)", Price=333, Category = cate1}

                );             
                await context.SaveChangesAsync(); 
            } 
        }

        public static async Task<Product> FindProduct(int id) {
            using (var context = new ShopContext())
            {
                 
                var p =  await (from c  in context.products where c.ProductId == id select c)
                                        .FirstOrDefaultAsync();
                await  context.Entry(p).Reference(x => x.Category).LoadAsync();
                 
                return  p;
                 
            } 
        }

        public static async Task<Category> FindCategoryByName(string namecate) 
        {
            using (var context = new ShopContext())
            {
                 
                var category =  await (from c  in context.categories where c.Name == namecate select c)
                                        .FirstOrDefaultAsync();
                await  context.Entry(category).Collection(x => x.products).LoadAsync();
                return  category;
                 
            } 
        }


    }
}