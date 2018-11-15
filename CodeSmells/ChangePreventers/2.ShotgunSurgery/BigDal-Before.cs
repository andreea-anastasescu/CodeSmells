using System.Data;
using System.Data.SqlClient;

namespace CodeSmells.ChangePreventers.ShotgunSurgery
{
    internal class BigDal
    {
        private string ConnectionString;

        internal SqlDataReader GetData()
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
