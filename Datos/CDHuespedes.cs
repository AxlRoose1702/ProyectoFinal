using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    internal class CDHuespedes
    {
        CDConexion cd_conexion = new CDConexion();

        public DataTable MtdConsultarHuespedes()
        {
            string QueryConsultarHuespedes = "Select * from tbl_Huespedes";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarHuespedes, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarHuespedes(string Nombre, string NIT, string Telefono, string Tipo, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarHuespedes = "Insert into tbl_Huespedes(Nombre, NIT, Telefono, Tipo, Estado, UsuarioSistema, FechaSistema) values (@Nombre, @NIT, @Telefono, @Tipo, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarHuespedes, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@NIT", NIT);
            cmd.Parameters.AddWithValue(@"Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarHuespedes(int CodigoHuesped, string Nombre, string NIT, string Telefono, string Tipo, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarHuespedes = "Update tbl_Huespedes set Nombre=@Nombre, NIT=@NIT, Telefono=@Telefono, Tipo=@Tipo, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoHuesped=@CodigoHuesped";
            SqlCommand cmd = new SqlCommand(QueryActualizarHuespedes, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHuesped", CodigoHuesped);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@NIT", NIT);
            cmd.Parameters.AddWithValue(@"Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarHuespedes(int CodigoHuesped)
        {
            string QueryEliminarHuespedes = "Delete tbl_Huespedes where CodigoHuesped=@CodigoHuesped";
            SqlCommand cmd = new SqlCommand(QueryEliminarHuespedes, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoHuesped", CodigoHuesped);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
    }
}
