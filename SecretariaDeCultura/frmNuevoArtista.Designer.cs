namespace SecretariaDeCultura
{
    partial class frmNuevoArtista
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
            this.lblIdArt = new System.Windows.Forms.Label();
            this.lblNombreArtista = new System.Windows.Forms.Label();
            this.lblApellidoArtista = new System.Windows.Forms.Label();
            this.lblNacArtista = new System.Windows.Forms.Label();
            this.lblFNac = new System.Windows.Forms.Label();
            this.lblFFall = new System.Windows.Forms.Label();
            this.txtIdArt = new System.Windows.Forms.TextBox();
            this.txtNombreArtista = new System.Windows.Forms.TextBox();
            this.txtApellidoArtista = new System.Windows.Forms.TextBox();
            this.mkdFNac = new System.Windows.Forms.MaskedTextBox();
            this.mkdFFall = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardarArtista = new System.Windows.Forms.Button();
            this.btnCancelarArtista = new System.Windows.Forms.Button();
            this.lblMsjNombreArt = new System.Windows.Forms.Label();
            this.lblMsjApellidoArt = new System.Windows.Forms.Label();
            this.lblMsjNacArt = new System.Windows.Forms.Label();
            this.lblMsjFNacArt = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.chkFFall = new System.Windows.Forms.CheckBox();
            this.lblMsjFFallArt = new System.Windows.Forms.Label();
            this.lblMsjGuardadoArt = new System.Windows.Forms.Label();
            this.btnLimpiarArtista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdArt
            // 
            this.lblIdArt.AutoSize = true;
            this.lblIdArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdArt.Location = new System.Drawing.Point(17, 55);
            this.lblIdArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdArt.Name = "lblIdArt";
            this.lblIdArt.Size = new System.Drawing.Size(37, 25);
            this.lblIdArt.TabIndex = 0;
            this.lblIdArt.Text = "ID:";
            // 
            // lblNombreArtista
            // 
            this.lblNombreArtista.AutoSize = true;
            this.lblNombreArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArtista.Location = new System.Drawing.Point(17, 106);
            this.lblNombreArtista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreArtista.Name = "lblNombreArtista";
            this.lblNombreArtista.Size = new System.Drawing.Size(87, 25);
            this.lblNombreArtista.TabIndex = 1;
            this.lblNombreArtista.Text = "Nombre:";
            // 
            // lblApellidoArtista
            // 
            this.lblApellidoArtista.AutoSize = true;
            this.lblApellidoArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoArtista.Location = new System.Drawing.Point(17, 172);
            this.lblApellidoArtista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoArtista.Name = "lblApellidoArtista";
            this.lblApellidoArtista.Size = new System.Drawing.Size(82, 25);
            this.lblApellidoArtista.TabIndex = 2;
            this.lblApellidoArtista.Text = "Apellido";
            // 
            // lblNacArtista
            // 
            this.lblNacArtista.AutoSize = true;
            this.lblNacArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacArtista.Location = new System.Drawing.Point(17, 236);
            this.lblNacArtista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNacArtista.Name = "lblNacArtista";
            this.lblNacArtista.Size = new System.Drawing.Size(125, 25);
            this.lblNacArtista.TabIndex = 3;
            this.lblNacArtista.Text = "Nacionalidad";
            // 
            // lblFNac
            // 
            this.lblFNac.AutoSize = true;
            this.lblFNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFNac.Location = new System.Drawing.Point(17, 303);
            this.lblFNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFNac.Name = "lblFNac";
            this.lblFNac.Size = new System.Drawing.Size(169, 25);
            this.lblFNac.TabIndex = 4;
            this.lblFNac.Text = "Fecha Nacimiento";
            // 
            // lblFFall
            // 
            this.lblFFall.AutoSize = true;
            this.lblFFall.Enabled = false;
            this.lblFFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFFall.Location = new System.Drawing.Point(17, 394);
            this.lblFFall.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFFall.Name = "lblFFall";
            this.lblFFall.Size = new System.Drawing.Size(186, 25);
            this.lblFFall.TabIndex = 5;
            this.lblFFall.Text = "Fecha Fallecimiento";
            // 
            // txtIdArt
            // 
            this.txtIdArt.Location = new System.Drawing.Point(144, 50);
            this.txtIdArt.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdArt.Name = "txtIdArt";
            this.txtIdArt.ReadOnly = true;
            this.txtIdArt.Size = new System.Drawing.Size(132, 22);
            this.txtIdArt.TabIndex = 6;
            // 
            // txtNombreArtista
            // 
            this.txtNombreArtista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreArtista.Location = new System.Drawing.Point(144, 106);
            this.txtNombreArtista.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreArtista.Name = "txtNombreArtista";
            this.txtNombreArtista.Size = new System.Drawing.Size(225, 28);
            this.txtNombreArtista.TabIndex = 1;
            // 
            // txtApellidoArtista
            // 
            this.txtApellidoArtista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoArtista.Location = new System.Drawing.Point(144, 172);
            this.txtApellidoArtista.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoArtista.Name = "txtApellidoArtista";
            this.txtApellidoArtista.Size = new System.Drawing.Size(225, 28);
            this.txtApellidoArtista.TabIndex = 2;
            // 
            // mkdFNac
            // 
            this.mkdFNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdFNac.Location = new System.Drawing.Point(252, 303);
            this.mkdFNac.Margin = new System.Windows.Forms.Padding(4);
            this.mkdFNac.Mask = "00/00/0000";
            this.mkdFNac.Name = "mkdFNac";
            this.mkdFNac.Size = new System.Drawing.Size(117, 28);
            this.mkdFNac.TabIndex = 4;
            this.mkdFNac.ValidatingType = typeof(System.DateTime);
            // 
            // mkdFFall
            // 
            this.mkdFFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdFFall.Location = new System.Drawing.Point(252, 391);
            this.mkdFFall.Margin = new System.Windows.Forms.Padding(4);
            this.mkdFFall.Mask = "00/00/0000";
            this.mkdFFall.Name = "mkdFFall";
            this.mkdFFall.Size = new System.Drawing.Size(117, 28);
            this.mkdFFall.TabIndex = 5;
            this.mkdFFall.ValidatingType = typeof(System.DateTime);
            this.mkdFFall.Visible = false;
            // 
            // btnGuardarArtista
            // 
            this.btnGuardarArtista.Location = new System.Drawing.Point(103, 464);
            this.btnGuardarArtista.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarArtista.Name = "btnGuardarArtista";
            this.btnGuardarArtista.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarArtista.TabIndex = 12;
            this.btnGuardarArtista.Text = "GUARDAR";
            this.btnGuardarArtista.UseVisualStyleBackColor = true;
            this.btnGuardarArtista.Click += new System.EventHandler(this.btnGuardarArtista_Click);
            // 
            // btnCancelarArtista
            // 
            this.btnCancelarArtista.Location = new System.Drawing.Point(243, 464);
            this.btnCancelarArtista.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarArtista.Name = "btnCancelarArtista";
            this.btnCancelarArtista.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarArtista.TabIndex = 13;
            this.btnCancelarArtista.Text = "CANCELAR";
            this.btnCancelarArtista.UseVisualStyleBackColor = true;
            this.btnCancelarArtista.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMsjNombreArt
            // 
            this.lblMsjNombreArt.AutoSize = true;
            this.lblMsjNombreArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjNombreArt.ForeColor = System.Drawing.Color.Red;
            this.lblMsjNombreArt.Location = new System.Drawing.Point(383, 106);
            this.lblMsjNombreArt.Name = "lblMsjNombreArt";
            this.lblMsjNombreArt.Size = new System.Drawing.Size(0, 20);
            this.lblMsjNombreArt.TabIndex = 14;
            // 
            // lblMsjApellidoArt
            // 
            this.lblMsjApellidoArt.AutoSize = true;
            this.lblMsjApellidoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjApellidoArt.ForeColor = System.Drawing.Color.Red;
            this.lblMsjApellidoArt.Location = new System.Drawing.Point(383, 172);
            this.lblMsjApellidoArt.Name = "lblMsjApellidoArt";
            this.lblMsjApellidoArt.Size = new System.Drawing.Size(0, 20);
            this.lblMsjApellidoArt.TabIndex = 15;
            // 
            // lblMsjNacArt
            // 
            this.lblMsjNacArt.AutoSize = true;
            this.lblMsjNacArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjNacArt.ForeColor = System.Drawing.Color.Red;
            this.lblMsjNacArt.Location = new System.Drawing.Point(384, 243);
            this.lblMsjNacArt.Name = "lblMsjNacArt";
            this.lblMsjNacArt.Size = new System.Drawing.Size(0, 20);
            this.lblMsjNacArt.TabIndex = 16;
            // 
            // lblMsjFNacArt
            // 
            this.lblMsjFNacArt.AutoSize = true;
            this.lblMsjFNacArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjFNacArt.ForeColor = System.Drawing.Color.Red;
            this.lblMsjFNacArt.Location = new System.Drawing.Point(383, 303);
            this.lblMsjFNacArt.Name = "lblMsjFNacArt";
            this.lblMsjFNacArt.Size = new System.Drawing.Size(0, 20);
            this.lblMsjFNacArt.TabIndex = 17;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNacionalidad.Location = new System.Drawing.Point(144, 236);
            this.txtNacionalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(225, 28);
            this.txtNacionalidad.TabIndex = 3;
            // 
            // chkFFall
            // 
            this.chkFFall.AutoSize = true;
            this.chkFFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFFall.Location = new System.Drawing.Point(22, 351);
            this.chkFFall.Name = "chkFFall";
            this.chkFFall.Size = new System.Drawing.Size(245, 24);
            this.chkFFall.TabIndex = 19;
            this.chkFFall.Text = "Agregar Fecha Fallecimiento";
            this.chkFFall.UseVisualStyleBackColor = true;
            this.chkFFall.CheckedChanged += new System.EventHandler(this.chkFFall_CheckedChanged);
            // 
            // lblMsjFFallArt
            // 
            this.lblMsjFFallArt.AutoSize = true;
            this.lblMsjFFallArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjFFallArt.ForeColor = System.Drawing.Color.Red;
            this.lblMsjFFallArt.Location = new System.Drawing.Point(383, 399);
            this.lblMsjFFallArt.Name = "lblMsjFFallArt";
            this.lblMsjFFallArt.Size = new System.Drawing.Size(0, 20);
            this.lblMsjFFallArt.TabIndex = 20;
            // 
            // lblMsjGuardadoArt
            // 
            this.lblMsjGuardadoArt.AutoSize = true;
            this.lblMsjGuardadoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjGuardadoArt.ForeColor = System.Drawing.Color.Red;
            this.lblMsjGuardadoArt.Location = new System.Drawing.Point(343, 50);
            this.lblMsjGuardadoArt.Name = "lblMsjGuardadoArt";
            this.lblMsjGuardadoArt.Size = new System.Drawing.Size(0, 20);
            this.lblMsjGuardadoArt.TabIndex = 21;
            // 
            // btnLimpiarArtista
            // 
            this.btnLimpiarArtista.Location = new System.Drawing.Point(388, 464);
            this.btnLimpiarArtista.Name = "btnLimpiarArtista";
            this.btnLimpiarArtista.Size = new System.Drawing.Size(101, 27);
            this.btnLimpiarArtista.TabIndex = 22;
            this.btnLimpiarArtista.Text = "LIMPIAR";
            this.btnLimpiarArtista.UseVisualStyleBackColor = true;
            this.btnLimpiarArtista.Click += new System.EventHandler(this.btnLimpiarArtista_Click);
            // 
            // frmNuevoArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 536);
            this.Controls.Add(this.btnLimpiarArtista);
            this.Controls.Add(this.lblMsjGuardadoArt);
            this.Controls.Add(this.lblMsjFFallArt);
            this.Controls.Add(this.chkFFall);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.lblMsjFNacArt);
            this.Controls.Add(this.lblMsjNacArt);
            this.Controls.Add(this.lblMsjApellidoArt);
            this.Controls.Add(this.lblMsjNombreArt);
            this.Controls.Add(this.btnCancelarArtista);
            this.Controls.Add(this.btnGuardarArtista);
            this.Controls.Add(this.mkdFFall);
            this.Controls.Add(this.mkdFNac);
            this.Controls.Add(this.txtApellidoArtista);
            this.Controls.Add(this.txtNombreArtista);
            this.Controls.Add(this.txtIdArt);
            this.Controls.Add(this.lblFFall);
            this.Controls.Add(this.lblFNac);
            this.Controls.Add(this.lblNacArtista);
            this.Controls.Add(this.lblApellidoArtista);
            this.Controls.Add(this.lblNombreArtista);
            this.Controls.Add(this.lblIdArt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNuevoArtista";
            this.Text = "Guardar Nuevo Artista";
            this.Load += new System.EventHandler(this.frmNuevoArtista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdArt;
        private System.Windows.Forms.Label lblNombreArtista;
        private System.Windows.Forms.Label lblApellidoArtista;
        private System.Windows.Forms.Label lblNacArtista;
        private System.Windows.Forms.Label lblFNac;
        private System.Windows.Forms.Label lblFFall;
        private System.Windows.Forms.TextBox txtIdArt;
        private System.Windows.Forms.TextBox txtNombreArtista;
        private System.Windows.Forms.TextBox txtApellidoArtista;
        private System.Windows.Forms.MaskedTextBox mkdFNac;
        private System.Windows.Forms.MaskedTextBox mkdFFall;
        private System.Windows.Forms.Button btnGuardarArtista;
        private System.Windows.Forms.Button btnCancelarArtista;
        private System.Windows.Forms.Label lblMsjNombreArt;
        private System.Windows.Forms.Label lblMsjApellidoArt;
        private System.Windows.Forms.Label lblMsjNacArt;
        private System.Windows.Forms.Label lblMsjFNacArt;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.CheckBox chkFFall;
        private System.Windows.Forms.Label lblMsjFFallArt;
        private System.Windows.Forms.Label lblMsjGuardadoArt;
        private System.Windows.Forms.Button btnLimpiarArtista;
    }
}