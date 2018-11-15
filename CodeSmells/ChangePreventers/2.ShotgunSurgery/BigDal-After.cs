using System.Data;
using System.Data.SqlClient;


namespace CodeSmells.ChangePreventers.ShotgunSurgery
{
    internal class BigDal2
    {
        private string ConnectionString = null;

        private SqlCommand PrepareCommand(string storedProcedureName)
        {
            
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storedProcedureName;
            return cmd;
        }

        internal SqlDataReader GetData()
        {
            SqlCommand cmd = PrepareCommand("spSampleStoredProc");
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

    }
}
