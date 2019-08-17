using System;

namespace CS07_Class
{
   

    class Student 
    {
        private string name;

        public string Name 
        {
            // set thi hành khi gán, write
            // dữ liệu gán là value
            set 
            {
                Console.WriteLine("Ghi dữ liệu <--" + value);
                name = value;
            }

            //get thi hành ghi đọc dữ liệu
            get {
                return "Tên là: " + name;
            }
        }
    }
    
    


    class Program
    {


        static void Main(string[] args)
        {
            var s = new Student();
            s.Name = "XYZ";
             
            Console.WriteLine(s.Name);

            // var sungluc = new VuKhi("SÚNG LỤC", 10);
            // VuKhi sungtruong = new VuKhi(name: "SÚNG TRƯỜNG", dosatthuong: 50);

            // sungluc.TanCong();
            // sungtruong.TanCong();

            // double a = 1;
            // double b = 2;
            // var c  = OverloadingExample.Sum(a, b); // c có kiểu double
        }
    }
}
