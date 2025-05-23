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
    public partial class FrmServicios : Form
    {
        CDServicios cd_servicios = new CDServicios();
        CLServicios cl_servicios = new CLServicios();

        public FrmServicios()
        {
            InitializeComponent();
        }
        private void MtdConsultarServicios()
        {
            DataTable Dt = cd_servicios.MtdConsultarServicios();
            dgvServicios.DataSource = Dt;
        }
        private void MtdLimpiarCampos()
        {
            lblCodigoServicio.Text = "";
            txtNombre.Text = "";
            cboxTipoServicio.Text = "";
            txtPrecio.Text = "";
            cboxEstado.Text = "";
            txtUsuarioSistema.Text = UserCache.NombreUsuario;
            dtpVigencia.Text = DateTime.Now.ToString("d");
            dtpVencimiento.Text = DateTime.Now.ToString("d");
            dtpSistema.Text = DateTime.Now.ToString("d");
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            MtdConsultarServicios();
            txtUsuarioSistema.Text = UserCache.NombreUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxTipoServicio.Text))
            {
                MessageBox.Show("Favor indique Nombre y Tipo de Servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Nombre = txtNombre.Text;
                string Tipo = cboxTipoServicio.Text;
                double Precio = double.Parse(txtPrecio.Text);
                string Estado = cboxEstado.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime FechaVigencia = dtpVigencia.Value.Date;
                DateTime FechaVencimiento = dtpVencimiento.Value.Date;
                DateTime FechaSistema = dtpSistema.Value.Date;
                //se declaran las variables de auditoria

                try
                {
                    //se llama al metodo de agregar empleado en la clase CD
                    cd_servicios.MtdAgregarServicios(Nombre, Tipo, Precio, FechaVigencia, FechaVencimiento, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Servicio agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarServicios();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboxTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Precio = cl_servicios.MtdPrecioServicio(cboxTipoServicio.Text);
            txtPrecio.Text = Precio.ToString();
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvServicios.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvServicios.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblCodigoServicio.Text = dgvServicios.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvServicios.SelectedCells[1].Value.ToString();
                cboxTipoServicio.Text = dgvServicios.SelectedCells[2].Value.ToString();
                txtPrecio.Text = dgvServicios.SelectedCells[3].Value.ToString();
                cboxEstado.Text = dgvServicios.SelectedCells[6].Value.ToString();
                dtpVigencia.Text = dgvServicios.SelectedCells[4].Value.ToString();
                dtpVencimiento.Text = dgvServicios.SelectedCells[5].Value.ToString();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxTipoServicio.Text))
            {
                MessageBox.Show("Favor indique Nombre y Tipo de Servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoServicio = int.Parse(lblCodigoServicio.Text);
                string Nombre = txtNombre.Text;
                string Tipo = cboxTipoServicio.Text;
                double Precio = double.Parse(txtPrecio.Text);
                string Estado = cboxEstado.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime FechaVigencia = dtpVigencia.Value.Date;
                DateTime FechaVencimiento = dtpVencimiento.Value.Date;
                DateTime FechaSistema = dtpSistema.Value.Date;

                try
                {
                    cd_servicios.MtdActualizarServicios(CodigoServicio, Nombre, Tipo, Precio, FechaVigencia, FechaVencimiento, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Servicio actualizado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarServicios();
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
            if (string.IsNullOrEmpty(lblCodigoServicio.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoServicio = int.Parse(lblCodigoServicio.Text);

                try
                {
                    cd_servicios.MtdEliminarServicios(CodigoServicio);
                    MessageBox.Show("Registro eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarServicios();
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
