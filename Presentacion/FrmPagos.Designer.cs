namespace ProyectoFinal.Presentacion
{
    partial class FrmPagos
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
            this.datePago = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPropina = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCodigoReserva = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateSistema = new System.Windows.Forms.DateTimePicker();
            this.txtUsuarioSistema = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.Controls.Add(this.datePago);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTotalPago);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblDescuento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblImpuesto);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblPropina);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboxTipo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCodigoReserva);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateSistema);
            this.groupBox1.Controls.Add(this.txtUsuarioSistema);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvEmpleados);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 572);
            this.groupBox1.TabIndex = 23;
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
            this.btnInicio.Location = new System.Drawing.Point(858, 164);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(103, 54);
            this.btnInicio.TabIndex = 80;
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
            this.btnCancel.Location = new System.Drawing.Point(858, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 54);
            this.btnCancel.TabIndex = 79;
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
            this.btnEditar.Location = new System.Drawing.Point(758, 103);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 54);
            this.btnEditar.TabIndex = 78;
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
            this.btnEliminar.Location = new System.Drawing.Point(858, 44);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 54);
            this.btnEliminar.TabIndex = 77;
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
            this.btnAgregar.Location = new System.Drawing.Point(758, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 54);
            this.btnAgregar.TabIndex = 76;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // datePago
            // 
            this.datePago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePago.Location = new System.Drawing.Point(249, 226);
            this.datePago.Name = "datePago";
            this.datePago.Size = new System.Drawing.Size(100, 20);
            this.datePago.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Fecha Pago";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.Location = new System.Drawing.Point(607, 189);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(80, 20);
            this.lblTotalPago.TabIndex = 73;
            this.lblTotalPago.Text = "total pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(426, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 72;
            this.label11.Text = "Total Pago";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(245, 189);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(84, 20);
            this.lblDescuento.TabIndex = 71;
            this.lblDescuento.Text = "descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Descuento";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.Location = new System.Drawing.Point(245, 152);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(74, 20);
            this.lblImpuesto.TabIndex = 69;
            this.lblImpuesto.Text = "impuesto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(88, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 68;
            this.label12.Text = "Impuesto";
            // 
            // lblPropina
            // 
            this.lblPropina.AutoSize = true;
            this.lblPropina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropina.Location = new System.Drawing.Point(245, 116);
            this.lblPropina.Name = "lblPropina";
            this.lblPropina.Size = new System.Drawing.Size(62, 20);
            this.lblPropina.TabIndex = 67;
            this.lblPropina.Text = "propina";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 66;
            this.label10.Text = "Propina";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(245, 80);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(54, 20);
            this.lblMonto.TabIndex = 65;
            this.lblMonto.Text = "monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Monto";
            // 
            // cboxTipo
            // 
            this.cboxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Items.AddRange(new object[] {
            "Ocasional",
            "Frecuente",
            "Evento",
            "Vacaciones",
            "Vip"});
            this.cboxTipo.Location = new System.Drawing.Point(611, 152);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(100, 26);
            this.cboxTipo.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Tipo";
            // 
            // lblCodigoReserva
            // 
            this.lblCodigoReserva.AutoSize = true;
            this.lblCodigoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoReserva.Location = new System.Drawing.Point(245, 44);
            this.lblCodigoReserva.Name = "lblCodigoReserva";
            this.lblCodigoReserva.Size = new System.Drawing.Size(112, 20);
            this.lblCodigoReserva.TabIndex = 49;
            this.lblCodigoReserva.Text = "codigo reserva";
            // 
            // cboxEstado
            // 
            this.cboxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Transferencia"});
            this.cboxEstado.Location = new System.Drawing.Point(610, 80);
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
            this.label9.Text = "CRUD HUESPEDES";
            // 
            // dateSistema
            // 
            this.dateSistema.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSistema.Location = new System.Drawing.Point(610, 116);
            this.dateSistema.Name = "dateSistema";
            this.dateSistema.Size = new System.Drawing.Size(100, 20);
            this.dateSistema.TabIndex = 33;
            // 
            // txtUsuarioSistema
            // 
            this.txtUsuarioSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioSistema.Location = new System.Drawing.Point(611, 44);
            this.txtUsuarioSistema.Name = "txtUsuarioSistema";
            this.txtUsuarioSistema.Size = new System.Drawing.Size(100, 26);
            this.txtUsuarioSistema.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(426, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Usuario Sistema";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha Sistema";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Metodo Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo Reserva";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(36, 265);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(935, 289);
            this.dgvEmpleados.TabIndex = 17;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 600);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPagos";
            this.Text = "FrmPagos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPropina;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCodigoReserva;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateSistema;
        private System.Windows.Forms.TextBox txtUsuarioSistema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePago;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnAgregar;
    }
}