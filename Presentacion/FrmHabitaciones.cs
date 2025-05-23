using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Seguridad;
using ProyectoFinal.Datos;
using ProyectoFinal.Logica;

namespace ProyectoFinal.Presentacion
{
    public partial class FrmHabitaciones : Form
    {
        CDHabitaciones cd_habitaciones = new CDHabitaciones();
        CLHabitaciones cl_habitaciones = new CLHabitaciones();
        public FrmHabitaciones()
        {
            InitializeComponent();
        }

        private void MtdConsultarHabitaciones()
        {
            DataTable Dt = cd_habitaciones.MtdConsultarHabitaciones();
            dgvHabitaciones.DataSource = Dt;
        }
        private void MtdLimpiarCampos()
        {
            lblCodigoHabitacion.Text = "";
            txtNumero.Text = "";
            cboxUbicacion.Text = "";
            txtPrecio.Text = "";
            txtUsuarioSistema.Text = UserCache.NombreUsuario;
            cboxEstado.Text = "";
            cboxTipoHabitacion.Text = "";
            dtpFecha.Text = DateTime.Now.ToString("d");
        }

        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            MtdConsultarHabitaciones();
            txtUsuarioSistema.Text = UserCache.NombreUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(cboxUbicacion.Text))
            {
                MessageBox.Show("Favor indique ubicacion y numero de la habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(cboxTipoHabitacion.Text))
            {
                MessageBox.Show("Favor llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Numero = txtNumero.Text;
                string Ubicacion = cboxUbicacion.Text;
                double Precio = double.Parse(txtPrecio.Text);
                string UsuarioSistema = txtUsuarioSistema.Text;
                string Estado = cboxEstado.Text;
                string Tipo = cboxTipoHabitacion.Text;
                DateTime FechaSistema = dtpFecha.Value.Date;
                //se declaran las variables de auditoria

                try
                {
                    //se llama al metodo de agregar empleado en la clase CD
                    cd_habitaciones.MtdAgregarHabitaciones(Numero, Ubicacion, Tipo, Precio, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Habitacion agregada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cboxTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Precio = cl_habitaciones.MtdPrecioHabitacion(cboxTipoHabitacion.Text);
            txtPrecio.Text = Precio.ToString();
        }

        private void dgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvHabitaciones.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvHabitaciones.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblCodigoHabitacion.Text = dgvHabitaciones.SelectedCells[0].Value.ToString();
                txtNumero.Text = dgvHabitaciones.SelectedCells[1].Value.ToString();
                cboxUbicacion.Text = dgvHabitaciones.SelectedCells[2].Value.ToString();
                cboxTipoHabitacion.Text = dgvHabitaciones.SelectedCells[3].Value.ToString();
                txtPrecio.Text = dgvHabitaciones.SelectedCells[4].Value.ToString();
                cboxEstado.Text = dgvHabitaciones.SelectedCells[5].Value.ToString();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(cboxUbicacion.Text))
            {
                MessageBox.Show("Favor indique ubicacion y numero de la habitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(cboxTipoHabitacion.Text))
            {
                MessageBox.Show("Favor llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHabitacion = int.Parse(lblCodigoHabitacion.Text);
                string Numero = txtNumero.Text;
                string Ubicacion = cboxUbicacion.Text;
                double Precio = double.Parse(txtPrecio.Text);
                string UsuarioSistema = txtUsuarioSistema.Text;
                string Estado = cboxEstado.Text;
                string Tipo = cboxTipoHabitacion.Text;
                DateTime FechaSistema = dtpFecha.Value;

                try
                {
                    cd_habitaciones.MtdActualizarHabitacion(CodigoHabitacion, Numero, Ubicacion, Tipo, Precio, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Habitacion actualizada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCodigoHabitacion.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHabitacion = int.Parse(lblCodigoHabitacion.Text);

                try
                {
                    cd_habitaciones.MtdEliminarHabitacion(CodigoHabitacion);
                    MessageBox.Show("Registro eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MtdLimpiarCampos();
        }
    }
}
