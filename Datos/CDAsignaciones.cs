using System.Collections.Generic;

namespace ProyectoFinal.Datos
{
    internal class CDAsignaciones
    {
        CDConexion cd_conexion = new CDConexion();

        public DataTable MtdConsultarAsignacion()
        {
            string QueryConsultarAsignacion = "Select * from tbl_Asignaciones";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarAsignacion, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarAsignacion(int CodigoEmpleado, int CodigoHabitacion, string TipoAsignacion, DateTime FechaAsignacion, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarAsignacion = "Insert into tbl_Asignaciones(CodigoEmpleado, CodigoHabitacion, TipoAsignacion, FechaAsignacion, Estado, UsuarioSistema, FechaSistema) values (@CodigoEmpleado, @CodigoHabitacion, @TipoAsignacion, @FechaAsignacion, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarAsignacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@TipoAsignacion", TipoAsignacion);
            cmd.Parameters.AddWithValue("@FechaAsignacion", FechaAsignacion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarAsignacion(int CodigoAsignacion, int CodigoEmpleado, int CodigoHabitacion, string TipoAsignacion, DateTime FechaAsignacion, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarAsignacion = "Update tbl_Asignaciones set CodigoEmpleado=@CodigoEmpleado, CodigoHabitacion=@CodigoHabitacion, TipoAsignacion=@TipoAsignacion, FechaAsignacion=@FechaAsignacion, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoAsignacion=@CodigoAsignacion";
            SqlCommand cmd = new SqlCommand(QueryActualizarAsignacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoAsignacion", CodigoAsignacion);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@TipoAsignacion", TipoAsignacion);
            cmd.Parameters.AddWithValue("@FechaAsignacion", FechaAsignacion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarAsignacion(int CodigoAsignacion)
        {
            string QueryEliminarAsignacion = "Delete tbl_Asignaciones where CodigoAsignacion=@CodigoAsignacion";
            SqlCommand cmd = new SqlCommand(QueryEliminarAsignacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoAsignacion", CodigoAsignacion);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public List<dynamic> MtdListaHabitaciones()
        {
            List<dynamic> ListaHabitacion = new List<dynamic>();
            string QueryListaHabitacion = "Select CodigoHabitacion from tbl_Habitaciones";
            SqlCommand cmd = new SqlCommand(QueryListaHabitacion, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaHabitacion.Add(new
                {
                    Value = reader["CodigoHabitacion"],
                    Text = $"{reader["CodigoHabitacion"]}"
                });
            }
            cd_conexion.MtdCerrarConexion();
            return ListaHabitacion;
        }

        public List<dynamic> MtdListaEmpleados()
        {
            List<dynamic> ListaEmpleados = new List<dynamic>();
            string QueryListaEmpleados = "Select CodigoEmpleado from tbl_Empleados";
            SqlCommand cmd = new SqlCommand(QueryListaEmpleados, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaEmpleados.Add(new
                {
                    Value = reader["CodigoEmpleado"],
                    Text = $"{reader["CodigoEmpleado"]}"
                });
            }
            cd_conexion.MtdCerrarConexion();
            return ListaEmpleados;
        }
    }
}
