using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    internal class CDHabitaciones
    {
        CDConexion cd_conexion = new CDConexion();

        public DataTable MtdConsultarHabitaciones()
        {
            string QueryConsultarHabitaciones = "Select * from tbl_Habitaciones";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarHabitaciones, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        
        public void MtdAgregarHabitaciones(string Numero, string Ubicacion, string Tipo, double Precio, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarHabitacion = "Insert into tbl_Habitaciones(Numero, Ubicacion, Tipo, Precio, Estado, UsuarioSistema, FechaSistema) values (@Numero, @Ubicacion, @Tipo, @Precio, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarHabitacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarHabitacion(int CodigoHabitacion, string Numero, string Ubicacion, string Tipo, double Precio, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarHabitacion = "Update tbl_Habitaciones set Numero=@Numero, Ubicacion=@Ubicacion, Tipo=@Tipo, Precio=@Precio, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryActualizarHabitacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@Numero", Numero);
            cmd.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarHabitacion(int CodigoHabitacion)
        {
            string QueryEliminarHabitacion = "Delete tbl_Habitaciones where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand cmd = new SqlCommand(QueryEliminarHabitacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("CodigoHabitacion", CodigoHabitacion);
            cmd.ExecuteNonQuery ();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
