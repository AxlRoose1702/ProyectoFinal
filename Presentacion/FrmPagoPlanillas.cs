using System;
using System.Data;
using System.Windows.Forms;
using ProyectoFinal.Datos;
using ProyectoFinal.Logica;

namespace ProyectoFinal
{
    public partial class FrmPagoPlanillas : Form
    {
        CLPagoPlanillas cl_pagoPlanillas = new CLPagoPlanillas();
        CDPagoPlanillas cd_pagoPlanillas = new CDPagoPlanillas();

        private void MtdConsultarPP()
        {
            //se crea la tabla temporal  y se consulta la tabla usuarios
            // se hace llamado a través del CD y al metodo Consultar 
            DataTable Dt = cd_pagoPlanillas.MtdConsultarPP();
            dgvPagoPlanillas.DataSource = Dt;
        }
        //Este metodo llama a todos los empleados que existen
        //en la tabla empleados y los agrega al combobox
      
        public void mtdLimpiarCampos()
        {//metodo para limpiar los campos
            txtCodigoEmpleado.Clear();
            txtCodigoPP.Text = "0";
            txtHorasExtras.Text = "0";
            cboxEstado.Text = "Seleccionar";
            lblBono.Text = "0";
            lblSalario.Text = "0";
            lblMontoTotal.Text = "0";
            lblUsuarioSistema.Text = "UsuarioSistema"; // Cambiar por el nombre del usuario logueado
            MtdConsultarPP();
            //LOS CBOX DEBEN IR CON "Seleccionar"
        }
        public void MtdDatosPlanilla()
        {
            if (!string.IsNullOrEmpty(txtCodigoEmpleado.Text))
            {
                if (cd_pagoPlanillas.MtdVerificarEmpleado(int.Parse(txtCodigoEmpleado.Text)) == 1702)
                {
                    //se llama al metodo de salario en la clase CD
                    double Salario = cd_pagoPlanillas.MtdSalario(int.Parse(txtCodigoEmpleado.Text));
                    //se llama al metodo de bono en la clase CL
                    double Bono = cl_pagoPlanillas.MtdBono(Salario);
                    //se llama al metodo de monto total en la clase CL
                    if(string.IsNullOrEmpty(txtHorasExtras.Text))
                    {
                        txtHorasExtras.Text = "0";
                    }
                    double MontoTotal = cl_pagoPlanillas.MtdMontoTotal(Salario, Bono, int.Parse(txtHorasExtras.Text));
                    //se asigna el valor al label
                    lblSalario.Text = Salario.ToString();
                    lblBono.Text = Bono.ToString();
                    lblMontoTotal.Text = MontoTotal.ToString();
                }
            }
            else
            {
                mtdLimpiarCampos();
            }
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

        public FrmPagoPlanillas()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmMenuNavegacion nav = new FrmMenuNavegacion();
            nav.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void txtCodigoEmpleado_TextChanged(object sender, EventArgs e)
        {
            //mandar a traer el salario del empleado
            MtdDatosPlanilla();
        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoEmpleado.Text) || string.IsNullOrEmpty(txtCodigoPP.Text)
             || string.IsNullOrEmpty(txtHorasExtras.Text))
            {
                MessageBox.Show("Favor completar CodigoEmpleado, CodigoPP y HorasExtra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cboxEstado.Text) || cboxEstado.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(cd_pagoPlanillas.MtdVerificarEmpleado(int.Parse(txtCodigoEmpleado.Text)) != 1702)
                {
                    MessageBox.Show("El empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Declaracion de todas las variables con todos los objetos del form
                // int codigoUsuario = int.Parse(txtCodigoUsuario.Text);
                int CodigoEmpleado = int.Parse(txtCodigoEmpleado.Text);
                double Salario = double.Parse(lblSalario.Text);
                double Bono = double.Parse(lblBono.Text);
                double MontoTotal = double.Parse(lblMontoTotal.Text);
                int HorasExtra = int.Parse(txtHorasExtras.Text);
                string Estado = cboxEstado.Text;
                string UsuarioSistema = lblUsuarioSistema.Text;
                DateTime fechaP = dateFechaPago.Value;
                DateTime fechaS = dateFechaSistema.Value;

                try
                {
                    
                    //se llama al metodo de agregar empleado en la clase CD
                    cd_pagoPlanillas.MtdAgregarpp(CodigoEmpleado, fechaP, Salario, Bono, HorasExtra, MontoTotal, Estado, UsuarioSistema, fechaS);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    mtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPagoPlanillas_Load(object sender, EventArgs e)
        {
            //Este metodo lo tengo que crear antes, llamo al metodo consultar
            //desde la clase CD
            MtdConsultarPP();
            mtdLimpiarCampos();
        }

        private void txtHorasExtras_TextChanged(object sender, EventArgs e)
        {
            MtdDatosPlanilla();
        }
    }
}
