using System;

namespace CS11_Class
{ 
    class Product {
        private string product_name;
        public Product(string name) 
        {
            this.product_name = name;
            Console.WriteLine("Tạo - " + product_name);
        }
        ~Product() {
            Console.WriteLine("Hủy - " + product_name);
        }
    }
 
}
