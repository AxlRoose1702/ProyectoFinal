namespace ProyectoFinal.Presentacion
{
    partial class FrmAsignaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.cboxTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.lblCodigoAsignacion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.lblCodigoHabitacion = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateFechaSistema = new System.Windows.Forms.DateTimePicker();
            this.dateFechaAsignacion = new System.Windows.Forms.DateTimePicker();
            this.txtUsuarioSistema = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.codigoasignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigohabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoasignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaasignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechasistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInicio);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.cboxTipoHabitacion);
            this.groupBox1.Controls.Add(this.lblCodigoAsignacion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblCodigoEmpleado);
            this.groupBox1.Controls.Add(this.lblCodigoHabitacion);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateFechaSistema);
            this.groupBox1.Controls.Add(this.dateFechaAsignacion);
            this.groupBox1.Controls.Add(this.txtUsuarioSistema);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvEmpleados);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 572);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.AutoSize = true;
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.btnInicio.IconColor = System.Drawing.Color.Black;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(877, 145);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(103, 54);
            this.btnInicio.TabIndex = 71;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.PersonCircleExclamation;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(877, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 54);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.PersonCircleQuestion;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(777, 84);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 54);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.PersonCircleXmark;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(877, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 54);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(777, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 54);
            this.btnAgregar.TabIndex = 67;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cboxTipoHabitacion
            // 
            this.cboxTipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipoHabitacion.FormattingEnabled = true;
            this.cboxTipoHabitacion.Items.AddRange(new object[] {
            "Recepcion",
            "Limpieza",
            "Alimentos",
            "Administrativo",
            "Mantenimiento"});
            this.cboxTipoHabitacion.Location = new System.Drawing.Point(264, 128);
            this.cboxTipoHabitacion.Name = "cboxTipoHabitacion";
            this.cboxTipoHabitacion.Size = new System.Drawing.Size(100, 26);
            this.cboxTipoHabitacion.TabIndex = 50;
            // 
            // lblCodigoAsignacion
            // 
            this.lblCodigoAsignacion.AutoSize = true;
            this.lblCodigoAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAsignacion.Location = new System.Drawing.Point(262, 24);
            this.lblCodigoAsignacion.Name = "lblCodigoAsignacion";
            this.lblCodigoAsignacion.Size = new System.Drawing.Size(136, 20);
            this.lblCodigoAsignacion.TabIndex = 49;
            this.lblCodigoAsignacion.Text = "codigo asignacion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(106, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "Tipo Asignacion";
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(260, 59);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(130, 20);
            this.lblCodigoEmpleado.TabIndex = 42;
            this.lblCodigoEmpleado.Text = "codigo empleado";
            // 
            // lblCodigoHabitacion
            // 
            this.lblCodigoHabitacion.AutoSize = true;
            this.lblCodigoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoHabitacion.Location = new System.Drawing.Point(261, 93);
            this.lblCodigoHabitacion.Name = "lblCodigoHabitacion";
            this.lblCodigoHabitacion.Size = new System.Drawing.Size(150, 20);
            this.lblCodigoHabitacion.TabIndex = 41;
            this.lblCodigoHabitacion.Text = "codigo habitaciones";
            // 
            // cboxEstado
            // 
            this.cboxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Creada",
            "Pendiente",
            "Progreso",
            "Completa",
            "Cancelada"});
            this.cboxEstado.Location = new System.Drawing.Point(627, 60);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(100, 26);
            this.cboxEstado.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(398, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "CRUD ASIGNACION";
            // 
            // dateFechaSistema
            // 
            this.dateFechaSistema.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaSistema.Location = new System.Drawing.Point(628, 122);
            this.dateFechaSistema.Name = "dateFechaSistema";
            this.dateFechaSistema.Size = new System.Drawing.Size(100, 20);
            this.dateFechaSistema.TabIndex = 33;
            // 
            // dateFechaAsignacion
            // 
            this.dateFechaAsignacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaAsignacion.Location = new System.Drawing.Point(628, 93);
            this.dateFechaAsignacion.Name = "dateFechaAsignacion";
            this.dateFechaAsignacion.Size = new System.Drawing.Size(100, 20);
            this.dateFechaAsignacion.TabIndex = 32;
            // 
            // txtUsuarioSistema
            // 
            this.txtUsuarioSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioSistema.Location = new System.Drawing.Point(628, 24);
            this.txtUsuarioSistema.Name = "txtUsuarioSistema";
            this.txtUsuarioSistema.Size = new System.Drawing.Size(100, 26);
            this.txtUsuarioSistema.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Usuario Sistema";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha Sistema";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha Asignacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Codigo Habitacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Codigo Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo Asignacion";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoasignacion,
            this.codigoempleado,
            this.codigohabitacion,
            this.tipoasignacion,
            this.usuariosistema,
            this.estado,
            this.fechaasignacion,
            this.fechasistema});
            this.dgvEmpleados.Location = new System.Drawing.Point(108, 266);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(832, 289);
            this.dgvEmpleados.TabIndex = 17;
            // 
            // codigoasignacion
            // 
            this.codigoasignacion.HeaderText = "Codigo Asignacion";
            this.codigoasignacion.Name = "codigoasignacion";
            this.codigoasignacion.Width = 110;
            // 
            // codigoempleado
            // 
            this.codigoempleado.HeaderText = "Codigo Empleado";
            this.codigoempleado.Name = "codigoempleado";
            this.codigoempleado.Width = 106;
            // 
            // codigohabitacion
            // 
            this.codigohabitacion.HeaderText = "Codigo Habitacion";
            this.codigohabitacion.Name = "codigohabitacion";
            this.codigohabitacion.Width = 109;
            // 
            // tipoasignacion
            // 
            this.tipoasignacion.HeaderText = "Tipo Asignacion";
            this.tipoasignacion.Name = "tipoasignacion";
            this.tipoasignacion.Width = 99;
            // 
            // usuariosistema
            // 
            this.usuariosistema.HeaderText = "Usuario Sistema";
            this.usuariosistema.Name = "usuariosistema";
            this.usuariosistema.Width = 99;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.Width = 65;
            // 
            // fechaasignacion
            // 
            this.fechaasignacion.HeaderText = "Fecha Asignacion";
            this.fechaasignacion.Name = "fechaasignacion";
            this.fechaasignacion.Width = 107;
            // 
            // fechasistema
            // 
            this.fechasistema.HeaderText = "Fecha Sistema";
            this.fechasistema.Name = "fechasistema";
            this.fechasistema.Width = 94;
            // 
            // FrmAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 589);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAsignaciones";
            this.Text = "FrmAsignaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCodigoAsignacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private System.Windows.Forms.Label lblCodigoHabitacion;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateFechaSistema;
        private System.Windows.Forms.DateTimePicker dateFechaAsignacion;
        private System.Windows.Forms.TextBox txtUsuarioSistema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.ComboBox cboxTipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoasignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigohabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoasignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariosistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaasignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasistema;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnAgregar;
    }
}