namespace CapaPresentacion.Presentacion
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.lblMensajeBienvenida = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnAsignaciones = new FontAwesome.Sharp.IconButton();
            this.btnConsumos = new FontAwesome.Sharp.IconButton();
            this.btnHabitaciones = new FontAwesome.Sharp.IconButton();
            this.btnHuespedes = new FontAwesome.Sharp.IconButton();
            this.btnPagoPlanillas = new FontAwesome.Sharp.IconButton();
            this.btnPagos = new FontAwesome.Sharp.IconButton();
            this.btnReservaciones = new FontAwesome.Sharp.IconButton();
            this.btnServicios = new FontAwesome.Sharp.IconButton();
            this.PanelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelContenedor.Controls.Add(this.panelFormularios);
            this.PanelContenedor.Controls.Add(this.panelMenu);
            this.PanelContenedor.Controls.Add(this.panelBarraTitulo);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1250, 663);
            this.PanelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelFormularios.Controls.Add(this.lblMensajeBienvenida);
            this.panelFormularios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(198, 40);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1052, 623);
            this.panelFormularios.TabIndex = 2;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint);
            // 
            // lblMensajeBienvenida
            // 
            this.lblMensajeBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensajeBienvenida.AutoSize = true;
            this.lblMensajeBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeBienvenida.Location = new System.Drawing.Point(476, 287);
            this.lblMensajeBienvenida.Name = "lblMensajeBienvenida";
            this.lblMensajeBienvenida.Size = new System.Drawing.Size(180, 24);
            this.lblMensajeBienvenida.TabIndex = 0;
            this.lblMensajeBienvenida.Text = "PAGINA PRINCIPAL";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnServicios);
            this.panelMenu.Controls.Add(this.btnReservaciones);
            this.panelMenu.Controls.Add(this.btnPagos);
            this.panelMenu.Controls.Add(this.btnPagoPlanillas);
            this.panelMenu.Controls.Add(this.btnHuespedes);
            this.panelMenu.Controls.Add(this.btnHabitaciones);
            this.panelMenu.Controls.Add(this.btnConsumos);
            this.panelMenu.Controls.Add(this.btnAsignaciones);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.PanelLogin);
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(198, 623);
            this.panelMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 72);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(61, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cerrar sesion:";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(18, 13);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(38, 41);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.IconSize = 25;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 133);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(185, 40);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // PanelLogin
            // 
            this.PanelLogin.Controls.Add(this.panel2);
            this.PanelLogin.Controls.Add(this.lblEstado);
            this.PanelLogin.Controls.Add(this.lblRol);
            this.PanelLogin.Controls.Add(this.lblUsuario);
            this.PanelLogin.Controls.Add(this.label3);
            this.PanelLogin.Controls.Add(this.label2);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.pictureBox1);
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogin.Location = new System.Drawing.Point(0, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(198, 77);
            this.PanelLogin.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(4, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 1);
            this.panel2.TabIndex = 8;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Teal;
            this.lblEstado.Location = new System.Drawing.Point(122, 52);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(11, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = ".";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.Teal;
            this.lblRol.Location = new System.Drawing.Point(122, 34);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(11, 13);
            this.lblRol.TabIndex = 5;
            this.lblRol.Text = ".";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Teal;
            this.lblUsuario.Location = new System.Drawing.Point(122, 19);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(11, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(58, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(58, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rol:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 25;
            this.btnEmpleados.Location = new System.Drawing.Point(3, 87);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(185, 40);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1250, 40);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1164, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1192, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1192, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1218, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAsignaciones
            // 
            this.btnAsignaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignaciones.FlatAppearance.BorderSize = 0;
            this.btnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAsignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignaciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAsignaciones.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnAsignaciones.IconColor = System.Drawing.Color.White;
            this.btnAsignaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignaciones.IconSize = 25;
            this.btnAsignaciones.Location = new System.Drawing.Point(3, 179);
            this.btnAsignaciones.Name = "btnAsignaciones";
            this.btnAsignaciones.Size = new System.Drawing.Size(185, 40);
            this.btnAsignaciones.TabIndex = 2;
            this.btnAsignaciones.Text = "Asignaciones";
            this.btnAsignaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAsignaciones.UseVisualStyleBackColor = true;
            this.btnAsignaciones.Click += new System.EventHandler(this.btnAsignaciones_Click);
            // 
            // btnConsumos
            // 
            this.btnConsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsumos.FlatAppearance.BorderSize = 0;
            this.btnConsumos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsumos.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.btnConsumos.IconColor = System.Drawing.Color.White;
            this.btnConsumos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsumos.IconSize = 25;
            this.btnConsumos.Location = new System.Drawing.Point(3, 225);
            this.btnConsumos.Name = "btnConsumos";
            this.btnConsumos.Size = new System.Drawing.Size(185, 40);
            this.btnConsumos.TabIndex = 2;
            this.btnConsumos.Text = "Consumos";
            this.btnConsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsumos.UseVisualStyleBackColor = true;
            this.btnConsumos.Click += new System.EventHandler(this.btnConsumos_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitaciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHabitaciones.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.btnHabitaciones.IconColor = System.Drawing.Color.White;
            this.btnHabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHabitaciones.IconSize = 25;
            this.btnHabitaciones.Location = new System.Drawing.Point(3, 271);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(185, 40);
            this.btnHabitaciones.TabIndex = 2;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHabitaciones.UseVisualStyleBackColor = true;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnHuespedes
            // 
            this.btnHuespedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuespedes.FlatAppearance.BorderSize = 0;
            this.btnHuespedes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuespedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuespedes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHuespedes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnHuespedes.IconColor = System.Drawing.Color.White;
            this.btnHuespedes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuespedes.IconSize = 25;
            this.btnHuespedes.Location = new System.Drawing.Point(3, 317);
            this.btnHuespedes.Name = "btnHuespedes";
            this.btnHuespedes.Size = new System.Drawing.Size(185, 40);
            this.btnHuespedes.TabIndex = 2;
            this.btnHuespedes.Text = "Huespedes";
            this.btnHuespedes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuespedes.UseVisualStyleBackColor = true;
            this.btnHuespedes.Click += new System.EventHandler(this.btnHuespedes_Click);
            // 
            // btnPagoPlanillas
            // 
            this.btnPagoPlanillas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagoPlanillas.FlatAppearance.BorderSize = 0;
            this.btnPagoPlanillas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagoPlanillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoPlanillas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPagoPlanillas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnPagoPlanillas.IconColor = System.Drawing.Color.White;
            this.btnPagoPlanillas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagoPlanillas.IconSize = 25;
            this.btnPagoPlanillas.Location = new System.Drawing.Point(3, 363);
            this.btnPagoPlanillas.Name = "btnPagoPlanillas";
            this.btnPagoPlanillas.Size = new System.Drawing.Size(185, 40);
            this.btnPagoPlanillas.TabIndex = 2;
            this.btnPagoPlanillas.Text = "Pago de Planillas";
            this.btnPagoPlanillas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagoPlanillas.UseVisualStyleBackColor = true;
            this.btnPagoPlanillas.Click += new System.EventHandler(this.btnPagoPlanillas_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPagos.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnPagos.IconColor = System.Drawing.Color.White;
            this.btnPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagos.IconSize = 25;
            this.btnPagos.Location = new System.Drawing.Point(3, 409);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(185, 40);
            this.btnPagos.TabIndex = 2;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservaciones.FlatAppearance.BorderSize = 0;
            this.btnReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReservaciones.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnReservaciones.IconColor = System.Drawing.Color.White;
            this.btnReservaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReservaciones.IconSize = 25;
            this.btnReservaciones.Location = new System.Drawing.Point(3, 455);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Size = new System.Drawing.Size(185, 40);
            this.btnReservaciones.TabIndex = 2;
            this.btnReservaciones.Text = "Reservaciones";
            this.btnReservaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservaciones.UseVisualStyleBackColor = true;
            this.btnReservaciones.Click += new System.EventHandler(this.btnReservaciones_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnServicios.IconChar = FontAwesome.Sharp.IconChar.Spa;
            this.btnServicios.IconColor = System.Drawing.Color.White;
            this.btnServicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServicios.IconSize = 25;
            this.btnServicios.Location = new System.Drawing.Point(4, 501);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(185, 40);
            this.btnServicios.TabIndex = 2;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 663);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Label lblMensajeBienvenida;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAsignaciones;
        private FontAwesome.Sharp.IconButton btnConsumos;
        private FontAwesome.Sharp.IconButton btnHabitaciones;
        private FontAwesome.Sharp.IconButton btnHuespedes;
        private FontAwesome.Sharp.IconButton btnPagoPlanillas;
        private FontAwesome.Sharp.IconButton btnPagos;
        private FontAwesome.Sharp.IconButton btnReservaciones;
        private FontAwesome.Sharp.IconButton btnServicios;
    }
}