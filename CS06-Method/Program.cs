using System;

namespace CS06_Method
{
    class Program
    {
        // static double BinhPhuong(double number)
        // {
        //     double ketqua = number * number;
        //     return ketqua;
        // }


        public static void ThamChieuThamTri(ref int x) {
            x = x * x;
            Console.WriteLine(x);
        }

        public static void OutExample(out int x) {
            x = 100;
        }

        public static int giaithua(int a) {
            if (a == 1)
                return 1; // Kết thúc đệ quy

            return 
                a * giaithua (a - 1);  // Đệ quy
        }

        static void Main(string[] args)
        {
            // CS06.XinChao(); 
            // CS06.XinChao(); 
            // CS06.XinChao(); 
            
            // var max = CS06.SoLon(12, 40);
            // Console.WriteLine(max);


            // double thetich;
            // thetich = CS06.TheTich(2,10);
            // Console.WriteLine(thetich);
            // CS06.TheTich(dai: 2, cao: 3);

            // string fullname;
            
            // fullname = CS06.FullName("Nguyễn", "A");
            // Console.WriteLine(fullname);                //Nguyễn A

            // fullname = CS06.FullName("ĐINH", "NAM", "HOÀNG");
            // Console.WriteLine(fullname);                //ĐINH HOÀNG NAM

            // fullname = CS06.FullName(ten: "A", ho: "Nguyễn");              // Nguyễn A
            // fullname = CS06.FullName(tendem: "VĂN", ten: "B", ho: "PHẠM"); // PHẠM VĂN B
            // fullname = CS06.FullName(tendem: "VĂN",ho: "PHẠM",  ten: "B"); // PHẠM VĂN B
            // fullname = CS06.FullName(ho: "PHẠM", tendem: "VĂN", ten: "B"); // PHẠM VĂN B

            


            // int a;             // biến a chưa khởi tạo
            // OutExample(out a); // Giờ a = 100;

            Console.WriteLine(giaithua(5)); //120
            



        }
    }
}
