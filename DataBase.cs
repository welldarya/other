using System.Data.SqlClient;
using System.Windows.Markup;

namespace TechnoServ
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection
            (@"Data Source = localhost; Initial Catalog = techno; Integrated Security = True");

        public void openConn() { sqlConnection.Open(); }
        public void closeConn() { sqlConnection.Close(); }

        public SqlConnection getConn() { return sqlConnection; }

    }
}
