using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class PagoPlanillas : Form
    {
        Procesos proces = new Procesos();
        public PagoPlanillas()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MenuNavegacion nav = new MenuNavegacion();
            nav.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoPP, codigoEmpleado, horasE;
                double salario, bono, montoTotal;
                string fechaPago, estado, usuarioSistema, fechaS;

                codigoPP = int.Parse(txtCodigoPP.Text);
                horasE = int.Parse(txtHorasExtras.Text);
                codigoEmpleado = int.Parse(lblCodigoEmpleado.Text);
                salario = proces.SalarioPlanilla(codigoEmpleado);
                bono = proces.SalarioBono(salario);
                montoTotal = proces.MontoTotal(salario, bono, horasE);
                fechaPago = dateFechaPago.Text;
                estado = cboxEstado.Text;
                usuarioSistema = txtUsuarioSistema.Text;
                fechaS = dateFechaSistema.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
