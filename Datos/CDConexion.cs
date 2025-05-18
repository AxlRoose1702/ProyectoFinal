using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public class CDConexion
    {
        //Agregar su propia conexion a la base de datos
        //private SqlConnection conn = new SqlConnection("Data Source=CASITA\\SQLEXPRESS;Initial Catalog=db_hotel;Integrated Security=True;Encrypt=False");
        private SqlConnection conn = new SqlConnection("Data Source=PAUL\\SQLEXPRESS;Initial Catalog=db_hotel;Integrated Security=True;Encrypt=False");
        //private SqlConnection conn = new SqlConnection("Data Source=MODIFICAR AQUI MOSQUITO;Initial Catalog=db_hotel;Integrated Security=True;Encrypt=False");


        public SqlConnection MtdAbrirConexion()
        {
            //Verificar si la conexion esta cerrada y abrirla
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public SqlConnection MtdCerrarConexion()
        {
            //Verificar si la conexion esta abierta y cerrarla
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
    
        //Crear metodos para la apertura y cierre de la conexion a la base de datos.

    }
}
