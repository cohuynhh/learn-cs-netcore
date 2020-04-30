using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Text;

namespace HttpListenerExample
{
 
    class Program
    {    
        public static byte[] GetHtmlPage(HttpListenerRequest request) {
            string format = @"<!DOCTYPE html>
                                <html lang=""en""> 
                                    <head><meta charset=""UTF-8"">{0}</head> 
                                    <body>{1}</body> 
                                </html>";
            string head = "<title>Test WebServer</title>";
            var body = new StringBuilder();
            body.Append("<h1>Request Info</h1>");
            body.Append("<h2>Request Header:</h2>");
            
            // Header infomation
            var headers = from key in request.Headers.AllKeys 
                    select $"<div>{key} : {string.Join(",", request.Headers.GetValues(key))}</div>";
            body.Append(string.Join("", headers));

            //Extract request properties
            body.Append("<h2>Request properties:</h2>");
            var properties = request.GetType().GetProperties();
            foreach (var property in properties)
            {
                var name_pro = property.Name;
                string value_pro;
                try {
                    value_pro = property.GetValue(request).ToString();
                }
                catch (Exception e)  {
                    value_pro = e.Message;
                }
                body.Append($"<div>{name_pro} : {value_pro}</div>");
                
            };
            string html = string.Format(format, head, body.ToString());                    
            return Encoding.UTF8.GetBytes(html);
        }

        public static async Task RunWebserverAsync(params string[] prefixes) {
            if (!HttpListener.IsSupported)
                throw new Exception("Máy không hỗ trợ HttpListener.");
            if (prefixes == null || prefixes.Length == 0) 
                throw new ArgumentException("prefixes");
            HttpListener listener = new HttpListener();
            
            foreach (string s in prefixes)
            {
                listener.Prefixes.Add(s);
            }
            Console.WriteLine("Server start ...");
            listener.Start();
            
            do {
                HttpListenerContext     context = await listener.GetContextAsync();
                HttpListenerRequest     request  = context.Request;
                HttpListenerResponse    response = context.Response;

                context.Response.Headers.Add("content-type",  "text/html");
                context.Response.StatusCode = (int)HttpStatusCode.OK;
                byte[] buffer               = GetHtmlPage(context.Request);

                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                await output.WriteAsync(buffer,0,buffer.Length); 
                
                
            } while (true);
            
            //  listener.Stop();    

        }



        static async Task  Main(string[] args)
        {
            await RunWebserverAsync(new string[] {"http://*:8080/"});
            Console.ReadKey();
        }

    }
}
