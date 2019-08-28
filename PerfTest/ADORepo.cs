using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PerfTest
{
    class ADORepo
    {
        public User GetSingleUser()
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=SSPI;"))
            using (var command = connection.CreateCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT TOP 1 * FROM dbo.Users";

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new User
                        {
                            email = reader["email"].ToString(),
                            first_name = reader["first_name"].ToString(),
                            gender = reader["gender"].ToString(),
                            id = Convert.ToInt32(reader["id"]),
                            ip_address = reader["ip_address"].ToString(),
                            job_title = reader["job_title"].ToString(),
                            last_name = reader["last_name"].ToString()
                        };
                    }
                }
            }

            return null;
        }

        public IList<User> GetUsers()
        {
            var users = new List<User>();
            using (var connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=SSPI;"))
            using (var command = connection.CreateCommand())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT TOP 500 * FROM dbo.Users";

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            email = reader["email"].ToString(),
                            first_name = reader["first_name"].ToString(),
                            gender = reader["gender"].ToString(),
                            id = Convert.ToInt32(reader["id"]),
                            ip_address = reader["ip_address"].ToString(),
                            job_title = reader["job_title"].ToString(),
                            last_name = reader["last_name"].ToString()
                        });
                    }
                }
            }
            return users;
        }
    }
}
