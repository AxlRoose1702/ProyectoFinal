using System;
using System.Data;
using System.Windows.Forms;
using ProyectoFinal.Datos;
using ProyectoFinal.Logica;

namespace ProyectoFinal
{
    public partial class FrmUsuarios : Form
    {
        CLProcesos proces = new CLProcesos();
        //CLUsuarios cl_usuarios = new CLUsuarios();
        //CDUsuarios cd_usuarios = new CDUsuarios();
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
           

        }
    }
}
