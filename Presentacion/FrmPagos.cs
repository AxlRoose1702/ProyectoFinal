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
    public partial class FrmPagos : Form
    {
        CLPagos cl_pagos = new CLPagos();
        CDPagos cd_pagos = new CDPagos();

        private void MtdConsultarPago()
        {
            //se crea la tabla temporal  y se consulta la tabla usuarios
            // se hace llamado a través del CD y al metodo Consultar 
            DataTable Dt = cd_pagos.MtdConsultarPagos();
            dgvPagos.DataSource = Dt;
        }
        //Este metodo llama a todos los empleados que existen
        //en la tabla empleados y los agrega al combobox

        public void mtdLimpiarCampos()
        {//metodo para limpiar los campos
            txtCodigoPago.Clear();
            lblMonto.Text = "0";
            lblPropina.Text = "0";
            lblDescuento.Text = "0";
            lblImpuesto.Text = "0";
            txtCodigoPago.Clear();
            lblTotalPago.Text = "0";
            cboxMetodo.Text = "Seleccionar";
            txtUsuarioSistema.Text = UserCache.NombreUsuario; // Cambiar por el nombre del usuario logueado
            MtdConsultarPago();
            //LOS CBOX DEBEN IR CON "Seleccionar"
        }
        public void MtdDatosReservacion()
        {
            if (!string.IsNullOrEmpty(txtCodigoReserva.Text))
            {
                if (cd_pagos.MtdVerificarReserva(int.Parse(txtCodigoReserva.Text)) == 1702)
                {
                    //se llama al metodo de salario en la clase CD
                    double MontoPago = cd_pagos.MtdMonto(int.Parse(txtCodigoReserva.Text));
                    double Descuento = cl_pagos.MtdDescuentoPago(MontoPago);
                    double Impuesto = cl_pagos.MtdImpuestoPago(MontoPago);
                    double Propina = cl_pagos.MtdPropinaPago(MontoPago);
                    double TotalPago = cl_pagos.MtdTotalPago(MontoPago, Propina, Impuesto, Descuento);
                    //se asigna el valor al label
                    lblDescuento.Text = Descuento.ToString();
                    lblImpuesto.Text = Impuesto.ToString();
                    lblPropina.Text = Propina.ToString();
                    lblTotalPago.Text = TotalPago.ToString();
                    lblMonto.Text = MontoPago.ToString();
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
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // boton eliminar

            if (string.IsNullOrEmpty(txtCodigoPago.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoPago = int.Parse(txtCodigoPago.Text);

                try
                {
                    cd_pagos.MtdEliminarPago(CodigoPago);
                    MessageBox.Show("Pago eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPago();
                    mtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //BOTON AGREGAR

            //siempre verificar que el load ya tenga la información necesaria y este creado el mtdConsultar
            if (string.IsNullOrEmpty(txtCodigoReserva.Text) || string.IsNullOrEmpty(txtUsuarioSistema.Text))
            {
                MessageBox.Show("Favor completar CodigoReservación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cboxMetodo.Text) || cboxMetodo.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de MetodoPago y TipoPago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cd_pagos.MtdVerificarReserva(int.Parse(txtCodigoReserva.Text)) != 1702)
                {
                    MessageBox.Show("La reservación no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Declaracion de todas las variables con todos los objetos del form
                int CodigoPago = int.Parse(txtCodigoPago.Text);
                int CodigoReserva = int.Parse(txtCodigoReserva.Text);
                double Monto = double.Parse(lblMonto.Text);
                double Propina = double.Parse(lblPropina.Text);
                double Impuesto = double.Parse(lblImpuesto.Text);
                double Descuento = double.Parse(lblDescuento.Text);
                double MontoTotal = double.Parse(lblTotalPago.Text);
                string Metodo = cboxMetodo.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime fechaP = datePago.Value;
                DateTime fechaS = dateSistema.Value;

                try
                {
                    //se llama al metodo de agregar empleado en la clase CD
                    cd_pagos.MtdAgregarPago(CodigoReserva, Monto, Propina, Impuesto, Descuento, MontoTotal, fechaP, Metodo, UsuarioSistema, fechaS);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // boton editar

            //las condiciones if-else se repiten en el boton agregar y editar, pero no se pueden poner en un metodo
            if (string.IsNullOrEmpty(txtCodigoReserva.Text) || string.IsNullOrEmpty(txtUsuarioSistema.Text))
            {
                MessageBox.Show("Favor completar CodigoReservación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cboxMetodo.Text) || cboxMetodo.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de MetodoPago y TipoPago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cd_pagos.MtdVerificarReserva(int.Parse(txtCodigoReserva.Text)) != 1702)
                {
                    MessageBox.Show("La reservación no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Declaracion de todas las variables con todos los objetos del form
                int CodigoPago = int.Parse(txtCodigoPago.Text);
                int CodigoReserva = int.Parse(txtCodigoReserva.Text);
                double Monto = double.Parse(lblMonto.Text);
                double Propina = double.Parse(lblPropina.Text);
                double Impuesto = double.Parse(lblImpuesto.Text);
                double Descuento = double.Parse(lblDescuento.Text);
                double MontoTotal = double.Parse(lblTotalPago.Text);
                string Metodo = cboxMetodo.Text;
                string UsuarioSistema = txtUsuarioSistema.Text;
                DateTime fechaP = datePago.Value;
                DateTime fechaS = dateSistema.Value;
                //ESTO ES LO MISMO QUE EN EL BOTON AGREGAR

                try
                {
                    //se llama al metodo de ACTUALIZAR empleado en la clase CD
                    cd_pagos.MtdActualizarPago(CodigoPago, CodigoReserva, Monto, Propina, Impuesto, Descuento, MontoTotal, fechaP, Metodo, UsuarioSistema, fechaS);
                    MessageBox.Show("Datos actualizados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarPago(); //esto recarga la dgv para ver los cambios
                    mtdLimpiarCampos(); //limpia los datos que hemos actualizado
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void txtCodigoReserva_TextChanged(object sender, EventArgs e)
        {
            //mandar a traer el salario del empleado
            MtdDatosReservacion();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            //Este metodo lo tengo que crear antes, llamo al metodo consultar
            //desde la clase CD
            MtdConsultarPago();
            mtdLimpiarCampos();
        }

        private void dgvPagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvPagos.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvPagos.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCodigoPago.Text = dgvPagos.SelectedCells[0].Value.ToString();
                txtCodigoReserva.Text = dgvPagos.SelectedCells[1].Value.ToString();
                lblMonto.Text = dgvPagos.SelectedCells[2].Value.ToString();
                lblPropina.Text = dgvPagos.SelectedCells[3].Value.ToString();
                lblImpuesto.Text = dgvPagos.SelectedCells[4].Value.ToString();
                lblDescuento.Text = dgvPagos.SelectedCells[5].Value.ToString();
                lblTotalPago.Text = dgvPagos.SelectedCells[6].Value.ToString();
                datePago.Value = DateTime.Parse(dgvPagos.SelectedCells[7].Value.ToString());
                cboxMetodo.Text = dgvPagos.SelectedCells[8].Value.ToString();
                txtUsuarioSistema.Text = dgvPagos.SelectedCells[9].Value.ToString();
                dateSistema.Value = DateTime.Parse(dgvPagos.SelectedCells[10].Value.ToString());
            }
        }
    }
}
