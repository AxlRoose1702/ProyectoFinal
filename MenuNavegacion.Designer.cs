namespace ProyectoFinal
{
    partial class MenuNavegacion
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
            this.btnMenuUsuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuUsuario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMenuUsuario);
            this.groupBox1.Controls.Add(this.btnMenuUsuarios);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(582, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnMenuUsuarios
            // 
            this.btnMenuUsuarios.BackColor = System.Drawing.SystemColors.Info;
            this.btnMenuUsuarios.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUsuarios.Location = new System.Drawing.Point(4, 58);
            this.btnMenuUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuUsuarios.Name = "btnMenuUsuarios";
            this.btnMenuUsuarios.Size = new System.Drawing.Size(98, 54);
            this.btnMenuUsuarios.TabIndex = 2;
            this.btnMenuUsuarios.Text = "Modulo Empleado";
            this.btnMenuUsuarios.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU DE NAVEGACION";
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.btnMenuUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUsuario.Location = new System.Drawing.Point(117, 58);
            this.btnMenuUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Size = new System.Drawing.Size(98, 54);
            this.btnMenuUsuario.TabIndex = 2;
            this.btnMenuUsuario.Text = "Modulo Usuario";
            this.btnMenuUsuario.UseVisualStyleBackColor = false;
            // 
            // MenuNavegacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuNavegacion";
            this.Text = "MenuNavegacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMenuUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuUsuario;
    }
}