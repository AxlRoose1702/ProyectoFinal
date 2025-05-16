using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoFinal.Datos
{
    internal class CDEmpleados
    {
        CDConexion cd_conexion = new CDConexion();

        public DataTable MtdConsultarEmpleados()
        {
            string QueryConsultarEmpleados = "Select * from tbl_Empleados";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarEmpleados, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarEmpleados(string Nombre, string Cargo, double Salario, DateTime FechaContratacion, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarEmpleados = "Insert into tbl_Empleados(Nombre,Cargo,Salario, FechaContratacion, Estado, UsuarioSistema, FechaSistema) values (@Nombre,@Cargo,Salario, @FechaContratacion, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarEmpleados, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarEmpleados(int CodigoEmpleado, string Nombre, string Cargo, double Salario, DateTime FechaContratacion, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarEmpleados = "Update tbl_Empleados set Nombre=@Nombre, Cargo=@Cargo, Salario=@Salario, Stock=@Stock, FechaContratacion=@FechaContratacion, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryActualizarEmpleados, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@Salario", Salario);
            cmd.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarDEmpleados(int CodigoEmpleado)
        {
            string QueryEliminarEmpleado = "Delete tbl_Empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryEliminarEmpleado, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }


    }
}
