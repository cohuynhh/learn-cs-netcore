
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Text;

public static class HtmlHelper
{
    public static string HtmlDocument(string title, string content) {
           return $@"
                    <!DOCTYPE html>
                    <html>
                        <head>
                            <meta charset=""UTF-8"">
                            <title>{title}</title>
                            <link rel=""stylesheet"" href=""/css/bootstrap.min.css"" />
                            <script src=""/js/jquery.min.js"">
                            </script><script src=""/js/popper.min.js"">
                            </script><script src=""/js/bootstrap.min.js""></script> 
                        </head>
                        <body>
                            {content}
                        </body>
                    </html>";
      } 

      public  static string MenuTop(object[] menus, HttpRequest request) {
          
          var menubuilder = new StringBuilder();
          menubuilder.Append("<ul class=\"navbar-nav\">");
          foreach (dynamic menu in menus) {
              string _class = "nav-item";
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
                        <nav class=""navbar navbar-expand-lg navbar-dark bg-primary"">
                            <a class=""navbar-brand"" href=""/"">Brand-Logo</a>
                            <button class=""navbar-toggler"" type=""button""
                                data-toggle=""collapse"" data-target=""#my-nav-bar""
                                aria-controls=""my-nav-bar"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                                <span class=""navbar-toggler-icon""></span>
                            </button>
                            <div class=""collapse navbar-collapse"" id=""my-nav-bar"">
                                {menubuilder}
                            </div>
                    </nav></div>";

          return  HtmlDocument("AA", menuhtml);
      }

      public static object[] MenuTopObjects() {
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

     public static string btsLi(this string content, string _class = "list-group-item") {
         return $"<li class=\"{_class}\">{content}</li>";
     }
     public static string btsLiLabel(this string label, string value, string _class = "list-group-item") {
         return $"<li class=\"{_class}\"><span class=\"text-danger\">{label}: </span> {value}</li>";
     }
     public static string btsUl(this string content) {
         return $"<ul class=\"list-group\">{content}</ul>";
     }

}