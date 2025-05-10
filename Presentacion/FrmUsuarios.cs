using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmUsuarios : Form
    {
        Procesos proces = new Procesos();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaracion de todas las variables con todos los objetos del form
                int codigoUsuario = int.Parse(txtCodigoUsuario.Text);
                int codigoEmpleado = int.Parse(lblCodigoEmpleado.Text);
                string nombre = txtNombreUsuario.Text;
                string contrasena = txtPassword.Text;
                string rol = cboxRol.Text;
                string estado = cboxEstado.Text;
                string usuarioSistema = txtUsuarioSistema.Text;
                DateTime fechaS = dateFechaSistema.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmMenuNavegacion nav = new FrmMenuNavegacion();
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
