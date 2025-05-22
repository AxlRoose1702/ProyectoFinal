using System;
using System.Data;
using System.Windows.Forms;
using ProyectoFinal.Datos;
using ProyectoFinal.Logica;

namespace ProyectoFinal
{
    public partial class FrmUsuarios : Form
    {
        CLProcesos proces = new CLProcesos();
        CLUsuarios cl_usuarios = new CLUsuarios();
        CDUsuarios cd_usuarios = new CDUsuarios();

        //metodo para consultar usuarios, este se llama siempre al abrir la ventana
        private void MtdConsultarUsuarios()
        {
            //se crea la tabla temporal  y se consulta la tabla usuarios
            // se hace llamado a través del CD y al metodo Consultar 
            DataTable Dt = cd_usuarios.MtdConsultarUsuarios();
            dgvUsuarios.DataSource = Dt;
        }
        //Este metodo llama a todos los empleados que existen
        //en la tabla empleados y los agrega al combobox
        private void MtdMostrarListaEmpleados()
        {
            var ListaEmpleados = cd_usuarios.MtdListaEmpleados();

            foreach (var Empleados in ListaEmpleados)
            {
                cboxCodigoEmpleado.Items.Add(Empleados);
            }

            cboxCodigoEmpleado.DisplayMember = "Text";
            cboxCodigoEmpleado.ValueMember = "Value";
        }

        public void mtdLimpiarCampos()
        {//metodo para limpiar los campos
            txtCodigoUsuario.Clear();
            txtNombreUsuario.Clear();
            txtPassword.Clear();
            txtUsuarioSistema.Clear();
            cboxEstado.Text = "Seleccionar";
            cboxRol.Text = "Seleccionar";
            cboxCodigoEmpleado.Text = "Seleccionar";
            //LOS CBOX DEBEN IR CON "Seleccionar"
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
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {//Un pequeño desliz de dedo :)
         }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmMenuNavegacion nav = new FrmMenuNavegacion();
            nav.Show();
        }

        //AQUI ESTÁ EL LOAD
        private void Usuarios_Load(object sender, EventArgs e)
        {
            //Este metodo lo tengo que crear antes, llamo al metodo consultar
            //desde la clase CD
            MtdConsultarUsuarios();
            mtdLimpiarCampos();
            MtdMostrarListaEmpleados();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtUsuarioSistema.Text)
             || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Favor completar NombreUsuario, UsuarioSistema y Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cboxRol.Text) || cboxRol.Text == "Seleccionar"
                 || string.IsNullOrEmpty(cboxEstado.Text) || cboxEstado.Text == "Seleccionar"
                 || string.IsNullOrEmpty(cboxCodigoEmpleado.Text) || cboxCodigoEmpleado.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de Rol, Estado y CodigoEmpleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Declaracion de todas las variables con todos los objetos del form
                // int codigoUsuario = int.Parse(txtCodigoUsuario.Text);
                int codigoEmpleado = (int)((dynamic)cboxCodigoEmpleado.SelectedItem).Value;
                string nombreUsuario = txtNombreUsuario.Text;
                string contrasena = txtPassword.Text;
                string rol = cboxRol.Text;
                string estado = cboxEstado.Text;
                string usuarioSistema = txtUsuarioSistema.Text;
                DateTime fechaS = dateFechaSistema.Value;

                try
                {
                    if (cd_usuarios.MtdVerificarUsuario(nombreUsuario) == 1702)
                    {
                        MessageBox.Show("Por Favor Ingresar diferente NombreUsuario", "NO PERMITIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }else if (cd_usuarios.MtdVerificarEmpleado(codigoEmpleado) == 1702)
                    {
                        MessageBox.Show("Solo puede haber 1 Usuario por cada Empleado", "NO PERMITIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //se llama al metodo de agregar empleado en la clase CD
                    cd_usuarios.MtdAgregarUsuarios(codigoEmpleado, nombreUsuario, contrasena, rol, estado, usuarioSistema, fechaS);
                    MessageBox.Show("Datos agregados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuarios();
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
            //las condiciones if-else se repiten en el boton agregar y editar, pero no se pueden poner en un metodo
            if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtUsuarioSistema.Text)
            || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Favor completar NombreUsuario, UsuarioSistema y Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cboxRol.Text) || cboxRol.Text == "Seleccionar"
                 || string.IsNullOrEmpty(cboxEstado.Text) || cboxEstado.Text == "Seleccionar")
            {
                MessageBox.Show("Favor seleccionar una opción de Rol y Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Declaracion de todas las variables con todos los objetos del form
                int codigoUsuario = int.Parse(txtCodigoUsuario.Text);
                int codigoEmpleado = (int)((dynamic)cboxCodigoEmpleado.SelectedItem).Value;
                string nombreUsuario = txtNombreUsuario.Text;
                string contrasena = txtPassword.Text;
                string rol = cboxRol.Text;
                string estado = cboxEstado.Text;
                string usuarioSistema = txtUsuarioSistema.Text;
                DateTime fechaS = dateFechaSistema.Value;
                //ESTO ES LO MISMO QUE EN EL BOTON AGREGAR

                try
                {
                    if (cd_usuarios.MtdVerificarUsuario(nombreUsuario) == 1702)
                    {
                        MessageBox.Show("Por Favor Ingresar diferente NombreUsuario", "NO PERMITIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (cd_usuarios.MtdVerificarEmpleado(codigoEmpleado) == 1702)
                    {
                        MessageBox.Show("Solo puede haber 1 Usuario por cada Empleado", "NO PERMITIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //se llama al metodo de ACTUALIZAR empleado en la clase CD
                    cd_usuarios.MtdActualizarUsuarios(codigoEmpleado, nombreUsuario, contrasena, rol, estado, usuarioSistema, fechaS);
                    MessageBox.Show("Datos actualizados correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuarios(); //esto recarga la dgv para ver los cambios
                    mtdLimpiarCampos(); //limpia los datos que hemos actualizado
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilaSeleccionada = dgvUsuarios.SelectedRows[0];

            if (FilaSeleccionada.Index == dgvUsuarios.RowCount - 1)
            {
                MessageBox.Show("Seleccione una fila con datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                txtCodigoUsuario.Text = dgvUsuarios.SelectedCells[0].Value.ToString();
                //cboxCodigoEmpleado.Text = dgvUsuarios.SelectedCells[1].Value.ToString();
                int codigoEmpleado = (int)dgvUsuarios.SelectedCells[1].Value;
                foreach (var codigoEmp in cboxCodigoEmpleado.Items)
                {
                    if (((dynamic)codigoEmp).Value == codigoEmpleado)
                    {
                        cboxCodigoEmpleado.SelectedItem = codigoEmp;
                        //break;
                    }
                }
                txtNombreUsuario.Text = dgvUsuarios.SelectedCells[2].Value.ToString();
                txtPassword.Text = dgvUsuarios.SelectedCells[3].Value.ToString();
                cboxRol.Text = dgvUsuarios.SelectedCells[4].Value.ToString();
                cboxEstado.Text = dgvUsuarios.SelectedCells[5].Value.ToString();
                txtUsuarioSistema.Text = dgvUsuarios.SelectedCells[6].Value.ToString();
                dateFechaSistema.Text = dgvUsuarios.SelectedCells[7].Value.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mtdLimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoUsuario.Text))
            {
                MessageBox.Show("Favor seleccionar fila a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int CodigoUsuario = int.Parse(txtCodigoUsuario.Text);

                try
                {
                    cd_usuarios.MtdEliminarUsuarios(CodigoUsuario);
                    MessageBox.Show("Usuario eliminado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarUsuarios();
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
