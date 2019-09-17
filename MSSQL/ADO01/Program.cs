using System;
using System.Data;
using System.Data.SqlClient;


namespace ADO01
{
    class Program
    {
        static void Main(string[] args)
        {
            //dotnet add package System.Data.SqlClient --version 4.6.1

            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder["Server"] = "localhost,1433";
            stringBuilder["Database"] = "xtlab";
            stringBuilder["User Id"] = "SA";
            stringBuilder["Password"] = "Password123";

            string sqlConnectStr = stringBuilder.ToString();
            SqlConnection connection = new SqlConnection(sqlConnectStr);
            connection.StatisticsEnabled = true;
            connection.FireInfoMessageEventOnUserErrors = true;

            connection.StateChange += (object  sender, StateChangeEventArgs e) => {
                    Console.WriteLine($"current state: {e.CurrentState}, before: " + $"{e.OriginalState}");
            };
            connection.InfoMessage += (object sender, SqlInfoMessageEventArgs e) => {
                Console.WriteLine($"warning or info {e.Message}");

            };


            connection.Open();
            

            var dicStatics = connection.RetrieveStatistics();
            foreach (var key in dicStatics.Keys)
            {
                Console.WriteLine($"{key, 17} : {dicStatics[key]}");
            }

            connection.Close();

        }
    }
}
