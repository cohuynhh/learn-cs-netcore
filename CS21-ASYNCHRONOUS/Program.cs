using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
namespace CS21_ASYNCHRONOUS
{
    class Program
    {
        static async Task<string> DownloadWebpage(string url, bool showresult) { 
            
            Func<object, string> download_func = (object thamso) => {
                using (var client = new WebClient())
                {
                    Console.Write("Starting download ...");
                    string content = client.DownloadString(url);
                    if (showresult)
                        WriteLine(content.Substring(0, 50), ConsoleColor.DarkBlue);  
                    return content; 
                } 
            };

            Task<string> task_download  = new Task<string>(download_func, null);
            task_download.Start();

            await task_download; 
            return task_download.Result;  
        }   

        
        public static void WriteLine(string s, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        } 

        static async Task<string> Async1(string thamso1, string thamso2)
        {
            Func<object, string> myfunc = (object thamso) => {
                dynamic ts = thamso;
                for (int i = 1; i <= 20; i++) 
                {                    
                    WriteLine($"{Thread.CurrentThread.ManagedThreadId,3} {ts.x, 10} {i,5} {ts.y}", ConsoleColor.Green);
                    Thread.Sleep(500);
                }
                return $"Kết thúc! {ts.x}";
            };
            Task<string> task = new  Task<string>(myfunc, new {x = thamso1, y = thamso2});

            task.Start();  // chủ ý dòng này, để đảm bảo  task được kích hoạt

            await task;    

            string ketqua= task.Result;   
            Console.WriteLine(ketqua);  
            return ketqua; 
        }


        static async Task Main(string[] args)
        { 
            string url = "https://code.visualstudio.com/";

            var x    = Async1("myfunc", "...");
            var html = DownloadWebpage(url, true);

            Console.ReadKey(); 


            await x;
            await html;
            WriteLine(html.Result.Substring(0, 50), ConsoleColor.DarkMagenta);    // kết quả download
        }


        static void Async2() {

            Action myaction = () => {
                for (int i = 1; i <= 50; i++)
                {
                    WriteLine($"{Thread.CurrentThread.ManagedThreadId,3} {"myaction", 10} {i,5}", ConsoleColor.Yellow);
                    Thread.Sleep(2000);
                }
            };
            Task task = new Task(myaction);
            task.Start();   // tạo và chạy thread
        }

        
    }
}
