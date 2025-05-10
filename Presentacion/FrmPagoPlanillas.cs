using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmPagoPlanillas : Form
    {
        Procesos proces = new Procesos();
        public FrmPagoPlanillas()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmMenuNavegacion nav = new FrmMenuNavegacion();
            nav.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoPP = int.Parse(txtCodigoPP.Text);
                int horasE = int.Parse(txtHorasExtras.Text);
                int codigoEmpleado = int.Parse(lblCodigoEmpleado.Text);
                double salario = proces.SalarioPlanilla(codigoEmpleado);
                double bono = proces.SalarioBono(salario);
                double montoTotal = proces.MontoTotal(salario, bono, horasE);
                string estado = cboxEstado.Text;
                string usuarioSistema = txtUsuarioSistema.Text;
                DateTime fechaPago = dateFechaPago.Value;
                DateTime fechaS = dateFechaSistema.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
