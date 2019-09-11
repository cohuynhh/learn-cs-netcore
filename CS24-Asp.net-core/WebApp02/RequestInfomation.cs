using System.Text;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace WebApp02
{
    public static class RequestInfomation
    {
         
        public static string Infopage(HttpRequest request) {
            var sb = new StringBuilder(); 
            sb.Append("scheme".btsLiLabel(request.Scheme));
            sb.Append("host".btsLiLabel(request.Host.HasValue ? request.Host.Value : "no host"));
            sb.Append("path".btsLiLabel(request.Path));
            sb.Append("query string".btsLiLabel(request.QueryString.HasValue ? request.QueryString.Value : "no query string")); 
            sb.Append("method".btsLiLabel(request.Method)); 
            sb.Append("protocol".btsLiLabel(request.Protocol)); 
            sb.Append("ContentType".btsLiLabel(request.ContentType)); 
            sb.Append("Headers".btsLiLabel(string.Join("<br/>",request.Headers.Select((header) => $"{header.Key}: {header.Value}")))); 
            sb.Append("Cookies".btsLiLabel(string.Join("<br/>",request.Cookies.Select((header) => $"{header.Key}: {header.Value}")))); 
            sb.Append("Query".btsLiLabel(string.Join("<br/>",  request.Query.Select((header) => $"{header.Key}: {header.Value}")))); 

            string info =  "<h2 class=\"display-4\">Thông tin Request</h2>" + sb.ToString().btsUl();

            return HtmlHelper.HtmlDocument("Thông tin Request",info);
        }
    }
}