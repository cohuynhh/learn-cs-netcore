using System;
using System.Threading.Tasks;
using ef02.Model;

namespace ef02
{
    class Program
    {
         
        static async Task Main(string[] args)
        {
            ShopContext.EnableLogging();
            await ShopContext.DeleteDatabase();
            await ShopContext.CreateDatabase();
            await ShopContext.InsertSampleData();

            var p    = await ShopContext.FindProduct(2);
            var c    = p.Category; 
            if (p != null) 
            {
                Console.WriteLine($"{p.Name} có CategoryId = {p.CategoryId}");
                string CategoryName = (c != null) ? c.Name :  "Category đang null";
                Console.WriteLine(CategoryName);
            }

            var cat2 = await ShopContext.FindCategoryByName("Cate1");
            var cccc = cat2.products;

        }
    }
}
