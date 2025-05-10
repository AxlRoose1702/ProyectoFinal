using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmMenuNavegacion : Form
    {
        public FrmMenuNavegacion()
        {
            InitializeComponent();
        }

        private void btnMenuUsuarios_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleados = new FrmEmpleados();
            empleados.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPagoPlanillas pago = new FrmPagoPlanillas();
            pago.Show();
        }
    }
}
