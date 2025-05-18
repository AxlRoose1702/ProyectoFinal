using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaPresentacion.Seguridad
{
    public class UserDao : UserConnectionToSql
    {
        public bool Login(string NombreUsuario, string Contrasenia)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from tbl_Usuarios where NombreUsuario=@NombreUsuario and Contrasenia=@Contrasenia";
                    command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                    command.Parameters.AddWithValue("@Contrasenia", Contrasenia);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.CodigoUsuario = reader.GetInt32(0);
                            UserCache.CodigoEmpleado = reader.GetInt32(1);
                            UserCache.NombreUsuario = reader.GetString(2);
                            UserCache.Contrasenia = reader.GetString(3);
                            UserCache.Rol = reader.GetString(4);
                            UserCache.Estado = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

    }
}
