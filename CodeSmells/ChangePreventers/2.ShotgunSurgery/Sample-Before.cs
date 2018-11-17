using System.Data;
using System.Data.SqlClient;

namespace CodeSmells.ChangePreventers.ShotgunSurgery
{

    class Order
    {
        private string connectionString;

        internal SqlDataReader GetOrderata()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spSampleStoredProc";
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }

    class Invoice
    {

        private string ConnectionString;

        internal SqlDataReader GetInvoiceDate()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spSampleStoredProc";
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

    }
    
}
