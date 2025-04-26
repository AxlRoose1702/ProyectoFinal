using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        private SqlConnection conn;

        public Login()
        {
            InitializeComponent();
            //conn = new SqlConnection("Data Source=LAPTOP-JC6HE824;Initial Catalog=Db_farmacia;Integrated Security=True;");
            //conn = new SqlConnection("Data Source=CASITA\SQLEXPRESS;Initial Catalog=db_farmacia;Integrated Security=True;");

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user, password;

            user = txtUser.Text.Trim();
            password = txtPasswordUser.Text.Trim();

            conn.Open();
            string QryConsultarUsuarios = "Select Usuario, Contrasena from tbl_usuarios where Usuario = @user";
            using (SqlCommand cmd = new SqlCommand(QryConsultarUsuarios, conn))
            {
                cmd.Parameters.AddWithValue("@user", user);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string dbPasswordHash = reader["Contrasena"].ToString();
                        MenuNavegacion nav = new MenuNavegacion();
                        nav.Show();
                        MessageBox.Show("Sesion iniciada con exito!");

                    }
                    else
                    {
                        MessageBox.Show("Usuario no enontrado.");
                    }
                }

            }
            conn.Close();
        }
    }
}
