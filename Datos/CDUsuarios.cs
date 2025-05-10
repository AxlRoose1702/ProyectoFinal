using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Datos
{
    internal class CDUsuarios
    {
        CDConection conn = new CDConection();

        public DataTable MtdConsultarUsuarios()
        {
            string QueryConsultar = "Select * from tbl_Usuarios";
            SqlDataAdapter SqlAdap = new SqlDataAdapter(QueryConsultar, conn.MtdAbrirConexion());
            DataTable TablaTemporal = new DataTable();
            SqlAdap.Fill(TablaTemporal);
            conn.MtdCerrarConexion();
            return TablaTemporal;
        }






    }
}
