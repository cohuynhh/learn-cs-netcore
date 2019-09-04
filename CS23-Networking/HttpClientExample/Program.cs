using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HttpClientExample
{
    
    class Program
    {
        public static void ShowHeaders(HttpHeaders headers) 
        {
            Console.WriteLine("Các Header:");
            foreach (var header in headers) 
            {
                string value = string.Join(" ", header.Value);              //  Nối các giá trị header lại
                Console.WriteLine($"{header.Key,20} : {value}"); 
             }
            Console.WriteLine(); 
         }


        public static async Task<string> GetWebContent(string url) 
        {
            using (var httpClient = new  HttpClient())
            {
                Console.WriteLine($"Starting connect {url}");
                try {
                    httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml+json");
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Tải thành công - statusCode {(int)response.StatusCode} {response.ReasonPhrase}");
                        ShowHeaders(response.Headers);
                        Console.WriteLine("Starting read data");
                        string htmltext = await response.Content.ReadAsStringAsync(); 
                        Console.WriteLine($"Received payload of {htmltext.Length} characters"); 
                        Console.WriteLine();
                        return htmltext;
                    }
                    else 
                    {
                        Console.WriteLine($"Lỗi - statusCode {response.StatusCode} {response.ReasonPhrase}");
                        return null;
                    }
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
        }
        static void Main(string[] args)
        {
            var htmltask = GetWebContent("https://google.com.vn");

            htmltask.Wait();
            var html = htmltask.Result;
            Console.WriteLine(html!=null ? html.Substring(0, 150): "Lỗi"); 
        }
    }
}