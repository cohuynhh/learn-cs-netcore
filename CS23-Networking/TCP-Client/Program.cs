using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Text;
using System.Net.Sockets;
using System.Net.Http;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace TCP
{
 
    class Program
    {    
        public static bool ValidateServerCertificate(
              object sender,
              X509Certificate certificate,
              X509Chain chain,
              SslPolicyErrors sslPolicyErrors)
        {
           if (sslPolicyErrors == SslPolicyErrors.None)  return true;
            Console.WriteLine("Certificate error: {0}", sslPolicyErrors);
            
            // Do not allow this client to communicate with unauthenticated servers.
            return false;
        }

        public static  async Task ReadHtmlAsync(string url) {

            using (var client = new TcpClient()) 
            {
                Console.WriteLine($"Start get {url}");
                Uri uri = new Uri(url);

                var hostAdress = await Dns.GetHostAddressesAsync(uri.Host);
                IPAddress ipaddrress = hostAdress[0];
                Console.WriteLine($"Host: {uri.Host}, IP: {ipaddrress}"); 
                await client.ConnectAsync(ipaddrress.MapToIPv4(), uri.Port);
                Console.WriteLine("Connected");
                Console.WriteLine();

 
                Stream stream; // stream để đọc - gửi HTTP Message
                if (uri.Scheme == "https")
                {
                    // SslStream
                    stream = new SslStream(client.GetStream(),false, 
                                           new RemoteCertificateValidationCallback (ValidateServerCertificate),
                                           null);
                   (stream as SslStream).AuthenticateAsClient(uri.Host);             
                } 
                else {
                    // NetworkStream
                    stream = client.GetStream(); 
                }
 
                // Xem: /psr-7-chuan-giao-dien-thong-diep-http.html#HTTPRequest
                StringBuilder header = new StringBuilder();
                header.Append($"GET {uri.PathAndQuery} HTTP/1.1\r\n");
                header.Append($"Host: {uri.Host}\r\n");
                header.Append($"\r\n");

                Console.WriteLine("Request:");
                Console.WriteLine(header); 

                byte[]  bsend  = Encoding.UTF8.GetBytes(header.ToString());
                await stream.WriteAsync(bsend, 0, bsend.Length);
                await stream.FlushAsync(); 


                var ms = new MemoryStream(); 
                byte [] buffer = new byte[2048];
                int bytes = -1;
                do
                {
                    bytes = await stream.ReadAsync(buffer, 0, buffer.Length);
                    ms.Write(buffer, 0, bytes);
                    Array.Clear(buffer, 0, buffer.Length); 
                    
                } while (bytes > 0);

                ms.Seek(0, SeekOrigin.Begin);
                var reader = new StreamReader(ms); 
                string html = reader.ReadToEnd(); 
                Console.WriteLine("Response:");
                Console.WriteLine(html);

            }
        }
        static async Task  Main(string[] args)
        {
            string url = "https://xuanthulab.net/robots.txt";
            await ReadHtmlAsync(url);
        }

    }
}