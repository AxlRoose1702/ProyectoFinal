using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    internal class CDPagoPlanillas
    {
        CDConexion cd_conexion = new CDConexion();

        public DataTable MtdConsultarPP()
        {
            string QueryConsultarPP = "Select * from tbl_PagoPlanillas";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarPP, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarpp(int CodigoEmpleado, DateTime FechaPago, double Salario, double Bono, int HorasExtra, double MontoTotal, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarPP = "Insert into tbl_PagoPlanillas(CodigoEmpleado, FechaPago, Salario, Bono, HorasExtra, MontoTotal, Estado, UsuarioSistema, FechaSistema) values (@CodigoEmpleado, @FechaPago, @Salario, @Bono, @HorasExtra, @MontoTotal, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarPP, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.Parameters.AddWithValue("@Bono", Bono);
            cmd.Parameters.AddWithValue("@HorasExtra", HorasExtra);
            cmd.Parameters.AddWithValue("@MontoTotal", MontoTotal);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarPP(int CodigoPagoPlanilla, int CodigoEmpleado, DateTime FechaPago, double Salario, double Bono, int HorasExtra, double MontoTotal, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarUsuarios = "Update tbl_PagoPlanillas set CodigoEmpleado=@CodigoEmpleado, FechaPago=@FechaPago, Salario=@Salario, Bono=@Bono, HorasExtra=@HorasExtra, MontoTotal=@MontoTotal, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema  where CodigoPagoPlanilla=@CodigoPagoPlanilla";
            SqlCommand cmd = new SqlCommand(QueryActualizarUsuarios, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPagoPlanilla", CodigoPagoPlanilla);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.Parameters.AddWithValue("@Bono", Bono);
            cmd.Parameters.AddWithValue("@HorasExtra", HorasExtra);
            cmd.Parameters.AddWithValue("@MontoTotal", MontoTotal);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarPP(int CodigoPagoPlanilla)
        {
            string QueryEliminarPP = "Delete tbl_PagoPlanillas where CodigoPagoPlanilla=@CodigoPagoPlanilla";
            SqlCommand cmd = new SqlCommand(QueryEliminarPP, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPagoPlanilla", CodigoPagoPlanilla);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public double MtdSalario (int CodigoEmpleado)
        {
            double MontoSalario = 0;
            string QueryConsultarSalario = "Select Salario from tbl_Empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand CommandMontoSalario = new SqlCommand(QueryConsultarSalario, cd_conexion.MtdAbrirConexion());
            CommandMontoSalario.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            SqlDataReader reader = CommandMontoSalario.ExecuteReader();
            if (reader.Read())
            {
                MontoSalario = double.Parse(reader["Salario"].ToString());
            }
            else
            {
                MontoSalario = 0;
            }
            cd_conexion.MtdCerrarConexion();
            return MontoSalario;
        }

        public int MtdVerificarEmpleado(int CodigoEmpleado)
        {
            int Empleado = 0;
            string QueryVerificarEmpleado = "Select * from tbl_Empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryVerificarEmpleado, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Empleado = 1702;
            }
            else
            {
                Empleado = 0;
            }
            cd_conexion.MtdCerrarConexion();
            return Empleado;
        }

    }
}
