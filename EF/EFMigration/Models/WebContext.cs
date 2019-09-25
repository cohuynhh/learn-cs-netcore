using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
 
namespace EFMigration.Models
{
    public class WebContext : DbContext
    {
        public DbSet<Article> articles {set; get;}
        public DbSet<Tag> tags {set; get;}
        public const string ConnectStrring  =  @"Data Source=localhost,1433;Initial Catalog=webdb;User ID=SA;Password=Password123";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
         {
             optionsBuilder.UseSqlServer(ConnectStrring);
             optionsBuilder.UseLoggerFactory(GetLoggerFactory());

         }
        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                    builder.AddConsole()
                           .AddFilter(DbLoggerCategory.Database.Command.Name, 
                                    LogLevel.Information)); 
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();

                    
        }
 
    }
    
}