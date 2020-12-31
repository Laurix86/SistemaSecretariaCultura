namespace SecretariaDeCultura
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevArtista = new System.Windows.Forms.Button();
            this.btnNuevaObra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNuevoPrestamo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNuevoCentro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnNuevArtista);
            this.panel1.Controls.Add(this.btnNuevaObra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 223);
            this.panel1.TabIndex = 0;
            // 
            // btnNuevArtista
            // 
            this.btnNuevArtista.Location = new System.Drawing.Point(309, 105);
            this.btnNuevArtista.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevArtista.Name = "btnNuevArtista";
            this.btnNuevArtista.Size = new System.Drawing.Size(144, 41);
            this.btnNuevArtista.TabIndex = 7;
            this.btnNuevArtista.Text = "NUEVO ARTISTA";
            this.btnNuevArtista.UseVisualStyleBackColor = true;
            this.btnNuevArtista.Click += new System.EventHandler(this.btnNuevArtista_Click);
            // 
            // btnNuevaObra
            // 
            this.btnNuevaObra.Location = new System.Drawing.Point(67, 105);
            this.btnNuevaObra.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaObra.Name = "btnNuevaObra";
            this.btnNuevaObra.Size = new System.Drawing.Size(144, 41);
            this.btnNuevaObra.TabIndex = 3;
            this.btnNuevaObra.Text = "NUEVA OBRA";
            this.btnNuevaObra.UseVisualStyleBackColor = true;
            this.btnNuevaObra.Click += new System.EventHandler(this.btnNuevaObra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "OBRAS y ARTISTAS";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnNuevoPrestamo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(355, 266);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 201);
            this.panel3.TabIndex = 1;
            // 
            // btnNuevoPrestamo
            // 
            this.btnNuevoPrestamo.Location = new System.Drawing.Point(67, 75);
            this.btnNuevoPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            this.btnNuevoPrestamo.Size = new System.Drawing.Size(144, 46);
            this.btnNuevoPrestamo.TabIndex = 7;
            this.btnNuevoPrestamo.Text = "NUEVO PRESTAMO";
            this.btnNuevoPrestamo.UseVisualStyleBackColor = true;
            this.btnNuevoPrestamo.Click += new System.EventHandler(this.btnNuevoPrestamo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRESTAMO";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnNuevoCentro);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(16, 266);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 201);
            this.panel4.TabIndex = 1;
            // 
            // btnNuevoCentro
            // 
            this.btnNuevoCentro.Location = new System.Drawing.Point(104, 75);
            this.btnNuevoCentro.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoCentro.Name = "btnNuevoCentro";
            this.btnNuevoCentro.Size = new System.Drawing.Size(144, 41);
            this.btnNuevoCentro.TabIndex = 7;
            this.btnNuevoCentro.Text = "NUEVO CENTRO";
            this.btnNuevoCentro.UseVisualStyleBackColor = true;
            this.btnNuevoCentro.Click += new System.EventHandler(this.btnNuevoCentro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "CENTROS CULTURALES";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(499, 519);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 41);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(312, 519);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(118, 41);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "CONSULTAS";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 609);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInicio";
            this.Text = "Secretaría de Cultura - Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevaObra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNuevoCentro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevArtista;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultas;
    }
}

