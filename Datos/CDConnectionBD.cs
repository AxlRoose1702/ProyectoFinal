using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public class CDConnectionBD
    {
        private string _connectionString;

        public CDConnectionBD(string connectionString)
        {
            _connectionString = connectionString;
        }

        //Metodo para obtener datos de la DB en un datatable
        public DataTable GetData(string query)
        {
            //Creacion de la tabla
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) //adaptador que llena el datatable
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
