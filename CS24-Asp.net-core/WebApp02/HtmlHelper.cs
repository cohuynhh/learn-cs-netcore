public  static class HtmlHelper
{
    public static string HtmlDocument(string title, string content) {
           return $@"<!DOCTYPE html><html>
                    <head><meta charset=""UTF-8"">
                    <title>{title}</title>
                    <link rel=""stylesheet"" href=""/css/bootstrap.min.css"" />
                    <script src=""/js/jquery.min.js"">
                    </script><script src=""/js/popper.min.js"">
                    </script><script src=""/js/bootstrap.min.js""></script> 
                </head><body><div class=""container"">{content}</div></body></html>";
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