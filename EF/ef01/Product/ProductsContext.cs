using Microsoft.EntityFrameworkCore;

namespace ef01.Product
{
    public class ProductsContext : DbContext
    {
        private const string connectionString = "Data Source=localhost,1433;Initial Catalog=mydata;User ID=SA;Password=Password123";
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        
        public DbSet<Product> products {set; get;}
    }
}