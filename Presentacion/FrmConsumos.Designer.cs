namespace ProyectoFinal.Presentacion
{
    partial class FrmConsumos
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
            this.cboxCodigoReserva = new System.Windows.Forms.ComboBox();
            this.cboxCodigoServicio = new System.Windows.Forms.ComboBox();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateConsumo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCodigoConsumo = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateSistema = new System.Windows.Forms.DateTimePicker();
            this.txtUsuarioSistema = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsumos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxCodigoReserva);
            this.groupBox1.Controls.Add(this.cboxCodigoServicio);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dateConsumo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblCodigoConsumo);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateSistema);
            this.groupBox1.Controls.Add(this.txtUsuarioSistema);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvConsumos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 572);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // cboxCodigoReserva
            // 
            this.cboxCodigoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCodigoReserva.FormattingEnabled = true;
            this.cboxCodigoReserva.Location = new System.Drawing.Point(266, 53);
            this.cboxCodigoReserva.Name = "cboxCodigoReserva";
            this.cboxCodigoReserva.Size = new System.Drawing.Size(100, 26);
            this.cboxCodigoReserva.TabIndex = 78;
            // 
            // cboxCodigoServicio
            // 
            this.cboxCodigoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCodigoServicio.FormattingEnabled = true;
            this.cboxCodigoServicio.Location = new System.Drawing.Point(266, 95);
            this.cboxCodigoServicio.Name = "cboxCodigoServicio";
            this.cboxCodigoServicio.Size = new System.Drawing.Size(100, 26);
            this.cboxCodigoServicio.TabIndex = 77;
            this.cboxCodigoServicio.SelectedIndexChanged += new System.EventHandler(this.cboxCodigoServicio_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.PersonCircleExclamation;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(860, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 54);
            this.btnCancel.TabIndex = 75;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.PersonCircleQuestion;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(760, 83);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 54);
            this.btnEditar.TabIndex = 74;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.PersonCircleXmark;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(860, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 54);
            this.btnEliminar.TabIndex = 73;
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
            this.btnAgregar.Location = new System.Drawing.Point(760, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 54);
            this.btnAgregar.TabIndex = 72;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(260, 134);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(54, 20);
            this.lblMonto.TabIndex = 56;
            this.lblMonto.Text = "monto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(105, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "Monto";
            // 
            // dateConsumo
            // 
            this.dateConsumo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateConsumo.Location = new System.Drawing.Point(627, 134);
            this.dateConsumo.Name = "dateConsumo";
            this.dateConsumo.Size = new System.Drawing.Size(100, 20);
            this.dateConsumo.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(443, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 20);
            this.label10.TabIndex = 53;
            this.label10.Text = "Fecha Consumo";
            // 
            // lblCodigoConsumo
            // 
            this.lblCodigoConsumo.AutoSize = true;
            this.lblCodigoConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoConsumo.Location = new System.Drawing.Point(262, 24);
            this.lblCodigoConsumo.Name = "lblCodigoConsumo";
            this.lblCodigoConsumo.Size = new System.Drawing.Size(125, 20);
            this.lblCodigoConsumo.TabIndex = 49;
            this.lblCodigoConsumo.Text = "codigo consumo";
            // 
            // cboxEstado
            // 
            this.cboxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Solicitado",
            "Progreso",
            "Finalizado",
            "Cancelado",
            "Facturado"});
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
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "CRUD CONSUMOS";
            // 
            // dateSistema
            // 
            this.dateSistema.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSistema.Location = new System.Drawing.Point(627, 96);
            this.dateSistema.Name = "dateSistema";
            this.dateSistema.Size = new System.Drawing.Size(100, 20);
            this.dateSistema.TabIndex = 33;
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
            this.label7.Location = new System.Drawing.Point(442, 97);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Codigo Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Codigo Reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo Consumo";
            // 
            // dgvConsumos
            // 
            this.dgvConsumos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumos.Location = new System.Drawing.Point(108, 266);
            this.dgvConsumos.Name = "dgvConsumos";
            this.dgvConsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsumos.Size = new System.Drawing.Size(823, 289);
            this.dgvConsumos.TabIndex = 17;
            this.dgvConsumos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumos_CellClick);
            // 
            // FrmConsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 590);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsumos";
            this.Text = "FrmConsumos";
            this.Load += new System.EventHandler(this.FrmConsumos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateConsumo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCodigoConsumo;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateSistema;
        private System.Windows.Forms.TextBox txtUsuarioSistema;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConsumos;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.ComboBox cboxCodigoReserva;
        private System.Windows.Forms.ComboBox cboxCodigoServicio;
    }
}