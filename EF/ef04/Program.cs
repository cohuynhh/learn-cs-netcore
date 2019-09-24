using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ef02.Model;
using Microsoft.EntityFrameworkCore;

namespace ef02
{
    class Program
    {
         
        static async Task Main(string[] args)
        {
            await ShopContext.DeleteDatabase();
            await ShopContext.CreateDatabase();
            await ShopContext.InsertSampleData();
            ShopContext.EnableLogging();


            using (var context = new ShopContext())
            {
                // var pr = new Product() {
                //     ProductId  = 4,
                //     Name = "Abc"
                // };
                // var pr_e = context.Attach(pr);
                // pr_e.Property(p =>  p.Name).IsModified  = true;
                // context.SaveChanges();
 
            }

        }
    }
}
