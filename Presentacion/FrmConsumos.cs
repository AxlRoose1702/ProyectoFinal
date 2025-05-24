using CapaPresentacion.Seguridad;
using ProyectoFinal.Datos;
using ProyectoFinal.Logica;
using System;
using System.Data;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ProyectoFinal.Presentacion
{
    public partial class FrmConsumos : Form
    {
        CDConsumos cd_consumos = new CDConsumos();
        CLConsumo cl_consumos = new CLConsumo();
        private void MtdConsultarConsumos()
        {
            // se crea la tabla temporal y se consulta la tabla usuarios
            // se hace llamado a través del CD y al metodo Consultar 
            DataTable Dt = cd_consumos.MtdConsultarConsumos();
            dgvConsumos.DataSource = Dt;
        }
        private void MtdMostrarListaReservacion()
        {
            var ListaReservacion = cd_consumos.MtdListReservacion();

            foreach (var Reservacion in ListaReservacion)
            {
                cboxCodigoReserva.Items.Add(Reservacion);
            }

            cboxCodigoReserva.DisplayMember = "Text";
            cboxCodigoReserva.ValueMember = "Value";

        }
        private void MtdMostrarListaServicios()
        {
            var ListaServicios = cd_consumos.MtdListServicios();

            foreach (var Servicios in ListaServicios)
            {
                cboxCodigoServicio.Items.Add(Servicios);
            }

            cboxCodigoServicio.DisplayMember = "Text";
            cboxCodigoServicio.ValueMember = "Value";

        }
        public FrmConsumos()
        {
            InitializeComponent();
        }
        public void mtdLimpiarCampos()
        {
            //metodo para limpiar los campos
            lblCodigoConsumo.Text = "";
            cboxCodigoReserva.Text = "Seleccionar";
            cboxCodigoServicio.Text = "Seleccionar";
            lblMonto.Text = "";
            txtUsuarioSistema.Text = UserCache.NombreUsuario;
            cboxEstado.Text = "Seleccionar";

        }

        private void FrmConsumos_Load(object sender, EventArgs e)
        {
            MtdConsultarConsumos();
            MtdMostrarListaReservacion();
            MtdMostrarListaServicios();
            mtdLimpiarCampos();
        }

        private void cboxCodigoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int servicio = (int)((dynamic)cboxCodigoServicio.SelectedItem).Value;
                int salario = (int)cl_consumos.MtdMontoConsumo(servicio);

                if (string.IsNullOrEmpty(cboxCodigoServicio.Text))
                {
                    MessageBox.Show("Seleccionar servicio", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblMonto.Text = salario.ToString("c");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoReserva.Text) || string.IsNullOrEmpty(cboxCodigoServicio.Text) ||
                string.IsNullOrEmpty(txtUsuarioSistema.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor indique codigoReserva, codigoServicio, usuarioSistema y estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoConsumo = int.Parse(lblCodigoConsumo.Text);
                int CodigoReserva = (int)((dynamic)cboxCodigoReserva.SelectedItem).Value;
                int CodigoServicio = (int)((dynamic)cboxCodigoServicio.SelectedItem).Value;
                int monto = int.Parse(lblMonto.Text);
                DateTime FechaConsumo = dateConsumo.Value.Date;
                string Estado = cboxEstado.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime FechaSistema = dateSistema.Value.Date;
                try
                {
                    cd_consumos.MtdActualizarConsumos(CodigoConsumo, CodigoReserva, CodigoServicio, monto, FechaConsumo, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Servicio agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarConsumos();
                    mtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvConsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvConsumos.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvConsumos.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblCodigoConsumo.Text = dgvConsumos.SelectedCells[0].Value.ToString();
                cboxCodigoReserva.Text = dgvConsumos.SelectedCells[1].Value.ToString();
                cboxCodigoServicio.Text = dgvConsumos.SelectedCells[2].Value.ToString();
                lblMonto.Text = dgvConsumos.SelectedCells[3].Value.ToString();
                dateConsumo.Text = dgvConsumos.SelectedCells[4].Value.ToString();
                cboxEstado.Text = dgvConsumos.SelectedCells[6].Value.ToString();
                txtUsuarioSistema.Text = dgvConsumos.SelectedCells[7].Value.ToString();
                dateSistema.Text = dgvConsumos.SelectedCells[8].Value.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxCodigoReserva.Text) || string.IsNullOrEmpty(cboxCodigoServicio.Text) ||
                string.IsNullOrEmpty(txtUsuarioSistema.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor indique codigoReserva, codigoServicio, usuarioSistema y estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoReserva = (int)((dynamic)cboxCodigoReserva.SelectedItem).Value;
                int CodigoServicio = (int)((dynamic)cboxCodigoServicio.SelectedItem).Value;
                int monto = int.Parse(lblMonto.Text);
                DateTime FechaConsumo = dateConsumo.Value.Date;
                string Estado = cboxEstado.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime FechaSistema = dateSistema.Value.Date;
                try
                {
                    cd_consumos.MtdAgregarConsumos(CodigoReserva, CodigoServicio, monto, FechaConsumo, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Servicio agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarConsumos();
                    mtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
