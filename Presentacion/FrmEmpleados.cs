using System;
using System.Data;
using System.Windows.Forms;
using ProyectoFinal.Datos;
using ProyectoFinal.Logica;

namespace ProyectoFinal
{
    public partial class FrmEmpleados : Form
    {
        //aqui se declaran los objetos de las clases
        // CD Y CL
        CLEmpleados cl_empleados = new CLEmpleados();
        CDEmpleados cd_empleados = new CDEmpleados();

        //metodo para consultar empleados, este se llama siempre al abrir la ventana
        private void MtdConsultarEmpleados()
        {
            //se crea la tabla temporal  y se consulta la tabla empleados
            // se hace llamado a través del CD y al metodo Consultar 
            DataTable Dt = cd_empleados.MtdConsultarEmpleados();
            dgvEmpleados.DataSource = Dt;
        }
        public void mtdLimpiarCampos()
        {//metodo para limpiar los campos
            txtNombre.Clear();
            txtUsuarioSistema.Clear();
            cboxCargo.Text = "Seleccionar";
            cboxEstado.Text = "Seleccionar";
            lblSalario.Text = "0.00";
            txtCodigoEmpleado.Clear();
        }

        /*
            Para que el programa funcione debe contener lo siguiente:
                Boton configurado de:
                    AGREGAR
                    EDITAR
                    CANCELAR
                    ELIMINAR
                MTDConsultar
                MTDLimpiar
                Modificar el LOAD
                DGV Cell click 
         */

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmMenuNavegacion nav = new FrmMenuNavegacion();
            nav.Show();
        }
       
        //Este es el load del form principal
        private void Empleados_Load(object sender, EventArgs e)
        {
            //Este metodo lo tengo que crear antes, llamo al metodo consultar
            //desde la clase CD
            MtdConsultarEmpleados();
            mtdLimpiarCampos();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {         
        }
        private void cboxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cargo;
                double salario;
                cargo = cboxCargo.Text;
                salario = cl_empleados.SalarioEmpleado(cargo);
                
                if (string.IsNullOrEmpty(cargo))
                {
                    MessageBox.Show("Seleccionar Cargo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    lblSalario.Text = salario.ToString("c");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvEmpleados.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvEmpleados.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoEmpleado.Text = dgvEmpleados.SelectedCells[0].Value.ToString();
                txtNombre.Text = dgvEmpleados.SelectedCells[1].Value.ToString();
                cboxCargo.Text = dgvEmpleados.SelectedCells[2].Value.ToString();
                lblSalario.Text = dgvEmpleados.SelectedCells[3].Value.ToString();
                dateFechaContratacion.Text = dgvEmpleados.SelectedCells[4].Value.ToString();
                cboxEstado.Text = dgvEmpleados.SelectedCells[5].Value.ToString();
                txtUsuarioSistema.Text = dgvEmpleados.SelectedCells[6].Value.ToString();
                dateFechaSistema.Text = dgvEmpleados.SelectedCells[7].Value.ToString();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtUsuarioSistema.Text))
            {
                MessageBox.Show("Favor completar nombre y Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cboxCargo.Text) || cboxCargo.Text == "Seleccionar"
                 || string.IsNullOrEmpty(cboxEstado.Text) || cboxEstado.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de cargo y estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int CodigoEmpleado = int.Parse(txtCodigoEmpleado.Text);
                string Nombre = txtNombre.Text;
                string Cargo = cboxCargo.Text;
                double Salario = cl_empleados.SalarioEmpleado(Cargo);
                DateTime FechaContratacion = dateFechaContratacion.Value;
                string Estado = cboxEstado.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime FechaSistema = dateFechaSistema.Value;
                //se declaran las variables de auditoria
                
                try
                {
                    //se llama al metodo de ACTUALIZAR empleado en la clase CD
                    cd_empleados.MtdActualizarEmpleados(CodigoEmpleado, Nombre, Cargo, Salario, FechaContratacion, Estado, UsuarioSistema, FechaSistema);
                    MessageBox.Show("Datos actualizados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
                    mtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiarCampos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoEmpleado.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoEmpleado = int.Parse(txtCodigoEmpleado.Text);

                try
                {
                    cd_empleados.MtdEliminarEmpleados(CodigoEmpleado);
                    MessageBox.Show("Empleado eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
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
