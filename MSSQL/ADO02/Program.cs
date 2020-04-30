using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO02
{
    class Program
    {
        static void Main(string[] args)
        {
                string sqlconnectStr     = "Data Source=localhost,1433;Initial Catalog=xtlab;User ID=SA;Password=Password123";
                SqlConnection connection = new SqlConnection(sqlconnectStr);
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT CategoryID, CategoryName FROM Categories;", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    command.ExecuteReaderAsync()
                    if (reader.HasRows)
                    {
                        // Đọc kết quả
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}", reader[0].ToString(), reader.GetString(1));
                        }
                    }
                    else  Console.WriteLine("No rows found.");
                }

                SqlDataAdapter adapter  = new SqlDataAdapter();
                
                
                // adapter.Update()
                
                




        }
    }
}
