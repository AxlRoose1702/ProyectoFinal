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

        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmMenuNavegacion nav = new FrmMenuNavegacion();
            nav.Show();
        }
         
        //metodo para consultar empleados, este se llama siempre al abrir la ventana
        private void MtdConsultarEmpleados()
        {
            //se crea la tabla temporal  y se consulta la tabla empleados
            // se hace llamado a través del CD y al metodo Consultar 
            DataTable Dt = cd_empleados.MtdConsultarEmpleados();
            dgvEmpleados.DataSource = Dt;
        }

        //Este es el load del form principal
        private void Empleados_Load(object sender, EventArgs e)
        {
            //Este metodo lo tengo que crear antes, llamo al metodo consultar
            //desde la clase CD
            MtdConsultarEmpleados();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaracion de todas las variables con todos los objetos del form
                double metodoSalario;

                string cargo = cboxCargo.Text;
                string nombre = txtNombre.Text;
                string estado = cboxEstado.Text;
                DateTime fechaS = dateFechaSistema.Value;
                DateTime fechaC = dateFechaContratacion.Value;
                int codigoEmpleado = int.Parse(txtCodigoEmpleado.Text);
                double salario = double.Parse(lblSalario.Text);
                string usuarioSistema = txtUsuarioSistema.Text;

                if (string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(codigoEmpleado.ToString()) || string.IsNullOrEmpty(usuarioSistema))
                {
                    MessageBox.Show("Hay datos vacios en el formulario");
                }
                else if (estado != "Activo" && estado != "Inactivo" && estado != "Suspendido" && estado != "Despedido")
                {
                    MessageBox.Show("Hay datos sin seleccionar en el formulario");
                }
                else 
                {
                    //Aqui se hace la logica para la insercion de datos a la BD
                    // se utiliza clase cd
                    cd_empleados.MtdAgregarEmpleados(nombre, cargo, salario, fechaC, estado, usuarioSistema, fechaC); //revisar porque no agrega, ver la cadena que se esta enviandos
                    // SE UTILIZO LA CLASE CL
                    metodoSalario = cl_empleados.SalarioEmpleado(cargo);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            //Declaracion de todas las variables con todos los objetos del form
            string cargo = cboxCargo.Text;
            string nombre = txtNombre.Text;
            string estado = cboxEstado.Text;
            DateTime fechaS = dateFechaSistema.Value;
            DateTime fechaC = dateFechaContratacion.Value;
            int codigoEmpleado = int.Parse(txtCodigoEmpleado.Text);
            string usuarioSistema = txtUsuarioSistema.Text;
            double salario = double.Parse(lblSalario.Text);

            if (string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(codigoEmpleado.ToString()) || string.IsNullOrEmpty(usuarioSistema))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cd_empleados.MtdActualizarEmpleados(codigoEmpleado, nombre, cargo, salario,fechaC, estado, usuarioSistema, fechaS);
                    MessageBox.Show("Medicamento actualizado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarEmpleados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
