using System;
using System.Data.SqlClient;

namespace ProyectoFinal.Logica
{
    internal class CLConsumo
    {
        CDConexion cd_conexion = new CDConexion();
        public double MtdMontoConsumo(int CodigoServicio) 
        {
            double MontoServicio = 0;

            string QueryConsultarMontoServicio = "Select Precio from tbl_Servicios where CodigoServicio=@CodigoServicio";
            SqlCommand CommandMontoServicio = new SqlCommand(QueryConsultarMontoServicio, cd_conexion.MtdAbrirConexion());
            CommandMontoServicio.Parameters.AddWithValue("@CodigoServicio", CodigoServicio);
            SqlDataReader reader = CommandMontoServicio.ExecuteReader();

            if (reader.Read())
            {
                MontoServicio = double.Parse(reader["Precio"].ToString());
            }
            else
            {
                MontoServicio = 0;
            }

            cd_conexion.MtdCerrarConexion();

            return MontoServicio;
        }
    }
}
