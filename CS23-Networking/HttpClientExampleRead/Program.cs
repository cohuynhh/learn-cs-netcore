using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace HttpClientExample
{
    public class ViduHttpClient {
        HttpClient _httpClient = null;
        public HttpClient httpClient => _httpClient ?? (new HttpClient());

        public async Task<byte[]> DownloadDataBytes(string url) 
        {
            Console.WriteLine($"Starting connect {url}");
            try {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsByteArrayAsync(); 
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public async Task<Stream> DownloadDataStream(string url) 
        {
            Console.WriteLine($"Starting connect {url}");
            try {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStreamAsync(); 
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
        class Program
    {

    static void Main(string[] args)
    {
        var httpclient = new ViduHttpClient();
        
        // Đọc dữ liệu - trả về mảng byte[]
        var url1    = "https://raw.githubusercontent.com/xuanthulabnet/jekyll-example/master/images/jekyll-01.png";
        var task1   = httpclient.DownloadDataBytes(url1); 
        task1.Wait();                       // chờ cho tải xong
        byte[] dataimg = task1.Result;  
        string filepath = "anh1.png";
        using (var stream = new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.None))
        {
            stream.Write(dataimg, 0, dataimg.Length); 
        }

        //Đọc dữ liệu - trả về stream
        string url2     = "https://raw.githubusercontent.com/xuanthulabnet/linux-centos/master/docs/samba1.png";
        var task2       = httpclient.DownloadDataStream(url2);
        int SIZEBUFFER  = 500;   
        string filepath2 = "anh2.png";
        using (var streamwrite = File.OpenWrite(filepath2))
        using (var streamread = task2.Result)
        {
            byte[] buffer = new byte[SIZEBUFFER];   // tạo bộ nhớ đệm lưu dữ liệu khi đọc stream
            bool endread = false;
            do
            {
                int numberRead = streamread.Read(buffer, 0, SIZEBUFFER);
                if (numberRead == 0) endread = true;
                else {
                    streamwrite.Write(buffer, 0, numberRead);
                }

            } while (!endread);

        }
    }
}
}
