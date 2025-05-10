using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public class CDConection
    {
        private SqlConnection db_conexion = new SqlConnection("Data Source=CASITA\\SQLEXPRESS;Initial Catalog=db_farmaciaPrograTest;Integrated Security=True;Encrypt=False");


        public SqlConnection MtdAbrirConexion()
        {
            if (db_conexion.State == ConnectionState.Closed)
            {
                db_conexion.Open();
            }
            return db_conexion;
        }

        public SqlConnection MtdCerrarConexion()
        {
            if (db_conexion.State == ConnectionState.Open)
            {
                db_conexion.Close();
            }
            return db_conexion;
        }
    }
}
