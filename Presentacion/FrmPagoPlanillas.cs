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
            txtCodigoPP.Clear();
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
            //siempre verificar que el load ya tenga la información necesaria y este creado el mtdConsultar
            if (string.IsNullOrEmpty(txtCodigoEmpleado.Text) || string.IsNullOrEmpty(txtHorasExtras.Text))
            {
                MessageBox.Show("Favor completar CodigoEmpleado y HorasExtra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        { //actualiza los datos de planilla instantaneamente
            MtdDatosPlanilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //las condiciones if-else se repiten en el boton agregar y editar, pero no se pueden poner en un metodo
            if (string.IsNullOrEmpty(txtCodigoEmpleado.Text) || string.IsNullOrEmpty(txtHorasExtras.Text))
            {
                MessageBox.Show("Favor completar CodigoEmpleado y HorasExtra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cboxEstado.Text) || cboxEstado.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cd_pagoPlanillas.MtdVerificarEmpleado(int.Parse(txtCodigoEmpleado.Text)) != 1702)
                {
                    MessageBox.Show("El empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Declaracion de todas las variables con todos los objetos del form
                int codigoPP = int.Parse(txtCodigoPP.Text);
                int CodigoEmpleado = int.Parse(txtCodigoEmpleado.Text);
                double Salario = double.Parse(lblSalario.Text);
                double Bono = double.Parse(lblBono.Text);
                double MontoTotal = double.Parse(lblMontoTotal.Text);
                int HorasExtra = int.Parse(txtHorasExtras.Text);
                string Estado = cboxEstado.Text;
                string UsuarioSistema = lblUsuarioSistema.Text;
                DateTime fechaP = dateFechaPago.Value;
                DateTime fechaS = dateFechaSistema.Value;

                //ESTO ES LO MISMO QUE EN EL BOTON AGREGAR

                try
                {
                    //se llama al metodo de ACTUALIZAR empleado en la clase CD
                    cd_pagoPlanillas.MtdActualizarPP(codigoPP, CodigoEmpleado, fechaP, Salario, Bono, HorasExtra, MontoTotal, Estado, UsuarioSistema, fechaS);
                    MessageBox.Show("Datos actualizados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPP(); //esto recarga la dgv para ver los cambios
                    mtdLimpiarCampos(); //limpia los datos que hemos actualizado
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPagoPlanillas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//ignorar
        }

        private void dgvPagoPlanillas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvPagoPlanillas.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvPagoPlanillas.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoPP.Text = dgvPagoPlanillas.SelectedCells[0].Value.ToString();
                txtCodigoEmpleado.Text = dgvPagoPlanillas.SelectedCells[1].Value.ToString();
                dateFechaPago.Value = DateTime.Parse(dgvPagoPlanillas.SelectedCells[2].Value.ToString());
                lblSalario.Text = dgvPagoPlanillas.SelectedCells[3].Value.ToString();
                lblBono.Text = dgvPagoPlanillas.SelectedCells[4].Value.ToString();
                txtHorasExtras.Text = dgvPagoPlanillas.SelectedCells[5].Value.ToString();
                lblMontoTotal.Text = dgvPagoPlanillas.SelectedCells[6].Value.ToString();
                cboxEstado.Text = dgvPagoPlanillas.SelectedCells[7].Value.ToString();
                lblUsuarioSistema.Text = dgvPagoPlanillas.SelectedCells[8].Value.ToString();
                dateFechaSistema.Value = DateTime.Parse(dgvPagoPlanillas.SelectedCells[9].Value.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoPP.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoPP = int.Parse(txtCodigoPP.Text);

                try
                {
                    cd_pagoPlanillas.MtdEliminarPP(CodigoPP);
                    MessageBox.Show("Usuario eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPP();
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
