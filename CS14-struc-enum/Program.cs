using System;

namespace CS14_struc_enum
{
    
    class Program
    {
        enum HocLuc {Kem, TrungBinh, Kha, Gioi}
        static void Main(string[] args)
        {

            HocLuc hocluc = HocLuc.Kha;    // khai báo biến hocluc kiểu enum và khởi tạo giá trị bằng HocLuc.Kha
            switch (hocluc) 
            {
                case HocLuc.Kem: 
                    Console.WriteLine("Học lực kém");
                break;
                case HocLuc.Kha: 
                    Console.WriteLine("Học lực Kha");
                break;
                 case HocLuc.Gioi: 
                    Console.WriteLine("Học lực Giỏi");
                break;
                default:
                    Console.WriteLine("Học lực TB");
                break;

            }

            HocLuc hoc = (HocLuc)2;
            Console.WriteLine(hoc); //Kha


            HocLuc hocluc_hocsinhA = HocLuc.Kha;
            int    hocluc_hocsinhB = 2;



            // int a = (int)HocLuc.Kha;
            // Console.WriteLine(a);

        }
    }
}
