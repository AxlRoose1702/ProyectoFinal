using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;

namespace ProyectoFinal.Datos
{
    internal class CDConsumos
    {
        CDConexion cd_conexion = new CDConexion();
        public DataTable MtdConsultarConsumos()
        {
            string QueryConsultarConsumos = "Select * from tbl_Consumos";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarConsumos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarConsumos(int CodigoReserva, int CodigoServicio, double Monto, DateTime FechaConsumo, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarServicio = "Insert into tbl_Consumos(CodigoReserva, CodigoServicio, Monto, FechaConsumo, Estado, UsuarioSistema, FechaSistema) values (@CodigoReserva, @CodigoServicio, @Monto, @FechaConsumo, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarServicio, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.Parameters.AddWithValue("@CodigoServicio", CodigoServicio);
            cmd.Parameters.AddWithValue("@Monto", Monto);
            cmd.Parameters.AddWithValue("@FechaConsumo", FechaConsumo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarConsumos(int CodigoConsumo, int CodigoReserva, int CodigoServicio, double Monto, DateTime FechaConsumo, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarServicio = "Update tbl_Consumos set CodigoReserva=@CodigoReserva, CodigoServicio=@CodigoServicio, Monto=@Monto, FechaConsumo=@FechaConsumo, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoConsumo=@CodigoConsumo";
            SqlCommand cmd = new SqlCommand(QueryActualizarServicio, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoConsumo", CodigoConsumo);
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.Parameters.AddWithValue("@CodigoServicio", CodigoServicio);
            cmd.Parameters.AddWithValue("@Monto", Monto);
            cmd.Parameters.AddWithValue("@FechaConsumo", FechaConsumo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarConsumos(int CodigoConsumo)
        {
            string QueryEliminarConsumos = "Delete tbl_Consumos where CodigoConsumo=@CodigoConsumo";
            SqlCommand cmd = new SqlCommand(QueryEliminarConsumos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoConsumo", CodigoConsumo);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public List<dynamic> MtdListReservacion()
        {
            List<dynamic> ListaReservacion = new List<dynamic>();
            string QueryListaReservacion = "Select CodigoReserva from tbl_Reservaciones";
            SqlCommand cmd = new SqlCommand(QueryListaReservacion, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaReservacion.Add(new
                {
                    Value = reader["CodigoReserva"],
                    Text = $"{reader["CodigoReserva"]}"
                });
            }
            cd_conexion.MtdCerrarConexion();
            return ListaReservacion;
        }
        public List<dynamic> MtdListServicios()
        {
            List<dynamic> ListaServicios = new List<dynamic>();
            string QueryListaServicios = "Select CodigoServicio from tbl_Servicios";
            SqlCommand cmd = new SqlCommand(QueryListaServicios, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaServicios.Add(new
                {
                    Value = reader["CodigoServicio"],
                    Text = $"{reader["CodigoServicio"]}"
                });
            }
            cd_conexion.MtdCerrarConexion();
            return ListaServicios;
        }
    }
}
