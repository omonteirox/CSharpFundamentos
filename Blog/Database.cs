
using Microsoft.Data.SqlClient;

namespace Blog
{
    public class Database
    {
        public static SqlConnection Connection = new SqlConnection("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
    }
}