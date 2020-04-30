using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Threading.Tasks;
namespace CS17_Generic
{

    class Program
    { 
        
        

        static void Main(string[] args)
        {
             HashSet<int> hashset1 = new HashSet<int>() {
                 5,2,3,4
             };
             Console.WriteLine($"Phần tử trong hashset1 {hashset1.Count}");
             foreach (var v in hashset1)
             {
                 Console.Write(v + " ");
             }
             Console.WriteLine();

            HashSet<int> hashset2 = new HashSet<int>();
            hashset2.Add(3);
            hashset2.Add(4);
            if (hashset1.IsSupersetOf(hashset2))
                Console.WriteLine($"hashset1 là tập chứa hashset2");
             

            
        }
    }
}









// //SortedList
// var products = new SortedList<string, string>();
// products.Add("Iphone 6", "P-IPHONE-6");         // Thêm vào phần tử mới (key, value)
// products.Add("Laptop Abc", "P-LAP");            
// products["Điện thoại Z"] = "P-DIENTHOAI";       // Thêm vào phần tử bằng Indexer
// products["Tai nghe XXX"] = "P-TAI";             // Thêm vào phần tử bằng Indexer    

// Console.WriteLine("TÊN VÀ MÃ");

// // Duyệt qua các phần tử, mỗi phần tử lấy key/value lưu trong biến
// // kiểu KeyValuePair
// foreach (KeyValuePair<string, string> p in products)
// {
//     Console.WriteLine($"    {p.Key} - {p.Value}");
// }
// // kết quả: (để ý danh sách đã xếp theo key)
// // TÊN và MÃ
// //     Điện thoại Z - P-DIENTHOAI
// //     Iphone 6 - P-IPHONE-6
// //     Laptop Abc - P-LAP
// //     Tai nghe XXX - P-TAI

// string productName = "Tai nghe XXX";
// Console.WriteLine($"{productName} có mã là {products[productName]}"); // Đọc value khi biết  key

// products[productName] = "P-TAI-UPDATED";   // Cập nhật giá trị vào phần tử theo key


// // Duyệt qua các giá trị
// Console.WriteLine("\nDANH SÁCH MÃ SẢN PHẢM");
// foreach (var product_code in products.Values)
// {
//     Console.WriteLine($"--- {product_code}");
// }
// // kết quả:
// // DANH SÁCH MÃ SẢN PHẢM
// // -- P-DIENTHOAI
// // -- P-IPHONE-6
// // -- P-LAP
// // -- P-TAI-UPDATED


// // Duyệt qua các key
// Console.WriteLine("\nDANH SÁCH TÊN SP");
// foreach (var product_name in products.Keys)
// {
//     Console.WriteLine($"... {product_name}");
// }
// // DANH SÁCH TÊN SP
// // -- Điện thoại Z
// // -- Iphone 6
// // -- Laptop Abc
// // -- Tai nghe XXX