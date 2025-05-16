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
    }
}
