using Microsoft.EntityFrameworkCore;

namespace EF.Product
{
    public class ProductsContext : DbContext
    {
        private const string connectionString = "Data Source=localhost,1433;Initial Catalog=mydata;User ID=SA;Password=Password123";

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        
        public DbSet<Product> Products {set; get;}
    }
}