using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Usuarios : Form
    {
        Procesos proces = new Procesos();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaracion de todas las variables con todos los objetos del form
                int codigoUsuario, codigoEmpleado;
                string nombre, contrasena, rol, estado, usuarioSistema, fechaS;

                codigoUsuario = int.Parse(txtCodigoUsuario.Text);
                codigoEmpleado = int.Parse(lblCodigoEmpleado.Text);
                nombre = txtNombreUsuario.Text;
                contrasena = txtPassword.Text;
                rol = cboxRol.Text;
                estado = cboxEstado.Text;
                usuarioSistema = txtUsuarioSistema.Text;
                fechaS = dateFechaSistema.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MenuNavegacion nav = new MenuNavegacion();
            nav.Show();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            string conn = "Data Source=LAPTOP-JC6HE824;Initial Catalog=ProyectoFinal;Integrated Security=True;";
            ConnectionBD dbHelper = new ConnectionBD(conn);

            //se obtiene el datatable con datos de la consulta
            DataTable data = dbHelper.GetData("Select * from tbl_usuarios");

            //Asignar datos de la db en el datagridview
            dgvEmpleados.DataSource = data;
        }
    }
}
