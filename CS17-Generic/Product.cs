using System;
namespace CS17_Generic
{
    public class Product : IComparable<Product>, IFormattable
    {
        public int ID {set; get;}
        public string Name {set; get;}        // tên
        public double Price {set; get;}       // giá
        public string Origin {set; get;}      // xuất xứ

        public Product(int id, string name, double price, string origin) {
            ID = id; Name = name; Price = price; Origin = origin;
        }

        //Triển khai IComparable, cho biết vị trí sắp xếp so với đối tượng khác
        // trả về 0 - cùng vị trí; trả về > 0 đứng sau other; < 0 đứng trước trong danh sách
        public int CompareTo(Product other)
        {
            // sắp xếp về giá
            double delta = this.Price - other.Price;
            if (delta > 0)      // giá lớn hơn xếp trước
                return -1; 
            else if (delta < 0) // xếp sau, giá nhỏ hơn
                return 1;      
            return 0;    

        }
        // Triển khai IFormattable, lấy chuỗi thông tin của đối tượng theo định dạng
        // format hỗ trợ "O" và "N"
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null) format = "O";
            switch (format.ToUpper()) {
                case "O": // Xuất xứ trước
                    return $"Xuất xứ: {Origin} - Tên: {Name} - Giá: {Price} - ID: {ID}";
                case "N": // Xuất xứ trước
                    return $"Tên: {Name} - Xuất xứ: {Origin} - Giá: {Price} - ID: {ID}";
                default: // Quăng lỗi nếu format sai
                    throw new FormatException("Không hỗ trợ format này");
            }
        }

        // Nạp chồng ToString
        override public string ToString() => $"{Name} - {Price}";
        
        // Quá tải thêm ToString - lấy chỗi thông tin sản phẩm theo định dạng
        public string ToString(string format) => this.ToString(format, null);

    }


    public class SearchNameProduct {
        string namesearch;
        public SearchNameProduct(string name) {
            namesearch = name;
        }
        // Hàm gán cho delegage
        public bool search(Product p) {
            return p.Name == namesearch;
        }
    }
}


            // var numbers  = new List<int>() {1,2,3,4};
            // var products = new List<Product>() {
            //     new Product(1, "Iphone 6", 100, "Trung Quốc")
            // };
             
            // var p = new Product(2, "IPhone 7", 200, "Trung Quốc");
            // products.Add(p);
            // products.Add(new Product(3, "IPhone 8", 400, "Trung Quốc")); 

            // // Mảng 2 phần tử
            // var arrayProducts = new Product[] {
            //     new Product(4, "Glaxy 7", 500, "Việt Nam"),
            //     new Product(5, "Glaxy 8", 700, "Việt Nam"),
            // };
            // // Nối các phần tử của mảng vào danh sách
            // products.AddRange(arrayProducts);

            // // chèn vào index 3
            // products.Insert(3, new Product(6, "Macbook Pro", 1000, "Mỹ")); 

            // var pro = products[2];
            // Console.WriteLine(pro.ToString());
            

            // // Duyệt qua tất cả các phần tử bằng for
            // // products.Count = lấy tổng phần tử trong List
            // for (int i = 1; i < products.Count; i++) 
            // {
            //     var pi = products[i - 1];
            //     Console.WriteLine(pi.ToString());
            // }

            // Duyệt qua các phần tử bằng foreach
            // foreach (var pi in products)
            // {
            //     Console.WriteLine(pi.ToString());
            // }

            // products.RemoveAt(0);       
            // products.RemoveRange(products.Count - 2, 2); 

            // Console.WriteLine(products.Count);
            // var pro_rm = products[1];
            // products.Remove(pro_rm);
            // Console.WriteLine(products.Count);

            //Delegate trả về true khi tên bằng "Glaxy 8"
            
            
            // Product foundpr1 = products.Find( (new SearchNameProduct("Glaxy 8")).search);
            // if (foundpr1 != null)
            //     Console.WriteLine("(found) " + foundpr1.ToString("O"));

            // var ifound = products.FindIndex(x => x.Origin == "Trung Quốc");

            // List<Product> p_100 = products.FindAll(product => product.Price > 100);

            // products.Sort(
            //     (p1, p2) => {
            //         if (p1.ID > p2.ID)
            //             return 1;
            //         else if (p1.ID == p2.ID)
            //             return  0;
            //         return   -1;             
            //     }
            // );
            // foreach (var pi in products)
            // {
            //     Console.WriteLine(pi.ToString("N"));
            // }
