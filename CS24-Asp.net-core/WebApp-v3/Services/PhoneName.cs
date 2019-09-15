using System.Collections.Generic;
using System;
namespace WebApp.Services
{
    public class PhoneName : IListProductName
    {
        public PhoneName() => System.Console.WriteLine("PhoneName created");
        private List<string> phone_names =  new List<string> {
            "Iphone 7", "Samsung Galaxy", "Nokia 123"
        };
        public IEnumerable<string> GetNames()
        {
            return phone_names;
        }
    }
}