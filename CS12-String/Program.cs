using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Threading;
         using System.Threading.Tasks;
namespace CS12_String
{
    class Program
    {
        static void Main(string[] args)
        {
          ParallelLoopResult result = Parallel.For(0, 10, i => {
Console.WriteLine($"S {i}"); Task.Delay(10).Wait(); Console.WriteLine($"E {i}");
});

Console.WriteLine($"Is completed: {result.IsCompleted}");
        }
    }
}
