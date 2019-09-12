
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Text;

public static class HtmlHelper
{
    /// <summary>
    /// Phát sinh trang HTML
    /// </summary>
    /// <param name="title">Tiêu đề trang</param>
    /// <param name="content">Nội dung trong thẻ body</param>
    /// <returns>Trang HTML</returns>
    public static string HtmlDocument(string title, string content) {
           return $@"
                    <!DOCTYPE html>
                    <html>
                        <head>
                            <meta charset=""UTF-8"">
                            <title>{title}</title>
                            <link rel=""stylesheet"" href=""/css/site.min.css"" />
                            <script src=""/js/jquery.min.js"">
                            </script><script src=""/js/popper.min.js"">
                            </script><script src=""/js/bootstrap.min.js""></script> 
                        </head>
                        <body>
                            {content}
                        </body>
                    </html>";
      } 

    /// <summary>
    /// Phát sinh HTML thanh menu trên, menu nào  active phụ thuộc vào URL mà request gủi đén
    /// </summary>
    /// <param name="menus">Mảng các menu item, mỗi item có cấu trúc {url, lable}</param>
    /// <param name="request">HttpRequest</param>
    /// <returns></returns>

      public  static string MenuTop(object[] menus, HttpRequest request) {
          
          var menubuilder = new StringBuilder();
          menubuilder.Append("<ul class=\"navbar-nav\">");
          foreach (dynamic menu in menus) {
              string _class = "nav-item";
              // Active khi request.PathBase giống url của menu
              if (request.PathBase  == menu.url)  _class += " active"; 
              menubuilder.Append($@"
                                <li class=""{_class}"">
                                    <a class=""nav-link"" href=""{menu.url}"">{menu.label}</a>
                                </li>
                                ");
          }

          menubuilder.Append("</ul>\n");

          string menuhtml = $@"
                    <div class=""container"">
                        <nav class=""navbar navbar-expand-lg navbar-dark mainbackground"">
                            <a class=""navbar-brand"" href=""/"">XTLAB</a>
                            <button class=""navbar-toggler"" type=""button""
                                data-toggle=""collapse"" data-target=""#my-nav-bar""
                                aria-controls=""my-nav-bar"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                                <span class=""navbar-toggler-icon""></span>
                            </button>
                            <div class=""collapse navbar-collapse"" id=""my-nav-bar"">
                                {menubuilder}
                            </div>
                    </nav></div>";

          return  menuhtml;
      }
      
      /// <summary>
      /// Những menu item mặc định cho trang
      /// </summary>
      /// <returns>Mảng các menuitem</returns>
      public static object[] DefaultMenuTopItems() {
          return new object[] {
              new {
                  url = "/RequestInfo",
                  label = "Request"
              },
              new {
                  url = "/Form",
                  label = "Form"
              }
          };
      }

      public static string HtmlTrangchu() {
         return $@"
          <div class=""container"">
            <div class=""jumbotron"">
                <h1 class=""display-4"">Đây là một trang Web .NET Core</h1>
                <p class=""lead"">Trang Web này xây dựng trên nền tảng  <code>.NET Core</code>,
                chưa sử dụng kỹ thuật MVC - nhằm mục đích học tập.
                
                </p>


                <hr class=""my-4"">
                <p>Để <code>Jumbotron</code> trong <code>Bootstrap</code> ấn tượng có thể sử 
                dụng các lớp trình bày kích thước lớn như 
                <code>.display-2</code> <code>.btn-lg</code> <code>...</code></p>
                <a class=""btn btn-danger btn-lg"" href=""#"" role=""button"">Xem thêm</a>
            </div>
        </div>
         ";

      }
}