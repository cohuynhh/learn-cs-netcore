using System;
using System.Collections;
using System.Collections.Generic;
namespace CS18_LINQ
{
    public class Product
    {
        public int ID {set; get;}
        public string Name {set; get;}         // tên
        public double Price {set; get;}        // giá

        public string[] Colors {set; get;}

        public int Brand {set; get;}            // Nhãn hiệu, hãng

        public Product(int id, string name, double price, string[] colors, int brand) {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        override public string ToString() => $"ID {ID} - {Name}, giá {Price}"; 

        static List<Product> _products; 
                public static List<Product> products { 
                    get {
                        if (_products == null) 
                        {
                            _products = new List<Product>() 
                            {
                                new Product(1, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                                new Product(2, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                                new Product(3, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                                new Product(4, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                                new Product(5, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
                            };
                        }
                        return _products;
                    }
        }

    }
 
    public class  Brand {
        public string Name {set; get;}
        public int ID {set; get;}

        static List<Brand> _brands; 
        public static List<Brand> brands { 
            get {
                if (_brands == null) {
                    _brands = new List<Brand>() {
                        new Brand{ID = 1, Name = "Công ty AAA"},
                        new Brand{ID = 2, Name = "Công ty BBB"},
                        new Brand{ID = 4, Name = "Công ty CCC"},
                    };
                }
                return _brands;
            }
        } 
    }
}