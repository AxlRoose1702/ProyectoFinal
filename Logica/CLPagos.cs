using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Logica
{
    internal class CLPagos
    {
        CDConexion cd_conexion = new CDConexion();
        public double MtdMontoConsumo(int CodigoReserva)
        {
            double MontoPago = 0;

            string QueryConsultarMontoPago = "Select Total from tbl_Reservaciones where CodigoReserva=@CodigoReserva";
            SqlCommand CommandMontoServicio = new SqlCommand(QueryConsultarMontoPago, cd_conexion.MtdAbrirConexion());
            CommandMontoServicio.Parameters.AddWithValue("@CodigoReserva", CodigoReserva);
            SqlDataReader reader = CommandMontoServicio.ExecuteReader();

            if (reader.Read())
            {
                MontoPago = double.Parse(reader["Total"].ToString());
            }
            else
            {
                MontoPago = 0;
            }

            cd_conexion.MtdCerrarConexion();

            return MontoPago;
        }
        public double MtdPropinaPago (double Monto)
        {
            return (Monto * 0.10);
        }
        public double MtdImpuestoPago (double Monto){
            return (Monto * 0.12);
        }
        public double MtdDescuentoPago(double Monto)
        {
            if (Monto > 0 && Monto <= 500) { return (Monto * 0.03); }
            else if (Monto > 500 && Monto <= 5000) { return (Monto * 0.005); }
            else if (Monto > 5000) { return (Monto * 0.07); }
            else { return 0; }
        }
        public double MtdTotalPago (double Monto, double Propina, double Impuesto, double Descuento)
        {
            return (Monto+Propina+Impuesto-Descuento);
        }
    }
}
