using System;

namespace CS11_Class
{  
    class Program
    {
        
        class IndexerExam {
            string ho = "Nguyễn";
            string ten = "Nam";  
            public string this[int index]
            {
                get { 
                    if (index == 0) return ho;
                    else if (index == 1) return ten;
                    else throw new Exception("Chỉ số không tồn tại");
                 }
                set { 
                    if (index == 0)  ho = value;
                    else if (index == 1) ten = value;
                    else throw new Exception("Chỉ số không tồn tại");
                }
            }

        }

        static void Main(string[] args)
        {
            IndexerExam obj = new IndexerExam();

            Console.WriteLine(obj[0] + " " + obj[1]);      // đọc obj.ho và obj.ten
            obj[0] = "Đinh";                               // gán obj.ho 
            obj[1] = "Quang Hưng";                         // gán obj.name 
            Console.WriteLine(obj[0] + " " + obj[1]);      // đọc obj.ho và obj.ten

            

        }
    }
}
