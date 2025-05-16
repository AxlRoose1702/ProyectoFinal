using ProyectoFinal.Presentacion;
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

        private void button11_Click(object sender, EventArgs e)
        {
            FrmConsumos consumo = new FrmConsumos();
            consumo.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmHabitaciones habitacion = new FrmHabitaciones();
            habitacion.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmPagos pagos = new FrmPagos();
            pagos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHuespedes huesped = new FrmHuespedes();
            huesped.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmReservaciones reservacion = new FrmReservaciones();
            reservacion.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmServicios servicio = new FrmServicios();
            servicio.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmAsignaciones asignacion = new FrmAsignaciones();
            asignacion.Show();
        }
    }
}
