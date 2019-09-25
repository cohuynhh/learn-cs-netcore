using System;
using EFMigration.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var webcontext =  new WebContext()) 
            {
                // webcontext.Database.Migrate();
                // webcontext.Database.EnsureDeleted();
                // webcontext.Database.EnsureCreated();
            }
        }
    }
}
