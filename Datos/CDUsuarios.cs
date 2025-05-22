using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ProyectoFinal.Datos
{
    internal class CDUsuarios
    {

        CDConexion cd_conexion = new CDConexion();

        public DataTable MtdConsultarUsuarios()
        {
            string QueryConsultarUsuarios= "Select * from tbl_Usuarios";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarUsuarios, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarUsuarios(int CodigoEmpleado, string NombreUsuario, string Contrasenia, string Rol, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarUsuarios = "Insert into tbl_Usuarios(CodigoEmpleado, NombreUsuario, Contrasenia, Rol, Estado, UsuarioSistema, FechaSistema) values (@CodigoEmpleado, @NombreUsuario, @Contrasenia, @Rol, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarUsuarios, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            cmd.Parameters.AddWithValue("@Contrasenia", Contrasenia);
            cmd.Parameters.AddWithValue("@Rol", Rol);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarUsuarios(int CodigoUsuario, int CodigoEmpleado, string NombreUsuario, string Contrasenia, string Rol, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarUsuarios = "Update tbl_Usuarios set CodigoEmpleado=@CodigoEmpleado, NombreUsuario=@NombreUsuario, Contrasenia=@Contrasenia, Rol=@Rol, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoUsuario=@CodigoUsuario";
            SqlCommand cmd = new SqlCommand(QueryActualizarUsuarios, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            cmd.Parameters.AddWithValue("@Contrasenia", Contrasenia);
            cmd.Parameters.AddWithValue("@Rol", Rol);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("@FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdEliminarUsuarios(int CodigoUsuario)
        {
            string QueryEliminarUsuario = "Delete tbl_Usuarios where CodigoUsuario=@CodigoUsuario";
            SqlCommand cmd = new SqlCommand(QueryEliminarUsuario, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public List<dynamic> MtdListaEmpleados()
        {
            List<dynamic> ListaEmpleados = new List<dynamic>();
            string QueryListaEmpleados = "Select CodigoEmpleado, Nombre from tbl_Empleados";
            SqlCommand cmd = new SqlCommand(QueryListaEmpleados, cd_conexion.MtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaEmpleados.Add(new
                {
                    Value = reader["CodigoEmpleado"],
                    Text = $"{reader["CodigoEmpleado"]} - {reader["Nombre"]}"
                });
            }
            cd_conexion.MtdCerrarConexion();
            return ListaEmpleados;
        }

        public int MtdVerificarUsuario(string NombreUsuario)
        {
            int Usuario = 0;
            string QueryVerificarUsuario = "Select * from tbl_Usuarios where NombreUsuario=@NombreUsuario";
            SqlCommand cmd = new SqlCommand(QueryVerificarUsuario, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Usuario = 1702;
            }
            else
            {
                Usuario = 0;
            }
            cd_conexion.MtdCerrarConexion();
            return Usuario; 
        }
        public int MtdVerificarEmpleado(int CodigoEmpleado)
        {
            int Empleado = 0;
            string QueryVerificarEmpleado = "Select * from tbl_Usuarios where CodigoEmpleado=@CodigoEmpleado";
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
