using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
namespace CS21_ASYNCHRONOUS
{
    class Program
    {
        static string DownloadWebpage(string url, bool showresult) { 
            using (var client = new WebClient())
            {
                Console.Write("Starting download ...");
                string content = client.DownloadString(url);
                Thread.Sleep(3000);
                if (showresult)
                    Console.WriteLine(content.Substring(0, 150)); 
                    
                return content; 
            }   
        } 

 // static async Task<string> DownloadWebpageAsync(string url, bool showresult) {
        //     Func<object, string> downloadfunction = (object thamso) => {
        //         dynamic ts = thamso;
        //         return DownloadWebpage(ts.url, ts.showresult);
        //     }; 
        //     Task<string> taskdownload = new Task<string>(downloadfunction, new {url = url, showresult = showresult});
            
        //     taskdownload.Start();                                           // Bắt đầu thread

        //     // Các đoạn code thực hiện trong khi luồng taskdownload đang chạy
        //     Console.WriteLine("Do something while taskdownload is running");

        //     // string html = taskdownload.Result;   - nếu đọc kết quả ở đây là lỗi, vì không biết  taskdownload kết  thúc chưa
            
        //     // taskdownload.Wait();    // Chờ cho taskdownload hoàn thành, code phía sau mới được thực hiện
        //     // string html = taskdownload.Result;
        //     // return html;

        //     await taskdownload;
        //     return taskdownload.Result;


             
 
        // }

        public static void WriteLine(string s, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        } 

        static void Async1(string thamso1, string thamso2)
        {
            Func<object, string> myfunc = (object thamso) => {
                dynamic ts = thamso;
                for (int i = 1; i <= 5; i++) 
                {                    
                    WriteLine($"{Thread.CurrentThread.ManagedThreadId,3} {ts.x} {i,5} {ts.y}", ConsoleColor.Green);
                    Thread.Sleep(500);
                }
                return "Kết thúc!";
            };
            Task<string> task = new  Task<string>(myfunc, new {x = thamso1, y = thamso2});
            task.Start();
            
            // thread cha không bị khóa
            Thread.Sleep(2000);
            WriteLine("Làm gì đó khi task đang chạy ...", ConsoleColor.Red);

            string ketqua= task.Result;   // khóa (block) thread cha - chờ task hoàn thành

            Console.WriteLine("Làm gì đó khi task đã kết thúc");  
        }
        static void Async2() {

            Action myaction = () => {
                for (int i = 1; i <= 50; i++) 
                {
                    WriteLine($"{Thread.CurrentThread.ManagedThreadId,3} myaction {i,5}", ConsoleColor.Yellow);
                    Thread.Sleep(2000);
                }
            };
            Task task = new Task(myaction); 
            task.Start(); 
        }
 
        static void Main(string[] args)
        { 
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId,3} MainThread"); 

            Async1("myfunc  ", "...");
            Async2();     

            Console.ReadKey();
            Console.ResetColor(); 
        }
    }
}
