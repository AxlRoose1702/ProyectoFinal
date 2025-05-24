using ProyectoFinal.Datos;
using ProyectoFinal.Logica;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinal.Presentacion
{
    public partial class FrmAsignaciones : Form
    {
        CLProcesos proces = new CLProcesos();
        CDAsignaciones cd_asignar = new CDAsignaciones();
        CDHabitaciones cd_habitaciones = new CDHabitaciones();


        private void MtdConsultarAsignacion()
        {
            // se crea la tabla temporal y se consulta la tabla usuarios
            // se hace llamado a través del CD y al metodo Consultar 
            DataTable Dt = cd_asignar.MtdConsultarAsignacion();
            dgvAsignaciones.DataSource = Dt;
        }

        private void MtdMostrarListaEmpleados()
        {
            var ListaEmpleados = cd_asignar.MtdListaEmpleados();

            foreach (var Empleados in ListaEmpleados)
            {
                cboxCodigoEmpleado.Items.Add( Empleados );
            }
                
            cboxCodigoEmpleado.DisplayMember = "Text";
            cboxCodigoEmpleado.ValueMember = "Value";

        }

        private void MtdMostrarListaHabitacion()
        {
            var ListaHabitacion = cd_asignar.MtdListaHabitaciones();

            foreach (var Habitacion in ListaHabitacion)
            {
                cboxCodigoHabitacion.Items.Add(Habitacion);
            }

            cboxCodigoHabitacion.DisplayMember = "Text";
            cboxCodigoHabitacion.ValueMember = "Value";

        }
        public FrmAsignaciones()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxTipoAsignacion.Text) || string.IsNullOrEmpty(txtUsuarioSistema.Text) || 
                string.IsNullOrEmpty(cboxCodigoEmpleado.Text) || string.IsNullOrEmpty(cboxCodigoHabitacion.Text))
            {
                MessageBox.Show("Favor completar TipoAsignacion, UsuarioSistema, codigoEmpleado y codigoHabitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cboxEstado.Text) || cboxEstado.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoEmpleado = (int)((dynamic)cboxCodigoEmpleado.SelectedItem).Value;
                int CodigoHabitacion = (int)((dynamic)cboxCodigoHabitacion.SelectedItem).Value;
                string TipoAsignacion = cboxTipoAsignacion.Text;
                DateTime FechaAsignacion = dateAsignacion.Value;
                string Estado = cboxEstado.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime FechaSistema = dateSistema.Value;

                try
                {
                    cd_asignar.MtdAgregarAsignacion(CodigoEmpleado, CodigoHabitacion, TipoAsignacion, FechaAsignacion, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarAsignacion();
                    mtdLimpiarCampos();
                }
                catch(SqlException ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void mtdLimpiarCampos()
        {//metodo para limpiar los campos
            lblCodigoAsignacion.Text = "";
            cboxCodigoEmpleado.Text = "Seleccionar";
            cboxCodigoHabitacion.Text = "Seleccionar";
            cboxEstado.Text = "Seleccionar";
            cboxTipoAsignacion.Text = "Seleccionar";
            txtUsuarioSistema.Clear();
            //LOS CBOX DEBEN IR CON "Seleccionar"
        }

        private void FrmAsignaciones_Load(object sender, EventArgs e)
        {
            MtdConsultarAsignacion();
            MtdMostrarListaEmpleados();
            MtdMostrarListaHabitacion();
            mtdLimpiarCampos();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboxTipoAsignacion.Text) || string.IsNullOrEmpty(txtUsuarioSistema.Text) ||
                string.IsNullOrEmpty(cboxCodigoEmpleado.Text) || string.IsNullOrEmpty(cboxCodigoHabitacion.Text))
            {
                MessageBox.Show("Favor completar TipoAsignacion, UsuarioSistema, codigoEmpleado y codigoHabitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cboxEstado.Text) || cboxEstado.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoAsignacion = int.Parse(lblCodigoAsignacion.Text);
                int CodigoEmpleado = (int)((dynamic)cboxCodigoEmpleado.SelectedItem).Value;
                int CodigoHabitacion = (int)((dynamic)cboxCodigoHabitacion.SelectedItem).Value;
                string TipoAsignacion = cboxTipoAsignacion.Text;
                DateTime FechaAsignacion = dateAsignacion.Value;
                string Estado = cboxEstado.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime FechaSistema = dateSistema.Value;

                try
                {
                    cd_asignar.MtdActualizarAsignacion(CodigoAsignacion, CodigoEmpleado, CodigoHabitacion, TipoAsignacion, FechaAsignacion, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarAsignacion();
                    mtdLimpiarCampos();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvAsignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvAsignaciones.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvAsignaciones.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                lblCodigoAsignacion.Text = dgvAsignaciones.SelectedCells[0].Value.ToString();
                //cboxCodigoEmpleado.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
                int codigoEmpleado = (int)dgvAsignaciones.SelectedCells[1].Value;
                foreach (var codigoEmp in cboxCodigoEmpleado.Items)
                {
                    if (((dynamic)codigoEmp).Value == codigoEmpleado)
                    {
                        cboxCodigoEmpleado.SelectedItem = codigoEmp;
                    }
                }
                cboxCodigoHabitacion.Text = dgvAsignaciones.SelectedCells[2].Value.ToString();
                cboxTipoAsignacion.Text = dgvAsignaciones.SelectedCells[3].Value.ToString();
                dateAsignacion.Text = dgvAsignaciones.SelectedCells[4].Value.ToString();
                cboxEstado.Text = dgvAsignaciones.SelectedCells[5].Value.ToString();
                txtUsuarioSistema.Text = dgvAsignaciones.SelectedCells[6].Value.ToString();
                dateSistema.Text = dgvAsignaciones.SelectedCells[7].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCodigoAsignacion.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoAsignacion = int.Parse(lblCodigoAsignacion.Text);

                try
                {
                    cd_asignar.MtdEliminarAsignacion(CodigoAsignacion);
                    MessageBox.Show("Registro eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarAsignacion();
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
