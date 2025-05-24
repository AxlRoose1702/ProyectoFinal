using System.Data.SqlClient;

namespace ProyectoFinal.Logica
{
    internal class CLReservaciones
    {
        CDConexion cd_conexion = new CDConexion();
        public double MtdTotalReservaciones(int CodigoHabitaciones)
        {
            double TotalReservacion = 0;

            string QueryConsultarTotalReservaciones = "Select Precio from tbl_Habitaciones where CodigoHabitacion=@CodigoHabitacion";
            SqlCommand CommandMontoServicio = new SqlCommand(QueryConsultarTotalReservaciones, cd_conexion.MtdAbrirConexion());
            CommandMontoServicio.Parameters.AddWithValue("@CodigoHabitacion", CodigoHabitaciones);
            SqlDataReader reader = CommandMontoServicio.ExecuteReader();

            if (reader.Read())
            {
                TotalReservacion = double.Parse(reader["Precio"].ToString());
            }
            else
            {
                TotalReservacion = 0;
            }

            cd_conexion.MtdCerrarConexion();

            return TotalReservacion;
        }
    }
}
