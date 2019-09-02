using System;
using Microsoft.Extensions.DependencyInjection;

namespace car_horn_nodi
{
    class Program
    {
    
    static ServiceProvider RegisterServices() {
        var services = new ServiceCollection(); 
        services.AddScoped<IHorn, HeavyHorn>(); 
        
        services.AddTransient<Car>(); 

        services.AddSingleton(provider => {
            Console.Write("Doing somthing");
            return new LightHorn();
        });
 
        
        
        return services.BuildServiceProvider();
    }


        public interface IHorn {
            void Beep();
        }


        public class Car 
        {
            
            IHorn horn;    // horn là một Dependecy của Car, triển khai từ Interface IHorn

            public Car(IHorn horn) =>  this.horn = horn;

            public void Beep()
            {
                horn.Beep(); 
            }
        }

        public class HeavyHorn : IHorn
        {
            public HeavyHorn() => Console.WriteLine("Init horn");
            public void Beep() => Console.WriteLine("(kêu to lắm) BEEP BEEP BEEP ...");
        }

        public class LightHorn : IHorn
        {
                        public LightHorn() => Console.WriteLine("Light horn");

            public void Beep() => Console.WriteLine("(kêu bé lắm) beep  bep  bep ...");
        }



        abstract class  ABase {
            public void ShowInfo() => Console.WriteLine($"{this.GetType().Name}-{this.GetHashCode()}");
            public void NotifyCreate() => Console.WriteLine($"{this.GetType().Name} created");
        }

        class A:ABase {
            public A() => NotifyCreate();
        }
        class B :ABase {
            A dependency;
            public B(A dependency) {
                 this.dependency = dependency;
                 NotifyCreate();
            }
        }

        class C:  ABase {
            public C() => NotifyCreate();
        } 

        class D: ABase {
            A dependency;
            int x;
            public D(A dependency, int x) {
                 this.dependency = dependency;
                 this.x = x;
                 NotifyCreate();
            }
        }

        static D CreateDService(IServiceProvider serviceProvider) {
            return new D(serviceProvider.GetService<A>(), 123);
        }

        static void Main(string[] args)
        {
                // Tạo và cấu hình ServiceCollection
                var services = new ServiceCollection(); 
                services.AddSingleton<A>();                             // Đăng ký dịch vụ A,  kiểu singleton
                services.AddTransient<B>();                             // Đăng ký dịch vụ B, kiểu transient
                services.AddScoped<C>();                                // Đăng ký dịch vụ C, kiểu scoped
                services.AddSingleton<D>((ServiceProvider) =>  new D(ServiceProvider.GetService<A>(), 123));


                var serviceprovider = services.BuildServiceProvider();  // Tạo serviceprovider

                //SỬ DỤNG

                // Yêu cầu dịch vụ B, DI tự động tạo A và Inject vào B khi B khởi tạo
                B b = serviceprovider.GetService<B>();                  

                // Yêu cầu lại dịch vụ B: B đăng ký là transient, nên đối tượng thực sự tạo lại
                // Dịch vụ A do là singleton, nên nó không tạo lại, mà đã tạo rồi, nó sẽ Inject vào dịch vụ B mới
                b = serviceprovider.GetService<B>();                  

                // Yêu  cầu  A, A đã tạo nên nó trả về đối dịch vụ mà đã Inject vào B
                A a = serviceprovider.GetService<A>();               

                // Yêu cầu dịch vụ C, C là loại scoped
                C c = serviceprovider.GetService<C>();  
                
                // Yêu cầu C, C không tạo mới vì scoped không đổi
                c = serviceprovider.GetService<C>();            

                // Tạo scope mới
                Console.WriteLine("-----------New scope---------");
                using (var scope = serviceprovider.CreateScope())  {
                    // Yêu  cầu  A, A đã tạo nên nó trả về đối dịch vụ mà đã Inject vào B, cho dù là scope mới
                    a = scope.ServiceProvider.GetService<A>(); 
                    // Yêu cầu C, C tạo mới vì scope mới (C kiểu scoped)
                    c = scope.ServiceProvider.GetService<C>();    
                } 

                serviceprovider.GetService<D>();
        }
    }
}
