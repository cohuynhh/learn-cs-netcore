using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

namespace ADO01
{
    class Program
    {
        public static string GetConnectString() {
            var configBuilder = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())      // file config ở thư mục hiện tại
                       .AddJsonFile("appconfig.json");                    // nạp config định dạng JSON
            var configurationroot = configBuilder.Build();                // Tạo configurationroot
            return configurationroot["csdl:ketnoi2"];

        }
        static void Main(string[] args)
        {
 
            SqlConnection connection = new SqlConnection(GetConnectString());
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
 
            Console.WriteLine($"{"ConnectionString", 17} : {GetConnectString()}");
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
