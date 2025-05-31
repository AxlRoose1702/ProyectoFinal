using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;

namespace ProyectoFinal.Datos
{
    internal class CDReservaciones
    {
        CDConexion cd_conexion = new CDConexion();

        public DataTable MtdConsultarReservaciones()
        {
            string QueryConsultarServicios = "Select * from tbl_Reservaciones";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarServicios, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }
        public void MtdAgregarReservaciones(int CodigoHuesped, int CodigoHabitacion, DateTime FechaEntrada, DateTime FechaSalida, double Total, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarAsignacion = "Insert into tbl_Reservaciones(CodigoHuesped, CodigoHabitacion, FechaEntrada, FechaSalida, Total, UsuarioSistema, FechaSistema) values (@CodigoHuesped, @CodigoHabitacion, @FechaEntrada, @FechaSalida, @Total, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarAsignacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHuesped", CodigoHuesped);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@FechaEntrada", FechaEntrada);
            cmd.Parameters.AddWithValue("@FechaSalida", FechaSalida);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdActualizarReserva(int CodigoReserva, int CodigoHuesped, int CodigoHabitacion, DateTime FechaEntrada, DateTime FechaSalida, double Total, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarAsignacion = "Update tbl_Reservaciones set CodigoHuesped=@CodigoHuesped, CodigoHabitacion=@CodigoHabitacion, FechaEntrada=@FechaEntrada, FechaSalida=@FechaSalida, Total=@Total, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoReserva=@CodigoReserva";
            SqlCommand cmd = new SqlCommand(QueryActualizarAsignacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.Parameters.AddWithValue("@CodigoHuesped", CodigoHuesped);
            cmd.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitacion);
            cmd.Parameters.AddWithValue("@FechaEntrada", FechaEntrada);
            cmd.Parameters.AddWithValue("@FechaSalida", FechaSalida);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarReservacion(int CodigoReserva)
        {
            string QueryEliminarReservacion = "Delete tbl_Reservaciones where CodigoReserva=@CodigoReserva";
            SqlCommand cmd = new SqlCommand(QueryEliminarReservacion, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public List<dynamic> MtdListaHuesped()
        {
            List<dynamic> ListaHuespedes = new List<dynamic>();
            string QueryListaHuespedes = "Select CodigoHuesped from tbl_Huespedes";
            SqlCommand cmd = new SqlCommand(QueryListaHuespedes, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaHuespedes.Add(new
                {
                    Value = reader["CodigoHuesped"],
                    Text = $"{reader["CodigoHuesped"]}"
                });
            }
            cd_conexion.MtdCerrarConexion();
            return ListaHuespedes;
        }
        public List<dynamic> MtdListaHabitacion()
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
    }
}
