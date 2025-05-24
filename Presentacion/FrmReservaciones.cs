using ProyectoFinal.Datos;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal.Presentacion
{
    public partial class FrmReservaciones : Form
    {
        CDReservaciones cd_reservaciones = new CDReservaciones();

        private void MtdConsultarReservaciones()
        {
            DataTable Dt = cd_reservaciones.MtdConsultarReservaciones();
            dgvReservaciones.DataSource = Dt;
        }

        private void MtdMostrarListaHuespedes()
        {
            var ListaHuesped = cd_reservaciones.MtdListaHuesped();

            foreach (var Huesped in ListaHuesped)
            {
                cboxCodigoHuesped.Items.Add(Huesped);
            }

            cboxCodigoHuesped.DisplayMember = "Text";
            cboxCodigoHuesped.ValueMember = "Value";

        }

        private void MtdMostrarListaHabitacion()
        {
            var ListaHabitacion = cd_reservaciones.MtdListaHabitacion();

            foreach (var Habitacion in ListaHabitacion)
            {
                cboxCodigoHabitacion.Items.Add(Habitacion);
            }

            cboxCodigoHabitacion.DisplayMember = "Text";
            cboxCodigoHabitacion.ValueMember = "Value";

        }
        public FrmReservaciones()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoHabitacion.Text) || string.IsNullOrEmpty(cboxCodigoHuesped.Text) ||
                string.IsNullOrEmpty(lblTotal.Text) || string.IsNullOrEmpty(txtUsuarioSistema.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor completar codigoHabitacion, codigoHuesped, total, usuarioSistema, estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(cboxEstado.Text) || cboxEstado.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoReserva = int.Parse(lblCodigoReserva.Text);
                int CodigoHuesped = (int)((dynamic)cboxCodigoHuesped.SelectedItem).Value;
                int CodigoHabitacion = (int)((dynamic)cboxCodigoHabitacion.SelectedItem).Value;
                DateTime FechaEntrada = dateEntrada.Value;
                DateTime FechaSalida = dateSalida.Value;
                int Total = int.Parse(lblTotal.Text);
                string UsuarioSistema = txtUsuarioSistema.Text;
                //string Estado = cboxEstado.Text; No se encuentra este valor en la bd
                DateTime FechaSistema = dateSistema.Value;

                try
                {
                    cd_reservaciones.MtdActualizarReserva(CodigoReserva,CodigoHuesped, CodigoHabitacion, FechaEntrada, FechaSalida, Total, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarReservaciones();
                    MtdLimpiarDatos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void FrmReservaciones_Load(object sender, EventArgs e)
        {
            MtdConsultarReservaciones();
            MtdMostrarListaHuespedes();
            MtdMostrarListaHabitacion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoHabitacion.Text) || string.IsNullOrEmpty(cboxCodigoHuesped.Text) || 
                string.IsNullOrEmpty(lblTotal.Text) || string.IsNullOrEmpty(txtUsuarioSistema.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor completar codigoHabitacion, codigoHuesped, total, usuarioSistema, estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(cboxEstado.Text) || cboxEstado.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHuesped = (int)((dynamic)cboxCodigoHuesped.SelectedItem).Value;
                int CodigoHabitacion = (int)((dynamic)cboxCodigoHabitacion.SelectedItem).Value;
                DateTime FechaEntrada = dateEntrada.Value;
                DateTime FechaSalida = dateSalida.Value;
                int Total = int.Parse(lblTotal.Text);
                string UsuarioSistema = txtUsuarioSistema.Text;
                //string Estado = cboxEstado.Text;
                DateTime FechaSistema = dateSistema.Value;

                try
                {
                    cd_reservaciones.MtdAgregarReservaciones(CodigoHuesped, CodigoHabitacion, FechaEntrada, FechaSalida, Total, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarReservaciones();
                    MtdLimpiarDatos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MtdLimpiarDatos()
        {
            lblCodigoReserva.Text = "";
            cboxCodigoHabitacion.Text = "Seleccionar";
            cboxCodigoHuesped.Text = "Seleccionar";
            lblTotal.Text = "";
            txtUsuarioSistema.Clear();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MtdLimpiarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCodigoReserva.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoReservacion = int.Parse(lblCodigoReserva.Text);

                try
                {
                    cd_reservaciones.MtdEliminarReservacion(CodigoReservacion);
                    MessageBox.Show("Registro eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarReservaciones();
                    MtdLimpiarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvReservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvReservaciones.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvReservaciones.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                lblCodigoReserva.Text = dgvReservaciones.SelectedCells[0].Value.ToString();
                //cboxCodigoEmpleado.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
                int CodigoHuesped = (int)dgvReservaciones.SelectedCells[1].Value;
                foreach (var codigoHues in cboxCodigoHuesped.Items)
                {
                    if (((dynamic)codigoHues).Value == CodigoHuesped)
                    {
                        cboxCodigoHuesped.SelectedItem = codigoHues;
                    }
                }
                cboxCodigoHabitacion.Text = dgvReservaciones.SelectedCells[2].Value.ToString();
                dateEntrada.Text = dgvReservaciones.SelectedCells[3].Value.ToString();
                dateSalida.Text = dgvReservaciones.SelectedCells[4].Value.ToString();
                lblTotal.Text = dgvReservaciones.SelectedCells[5].Value.ToString();
                txtUsuarioSistema.Text = dgvReservaciones.SelectedCells[6].Value.ToString();
                dateSistema.Text = dgvReservaciones.SelectedCells[7].Value.ToString();
            }
        }
    }
}
