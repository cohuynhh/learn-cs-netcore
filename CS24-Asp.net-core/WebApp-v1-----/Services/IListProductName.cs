using System.Collections.Generic;

namespace WebApp.Services
{
    public interface IListProductName
    {
         // Trả về danh sách các tên
         IEnumerable<string> GetNames();
    }
}