using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MenuNavegacion : Form
    {
        public MenuNavegacion()
        {
            InitializeComponent();
        }

        private void btnMenuUsuarios_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            empleados.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PagoPlanillas pago = new PagoPlanillas();
            pago.Show();
        }
    }
}
