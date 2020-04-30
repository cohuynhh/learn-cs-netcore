using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions .DependencyInjection;
using Microsoft.EntityFrameworkCore.Infrastructure;
namespace ef01
{
    public class ProductsContext : DbContext
    {
        private const string connectionString = "Data Source=localhost,1433;Initial Catalog=mydata;User ID=SA;Password=Password123";
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
          

        }
        public void SetLogging() 
        {
              IServiceProvider provider = this.GetInfrastructure<IServiceProvider>();
             ILoggerFactory loggerFactory = provider.GetService<ILoggerFactory>(); 
             loggerFactory.AddConsole();
        }
        public DbSet<Product> products {set; get;}
    }
}