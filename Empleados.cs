using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MenuNavegacion nav = new MenuNavegacion();
            nav.Show();
        }
    }
}
