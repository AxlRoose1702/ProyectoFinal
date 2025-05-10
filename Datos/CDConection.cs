using System.Data.SqlClient;

namespace ProyectoFinal
{
    public class CDConection
    {
        //Agregar su propia conexion a la base de datos
       // private SqlConnection conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=ProyectoFinal;Integrated Security=True;Trust Server Certificate=True");
        private SqlConnection conn2 = new SqlConnection("Data Source=CASITA\\SQLEXPRESS;Initial Catalog=ProyectoFinal;Integrated Security=True;Trust Server Certificate=True");


        //Crear metodos para la apertura y cierre de la conexion a la base de datos.
    }
}
