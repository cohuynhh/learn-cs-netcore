using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace car_horn_nodi
{
    class Program
    {
        public class MyServiceOptions  {
            public string data1 {set;  get;}
            public int data2 {set;  get;}
        }

        public class  MyService  {
            readonly string data1;
            readonly int data2;
            public MyService(IOptions<MyServiceOptions> options)
            {
                data1 = options.Value.data1;
                data2 = options.Value.data2;
                Console.WriteLine("MyService created");
            }
            public void ShowData() => Console.WriteLine($"{data1} - {data2}");
        }
     
        static void Main(string[] args)
        {
            
            var services = new ServiceCollection(); 
            services.AddOptions();
            // Đăng ký Options
            services.Configure<MyServiceOptions>(
                (MyServiceOptions  options) => {
                    options.data1 = "DATA1";
                    options.data2 = 2;
                }
            );
            // Đăng ký dịch vụ
            services.AddTransient<MyService>();
            
            var serviceprovider = services.BuildServiceProvider();   // Tạo serviceprovider

            var myservice = serviceprovider.GetService<MyService>(); // yêu cầu dịch vụ MyService
            myservice.ShowData();

        
            var config = serviceprovider.GetService<IOptions<MyServiceOptions>>();
            
            MyServiceOptions myServiceOptions = config.Value;
            
            var opts = Options.Create(new MyServiceOptions() {
                data1 = "DATA-DATA-DATA-DATA-DATA",
                data2 = 12345
            });
            MyService myService = new MyService(opts);
            myService.ShowData();


            // new MyService(i); 
            // var a = serviceprovider.GetService<IOptions<MyServiceOptions>>();


            
            
             
 
        }
    }
}
