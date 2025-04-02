using System;
using System.Collections.Generic;
//using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace HtmlScrape
{
    public class ConnectionClient
    {


        public static void SaveToDatabase(string data)
        {
            string connectionString = "Data Source=myDatabase.db";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = "CREATE TABLE IF NOT EXISTS Data (Id INTEGER PRIMARY KEY, Content TEXT)";
                var createTableCommand = new SqliteCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();

                string insertDataQuery = "INSERT INTO Data (Content) VALUES (@content)";
                var insertCommand = new SqliteCommand(insertDataQuery, connection);
                insertCommand.Parameters.AddWithValue("@content", data);
                insertCommand.ExecuteNonQuery();
            }
        }


    }
}
