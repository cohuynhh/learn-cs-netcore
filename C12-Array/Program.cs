using System;
using System.Linq;

namespace C12_Array
{
    class Program
    {
      
        static void Main(string[] args)
        {
            
            int[][] myArray = new int[][] 
            {
                new int[] {1,2},
                new int[] {2,5,6},
                new int[] {2,3},
                new int[] {2,3,4,5,5}
            };

            foreach (var arr in myArray) {
                foreach (var e in arr) {
                    Console.Write(e + " ");
                }
                Console.WriteLine();
            }
// 1 2 
// 2 5 6 
// 2 3 
// 2 3 4 5 5 



        }


    }
}
