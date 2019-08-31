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


        public static void WriteLine(string s, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
        }
        
    
        static void Main(string[] args)
        { 
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId,3} MainThread");
                     

            Func<object, string> myfunc = (object thamso) => {
                dynamic ts = thamso;
                for (int i = 1; i <= 50; i++) 
                {                    
                    WriteLine($"{Thread.CurrentThread.ManagedThreadId,3} {ts.x} {i,5} {ts.y}", ConsoleColor.Green);
                    Thread.Sleep(500);
                }
                return "Kết thúc!";
            };
            Task<string> task1 = new  Task<string>(myfunc, new {x = "myfunc  ", y = "..."});


            Action myaction = () => {
                for (int i = 1; i <= 50; i++) 
                {
                    WriteLine($"{Thread.CurrentThread.ManagedThreadId,3} myaction {i,5}", ConsoleColor.Yellow);
                    Thread.Sleep(2000);
                }
            };
            Task task2 = new Task(myaction); 

            

            task1.Start();
            task2.Start(); 
            
            
            Console.ReadKey();
            Console.ResetColor();


            // string url = "https://code.visualstudio.com/";
            
            // Func<object,string> downloadtask  = (object thamso) => {
            //    dynamic prs = thamso; 
            //    return DownloadWebpage(prs.url, prs.showresult); 
            // };
            
            // Task<string> t1 = new Task<string>(downloadtask, new {url = url, showresult = true}) ;
            // t1.Start();

            // Console.WriteLine("DO Somthing (2) ...");
            // Console.ReadLine();
            // //t1.Wait();
             
        }
    }
}
