using System;
using System.Data;
using System.Data.SqlClient;


namespace ADO01
{
    class Program
    {
        public static void ConnectSqlserverExample() {
            string sqlconnectStr      = "Data Source=localhost,1433;Initial Catalog=xtlab;User ID=SA;Password=Password123"; 
            SqlConnection connection  = new SqlConnection(sqlconnectStr);
            connection.Open(); //  Mở kết nối - hoặc  connection.OpenAsync(); nếu dùng async
            // thực hiện cá tác  vụ truy vấn CSDL
            connection.Close(); //Đóng kết nối

        }
        static void Main(string[] args)
        {

            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder["Server"] = "127.0.0.1,1433";
            stringBuilder["Database"] = "xtlab";
            stringBuilder["User Id"] = "SA";
            stringBuilder["Password"] = "Password123";


            SqlConnection connection = new SqlConnection(stringBuilder.ToString());
            connection.StatisticsEnabled = true;
            connection.FireInfoMessageEventOnUserErrors = true;

            connection.StateChange += (object  sender, StateChangeEventArgs e) => {
                    Console.WriteLine($"Trạng thái hiện tại: {e.CurrentState}, trạng thái trước: " + $"{e.OriginalState}");
            }; 

            connection.Open();
            
            // Dùng SqlCommand thi hành SQL  - sẽ  tìm hiểu sau
            using (SqlCommand command = connection.CreateCommand()) {
                command.CommandText = "select top(5) * from Products";
                var reader = command.ExecuteReader();
                Console.WriteLine("CÁC SẢN PHẨM:");
                Console.WriteLine($"{"ProductID", 10} {"ProductName"}");
                while (reader.Read()) {
                    Console.WriteLine($"{reader["ProductID"], 10} {reader["ProductName"]}");
                }
            }
 
            Console.WriteLine($"{"ConnectionString", 17} : {stringBuilder}");
            Console.WriteLine($"{"DataSource", 17} : {connection.DataSource}");



            var dicStatics = connection.RetrieveStatistics();

            
            foreach (var key in dicStatics.Keys)
            {
                Console.WriteLine($"{key, 17} : {dicStatics[key]}");
            } 
        
            connection.Close();

            


        }
    }
}
