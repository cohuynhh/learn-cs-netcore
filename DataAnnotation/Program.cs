using System;
using DataAnnotation.Attributes;

namespace DataAnnotation
{

    [Mota("Lớp biểu diễn người dùng")]
    public class User 
    {
        [Mota("Thuộc tính lưu tuổi")]
        public int age {set; get;}
        [Mota("Phương thức này hiện thị age")]
        public void ShowAge() 
        {
        }
    }
    class Program
    {
       static void Main(string[] args)
        {
            var a = new User();
            
            foreach (Attribute attr in a.GetType().GetCustomAttributes(false))
            {
                MotaAttribute mota =  attr as MotaAttribute;
                if (mota != null)
                {
                    Console.WriteLine($"{a.GetType().Name,10} : {mota.Description}");
                }
            }

            foreach (var thuoctinh in a.GetType().GetProperties())
            {
                foreach (Attribute attr in thuoctinh.GetCustomAttributes(false))
                {
                    MotaAttribute mota =  attr as MotaAttribute;
                    if (mota != null)
                    {
                        Console.WriteLine($"{thuoctinh.Name,10} : {mota.Description}");
                    }
                }
            } 


            foreach (var m in a.GetType().GetMethods())
            {
                foreach (Attribute attr in m.GetCustomAttributes(false))
                {
                    MotaAttribute mota =  attr as MotaAttribute;
                    if (mota != null)
                    {
                        Console.WriteLine($"{m.Name,10} : {mota.Description}");
                    }
                }
            } 
            
            

        }   
    }
}
