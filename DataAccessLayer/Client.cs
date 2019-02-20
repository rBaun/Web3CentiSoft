using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Client
    {
        private static readonly IConfiguration configuration;
        private static string connectionString = configuration.GetConnectionString("DefaultConnectionString");
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Token { get; set; }
        public static List<Customer> Customers { get; set; }

        public static void SaveClient()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "Insert into Client(Name, Token) values(@Name, @Token)";
                    cmd.Parameters.AddWithValue("Name", Name);
                    cmd.Parameters.AddWithValue("LastName", Token);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void GetClient(int id)
        {
            Client client = new Client();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT id, name, token FROM client WHERE id=@id";
                    cmd.Parameters.AddWithValue("id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id"));
                        Name = reader.GetString(reader.GetOrdinal("name"));
                        Token = reader.GetString(reader.GetOrdinal("token"));
                    }
                    reader.Close();
                }
            }
        }

        public static void GetAllClients()
        {
            
        }

        public static void UpdateClient()
        {

        }

        public static void DeleteClient()
        {

        }
    }
}
