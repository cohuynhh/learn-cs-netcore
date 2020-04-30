using System;
using System.Threading.Tasks;
using EFMigration.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMigration
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var webcontext =  new WebContext()) 
            {
                // webcontext.Database.Migrate();
                // webcontext.Database.EnsureDeleted();
                // webcontext.Database.EnsureCreated();
                await webcontext.Database.MigrateAsync();
            }
        }
    }
}
