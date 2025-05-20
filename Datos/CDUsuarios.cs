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

        public void MtdActualizarUsuarios(int CodigoEmpleado, string NombreUsuario, string Contrasenia, string Rol, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarUsuarios = "Update tbl_Usuarios set CodigoEmpleado=@CodigoEmpleado, NombreUsuario=@NombreUsuario, Contrasenia=@Contrasenia, Rol=@Rol, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoEmpleado=@CodigoEmpleado";
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


    }
}
