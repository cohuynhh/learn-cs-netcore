using System.Collections.Generic;

namespace WebApp.Services
{
    public class LaptopName : IListProductName
    {
        public LaptopName() => System.Console.WriteLine("LaptopName Create");
        string[] laptops = new string[]  {"Apple MacBook Pro 13 inch", "HP Spectre X360", "Samsung Chromebook Pro"};
        public IEnumerable<string> GetNames()
        {
            return laptops;
        }
    }
}
