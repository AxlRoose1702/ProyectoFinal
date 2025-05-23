using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    internal class CDServicios
    {
        CDConexion cd_conexion = new CDConexion();

        public DataTable MtdConsultarServicios()
        {
            string QueryConsultarServicios = "Select * from tbl_Servicios";
            SqlDataAdapter Adapter = new SqlDataAdapter(QueryConsultarServicios, cd_conexion.MtdAbrirConexion());
            DataTable Dt = new DataTable();
            Adapter.Fill(Dt);
            cd_conexion.MtdCerrarConexion();
            return Dt;
        }

        public void MtdAgregarServicios(string Nombre, string Tipo, double Precio, DateTime FechaVigencia, DateTime FechaVencimiento, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryAgregarServicio = "Insert into tbl_Servicios(Nombre, Tipo, Precio, FechaVigencia, FechaVencimiento, Estado, UsuarioSistema, FechaSistema) values (@Nombre, @Tipo, @Precio, @FechaVigencia, @FechaVencimiento, @Estado, @UsuarioSistema, @FechaSistema)";
            SqlCommand cmd = new SqlCommand(QueryAgregarServicio, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@FechaVigencia", FechaVigencia);
            cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

        public void MtdActualizarServicios(int CodigoServicio, string Nombre, string Tipo, double Precio, DateTime FechaVigencia, DateTime FechaVencimiento, string Estado, string UsuarioSistema, DateTime FechaSistema)
        {
            string QueryActualizarServicio = "Update tbl_Servicios set Nombre=@Nombre, Tipo=@Tipo, Precio=@Precio, FechaVigencia=@FechaVigencia, FechaVencimiento=@FechaVencimiento, Estado=@Estado, UsuarioSistema=@UsuarioSistema, FechaSistema=@FechaSistema where CodigoServicio=@CodigoServicio";
            SqlCommand cmd = new SqlCommand(QueryActualizarServicio, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoServicio", CodigoServicio);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Tipo", Tipo);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@FechaVigencia", FechaVigencia);
            cmd.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioSistema", UsuarioSistema);
            cmd.Parameters.AddWithValue("FechaSistema", FechaSistema);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }
        public void MtdEliminarServicios(int CodigoServicio)
        {
            string QueryEliminarServicio = "Delete tbl_Servicios where CodigoServicio=@CodigoServicio";
            SqlCommand cmd = new SqlCommand(QueryEliminarServicio, cd_conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoServicio", CodigoServicio);
            cmd.ExecuteNonQuery();
            cd_conexion.MtdCerrarConexion();
        }

    }
}
