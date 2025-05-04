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
    }
}
