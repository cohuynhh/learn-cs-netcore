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
        }
    }
}
