using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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
        }
        // override protected void OnModelCreating(ModelBuilder modelBuilder) {
        //     modelBuilder.Entity<Product>()
        //     .HasOne(b => b.Category)
        //     .WithMany(b => b.Products)
        //     .OnDelete(DeleteBehavior.Cascade);

        //     modelBuilder.Entity<Product>().HasIndex(p => p.Name);

        // }

        public static void EnableLogging()
        {
            using (var c = new ShopContext())  {
                IServiceProvider provider = c.GetInfrastructure<IServiceProvider>();
                ILoggerFactory loggerFactory = provider.GetService<ILoggerFactory>();
                loggerFactory.AddConsole();
            }

        }
        #region STATIC Methods 
        // Xóa database
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
        #endregion


    }
}