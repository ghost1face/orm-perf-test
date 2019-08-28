using Insight.Database;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace PerfTest
{
    public class InsightRepo
    {
        public User GetSingleUser()
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=SSPI;"))
            {
                return connection.SingleSql<User>("SELECT TOP 1 * FROM dbo.Users");
            }
        }

        public IList<User> GetUsers()
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=SSPI;"))
            {
                return connection.QuerySql<User>("SELECT TOP 500 * FROM dbo.Users").ToList();
            }
        }
    }
}
