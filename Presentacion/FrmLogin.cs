﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user, password;

            user = txtUser.Text.Trim();
            password = txtPasswordUser.Text.Trim();

            //conn.Open();
            string QryConsultarUsuarios = "Select Usuario, Contrasena from tbl_usuarios where Usuario = @user";
            using (SqlCommand cmd = new SqlCommand(QryConsultarUsuarios))
            {
                cmd.Parameters.AddWithValue("@user", user);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string dbPasswordHash = reader["Contrasena"].ToString();
                        FrmMenuNavegacion nav = new FrmMenuNavegacion();
                        nav.Show();
                        MessageBox.Show("Sesion iniciada con exito!");

                    }
                    else
                    {
                        MessageBox.Show("Usuario no enontrado.");
                    }
                }

            }
            //conn.Close();
        }
    }
}
