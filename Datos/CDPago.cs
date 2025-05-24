using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    internal class CDPago
    {
        CDConexion cd_conexion = new CDConexion();

        public List<dynamic> MtdListaReservaciones()
        {
            List<dynamic> ListaReservaciones = new List<dynamic>();
            string QueryListaReservaciones = "SELECT tbl_Reservaciones.CodigoReserva, tbl_Reservaciones.Total, tbl_Huespedes.Nombre FROM tbl_Reservaciones, tbl_Huespedes WHERE tbl_Reservaciones.CodigoHuesped = tbl_Huespedes.CodigoHuesped\r\n";
            SqlCommand cmd = new SqlCommand(QueryListaReservaciones, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaReservaciones.Add(new
                {
                    Value = reader["CodigoReserva"],
                    Text = $"{reader["CodigoReserva"]} - {reader["Nombre"]}",
                });
            }
            cd_conexion.MtdCerrarConexion();
            return ListaReservaciones;
        }
        public DataTable MtdConsultarPagos()
        {
            string QueryConsultarPagos = "Select * from tbl_Pagos";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarPagos, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarPagos(int CodigoReserva, double Monto, double Propina, double Impuesto, double Descuento, double Total, string MetodoPago, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarPagos = "Insert into tbl_Pagos(CodigoReserva, Monto, Propina, Impuesto, Descuento, Total, MetodoPago, UsuarioSistema, FechaSistema) values (@CodigoReserva, @Monto, @Propina, @Impuesto, @Descuento, @Total, @MetodoPago, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarPagos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.Parameters.AddWithValue("@Monto", Monto);
            cmd.Parameters.AddWithValue("@Propina", Propina);
            cmd.Parameters.AddWithValue("@Impuesto", Impuesto);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@MetodoPago", MetodoPago);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarPagos(int CodigoPago, int CodigoReserva, double Monto, double Propina, double Impuesto, double Descuento, double Total, string MetodoPago, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarPagos = "Update tbl_Pagos set CodigoReserva=@CodigoReserva, Monto=@Monto, Propina=@Propina, Impuesto=@Impuesto, Descuento=@Descuento, Total=@Total, MetodoPago=@MetodoPago, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoPago=@CodigoPago";
            SqlCommand cmd = new SqlCommand(QueryActualizarPagos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPago", CodigoPago);
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            cmd.Parameters.AddWithValue("@Monto", Monto);
            cmd.Parameters.AddWithValue("@Propina", Propina);
            cmd.Parameters.AddWithValue("@Impuesto", Impuesto);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@MetodoPago", MetodoPago);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarPagos(int CodigoPago)
        {
            string QueryEliminarPagos = "Delete tbl_Pagos where CodigoPago=@CodigoPago";
            SqlCommand cmd = new SqlCommand(QueryEliminarPagos, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPagos", CodigoPago);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public double MtdMontoReserva(double CodigoReserva)
        {
            double MontoTotal = 0;
            string QueryConsultaMonto = "Select Total From tbl_Reservaciones where CodigoReserva = @CodigoReserva";
            SqlCommand cmd = new SqlCommand(QueryConsultaMonto, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MontoTotal = Convert.ToDouble(reader["Total"]);
            }

            reader.Close();
            cd_conexion.MtdCerrarConexion();

            return MontoTotal;
        }
    }
}
