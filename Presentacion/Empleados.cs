using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Empleados : Form
    {
        Procesos proces = new Procesos();
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            MenuNavegacion nav = new MenuNavegacion();
            nav.Show();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {

            string conn = "Data Source=LAPTOP-JC6HE824;Initial Catalog=ProyectoFinal;Integrated Security=True;";
            ConnectionBD dbHelper = new ConnectionBD(conn);

            //se obtiene el datatable con datos de la consulta
            DataTable data = dbHelper.GetData("Select * from tbl_empleados");

            //Asignar datos de la db en el datagridview
            dgvEmpleados.DataSource = data;
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
                    metodoSalario = proces.SalarioEmpleado(cargo);

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
                salario = proces.SalarioEmpleado(cargo);
                
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
