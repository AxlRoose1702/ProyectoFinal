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
    public partial class FrmHuespedes : Form
    {
        CDHuespedes cd_huespedes = new CDHuespedes();

        public FrmHuespedes()
        {
            InitializeComponent();
        }
        private void MtdConsultarHuespedes()
        {
            DataTable Dt = cd_huespedes.MtdConsultarHuespedes();
            dgvHuespedes.DataSource = Dt;
        }
        private void MtdLimpiarCampos()
        {
            lblCodigoHuesped.Text = "";
            txtNombre.Text = "";
            txtNit.Text = "";
            txtTelefono.Text = "";
            cboxEstado.Text = "";
            cboxTipo.Text = "";
            txtUsuarioSistema.Text = UserCache.NombreUsuario;
            dtpSistema.Text = DateTime.Now.ToString("d");
        }

        private void FrmHuespedes_Load(object sender, EventArgs e)
        {
            MtdConsultarHuespedes();
            txtUsuarioSistema.Text = UserCache.NombreUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNit.Text))
            {
                MessageBox.Show("Favor indique Nombre y NIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(cboxTipo.Text))
            {
                MessageBox.Show("Favor llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Nombre = txtNombre.Text;
                string NIT = txtNit.Text;
                string Telefono = txtTelefono.Text;
                string Estado = cboxEstado.Text;
                string Tipo = cboxTipo.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime FechaSistema = dtpSistema.Value.Date;
                //se declaran las variables de auditoria

                try
                {
                    //se llama al metodo de agregar empleado en la clase CD
                    cd_huespedes.MtdAgregarHuespedes(Nombre, NIT, Telefono, Tipo, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Huesped agregado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHuespedes();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvHuespedes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvHuespedes.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvHuespedes.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblCodigoHuesped.Text = dgvHuespedes.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvHuespedes.SelectedCells[1].Value.ToString();
                txtNit.Text = dgvHuespedes.SelectedCells[2].Value.ToString();
                txtTelefono.Text = dgvHuespedes.SelectedCells[3].Value.ToString();
                cboxTipo.Text = dgvHuespedes.SelectedCells[4].Value.ToString();
                cboxEstado.Text = dgvHuespedes.SelectedCells[5].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtNit.Text))
            {
                MessageBox.Show("Favor indique Nombre y NIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(cboxEstado.Text) || string.IsNullOrEmpty(cboxTipo.Text))
            {
                MessageBox.Show("Favor llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHuesped = int.Parse(lblCodigoHuesped.Text);
                string Nombre = txtNombre.Text;
                string NIT = txtNit.Text;
                string Telefono = txtTelefono.Text;
                string Estado = cboxEstado.Text;
                string Tipo = cboxTipo.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime FechaSistema = dtpSistema.Value.Date;

                try
                {
                    cd_huespedes.MtdActualizarHuespedes(CodigoHuesped, Nombre, NIT, Telefono, Tipo, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Servicio actualizado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHuespedes();
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
            if (string.IsNullOrEmpty(lblCodigoHuesped.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoHuesped = int.Parse(lblCodigoHuesped.Text);

                try
                {
                    cd_huespedes.MtdEliminarHuespedes(CodigoHuesped);
                    MessageBox.Show("Registro eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHuespedes();
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
