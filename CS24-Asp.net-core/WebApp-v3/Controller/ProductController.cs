    using WebApp.Services;
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using System.Text;
    using System.Linq;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using WebApp.Options;

namespace WebApp.Controller
    {
        public class ProductController
        {
            IListProductName lsPhone;
            IListProductName lsLaptop;
            TestOptions options;

            // Inject hai dịch vụ qua phương thức khởi tạo
            //Khởi tạo có Inject Option từ DI Container (chú ý tham số IOptions<TestOptions>)
            public ProductController(IListProductName lsphone, LaptopName lslaptop, IOptions<TestOptions> options) {
                this.lsPhone  = lsphone;
                this.lsLaptop = lslaptop;
                this.options  = options.Value;

            }

    
            // Xuất danh sách sản phẩm cho Response
            public async Task List(HttpContext context) {

                var sb = new StringBuilder();    
                CountAccess(context);


                string lsPhoneHTML  = string.Join("", lsPhone.GetNames().Select(name  => name.HtmlTag("li"))).HtmlTag("ul");
                string lsLaptopHTML = string.Join("", lsLaptop.GetNames().Select(name => name.HtmlTag("li"))).HtmlTag("ul");
                sb.Append($"{options.opt_key1}".HtmlTag("h2"));

                sb.Append(lsPhoneHTML);

                sb.Append($"{options.opt_key2.k1}".HtmlTag("h2"));

                sb.Append(lsLaptopHTML);

                string menu         = HtmlHelper.MenuTop(HtmlHelper.DefaultMenuTopItems(), context.Request);
                string html         = HtmlHelper.HtmlDocument("DS Sản phẩm", menu + sb.ToString().HtmlTag("div", "container"));

                context.Response.StatusCode = 200;
                await context.Response.WriteAsync(html);
            }

            public void CountAccess(HttpContext context) {
                // Lấy ISession
                var session       = context.Session;
                string key_access = "info_access";

                // Lưu vào  Session thông tin truy cập
                // Định nghĩa cấu trúc dữ liệu lưu trong Session
                var accessInfoType = new  {
                    count     = 0,
                    lasttime  = DateTime.Now
                };

                // Đọc chuỗi lưu trong Sessin với key = info_access
                string json = session.GetString(key_access);
                dynamic lastAccessInfo;
                if (json != null) { 
                    // Convert chuỗi Json - thành đối tượng có cấu trúc như accessInfoType
                    lastAccessInfo = JsonConvert.DeserializeObject(json, accessInfoType.GetType());

                }
                else { 
                    // json chưa từng lưu trong Session, accessInfo lấy bằng giá trị khởi  tạo
                    lastAccessInfo  = accessInfoType;
                }

                // Cập nhật thông tin
                var accessInfoSave = new {
                    count     = lastAccessInfo.count + 1,
                    lasttime  = DateTime.Now
                }; 

                // Convert accessInfo thành chuỗi Json và lưu lại vào Session
                string jsonSave = JsonConvert.SerializeObject(accessInfoSave);
                session.SetString(key_access, jsonSave);
                Console.WriteLine(jsonSave);
            }


                public static string CountAccessInfo(HttpContext context) {
                    var session       = context.Session;          // Lấy ISession
                    string key_access = "info_access";

                    // Lưu vào  Session thông tin truy cập
                    // Định nghĩa cấu trúc dữ liệu lưu trong Session
                    var accessInfoType = new  {
                        count     = 0,
                        lasttime  = DateTime.Now
                    };

                    // Đọc chuỗi lưu trong Sessin với key = info_access
                    string json = session.GetString(key_access);
                    dynamic lastAccessInfo;
                    if (json != null) {
                        // Convert chuỗi Json - thành đối tượng
                        lastAccessInfo = JsonConvert.DeserializeObject(json, accessInfoType.GetType());
                    }
                    else {
                        // json chưa từng lưu trong Session, accessInfo lấy bằng giá trị khởi  tạo
                        lastAccessInfo  = accessInfoType;
                    }
                    if (lastAccessInfo.count == 0) {
                        return "Chưa truy cập /Product lần  nào".HtmlTag("p");
                    }

                    string thongtin = $"Số lần truy cập /Product: {lastAccessInfo.count}  - lần cuối: {lastAccessInfo.lasttime.ToLongTimeString()}";
                    return thongtin;
                }



        }
    }
    
