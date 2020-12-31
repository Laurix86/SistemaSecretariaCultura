namespace SecretariaDeCultura
{
    partial class frmNuevoPrestamo
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
            this.components = new System.ComponentModel.Container();
            this.lblIdPrestamo = new System.Windows.Forms.Label();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblObraPrestamo = new System.Windows.Forms.Label();
            this.cbxObrasPrestamo = new System.Windows.Forms.ComboBox();
            this.lblDesdePrestamo = new System.Windows.Forms.Label();
            this.lblHastaPrestamo = new System.Windows.Forms.Label();
            this.mkdDesdePrestamo = new System.Windows.Forms.MaskedTextBox();
            this.mkdHastaPrestamo = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblCentroPrestamo = new System.Windows.Forms.Label();
            this.cbxCentroPrestamo = new System.Windows.Forms.ComboBox();
            this.btnGuardarPrestamo = new System.Windows.Forms.Button();
            this.btnCancelarPrestamo = new System.Windows.Forms.Button();
            this.btnAddObraPrestamo = new System.Windows.Forms.Button();
            this.btnAddCentroPrestamo = new System.Windows.Forms.Button();
            this.lblMsjObraPrestamo = new System.Windows.Forms.Label();
            this.lblMsjFechaPrestamo = new System.Windows.Forms.Label();
            this.lblMsjCentroPrestamo = new System.Windows.Forms.Label();
            this.lblMsjGuardadoPrestamo = new System.Windows.Forms.Label();
            this.ttpObraPrestamo = new System.Windows.Forms.ToolTip(this.components);
            this.ttpCentroPrestamo = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimpiarPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdPrestamo
            // 
            this.lblIdPrestamo.AutoSize = true;
            this.lblIdPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPrestamo.Location = new System.Drawing.Point(16, 36);
            this.lblIdPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdPrestamo.Name = "lblIdPrestamo";
            this.lblIdPrestamo.Size = new System.Drawing.Size(31, 25);
            this.lblIdPrestamo.TabIndex = 0;
            this.lblIdPrestamo.Text = "ID";
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Location = new System.Drawing.Point(132, 36);
            this.txtIdPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.ReadOnly = true;
            this.txtIdPrestamo.Size = new System.Drawing.Size(160, 22);
            this.txtIdPrestamo.TabIndex = 1;
            // 
            // lblObraPrestamo
            // 
            this.lblObraPrestamo.AutoSize = true;
            this.lblObraPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObraPrestamo.Location = new System.Drawing.Point(16, 102);
            this.lblObraPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObraPrestamo.Name = "lblObraPrestamo";
            this.lblObraPrestamo.Size = new System.Drawing.Size(68, 25);
            this.lblObraPrestamo.TabIndex = 2;
            this.lblObraPrestamo.Text = "OBRA";
            // 
            // cbxObrasPrestamo
            // 
            this.cbxObrasPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxObrasPrestamo.FormattingEnabled = true;
            this.cbxObrasPrestamo.Location = new System.Drawing.Point(132, 102);
            this.cbxObrasPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxObrasPrestamo.Name = "cbxObrasPrestamo";
            this.cbxObrasPrestamo.Size = new System.Drawing.Size(328, 26);
            this.cbxObrasPrestamo.TabIndex = 3;
            // 
            // lblDesdePrestamo
            // 
            this.lblDesdePrestamo.AutoSize = true;
            this.lblDesdePrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesdePrestamo.Location = new System.Drawing.Point(16, 186);
            this.lblDesdePrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesdePrestamo.Name = "lblDesdePrestamo";
            this.lblDesdePrestamo.Size = new System.Drawing.Size(65, 24);
            this.lblDesdePrestamo.TabIndex = 4;
            this.lblDesdePrestamo.Text = "Desde";
            // 
            // lblHastaPrestamo
            // 
            this.lblHastaPrestamo.AutoSize = true;
            this.lblHastaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaPrestamo.Location = new System.Drawing.Point(285, 186);
            this.lblHastaPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHastaPrestamo.Name = "lblHastaPrestamo";
            this.lblHastaPrestamo.Size = new System.Drawing.Size(57, 24);
            this.lblHastaPrestamo.TabIndex = 5;
            this.lblHastaPrestamo.Text = "Hasta";
            // 
            // mkdDesdePrestamo
            // 
            this.mkdDesdePrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdDesdePrestamo.Location = new System.Drawing.Point(132, 186);
            this.mkdDesdePrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.mkdDesdePrestamo.Mask = "00/00/0000";
            this.mkdDesdePrestamo.Name = "mkdDesdePrestamo";
            this.mkdDesdePrestamo.Size = new System.Drawing.Size(119, 27);
            this.mkdDesdePrestamo.TabIndex = 6;
            this.mkdDesdePrestamo.ValidatingType = typeof(System.DateTime);
            // 
            // mkdHastaPrestamo
            // 
            this.mkdHastaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkdHastaPrestamo.Location = new System.Drawing.Point(368, 186);
            this.mkdHastaPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.mkdHastaPrestamo.Mask = "00/00/0000";
            this.mkdHastaPrestamo.Name = "mkdHastaPrestamo";
            this.mkdHastaPrestamo.Size = new System.Drawing.Size(111, 24);
            this.mkdHastaPrestamo.TabIndex = 7;
            this.mkdHastaPrestamo.ValidatingType = typeof(System.DateTime);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblCentroPrestamo
            // 
            this.lblCentroPrestamo.AutoSize = true;
            this.lblCentroPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentroPrestamo.Location = new System.Drawing.Point(16, 261);
            this.lblCentroPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCentroPrestamo.Name = "lblCentroPrestamo";
            this.lblCentroPrestamo.Size = new System.Drawing.Size(143, 25);
            this.lblCentroPrestamo.TabIndex = 9;
            this.lblCentroPrestamo.Text = "Centro Cultural";
            // 
            // cbxCentroPrestamo
            // 
            this.cbxCentroPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCentroPrestamo.FormattingEnabled = true;
            this.cbxCentroPrestamo.Location = new System.Drawing.Point(182, 265);
            this.cbxCentroPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCentroPrestamo.Name = "cbxCentroPrestamo";
            this.cbxCentroPrestamo.Size = new System.Drawing.Size(278, 28);
            this.cbxCentroPrestamo.TabIndex = 10;
            // 
            // btnGuardarPrestamo
            // 
            this.btnGuardarPrestamo.Location = new System.Drawing.Point(132, 358);
            this.btnGuardarPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            this.btnGuardarPrestamo.Size = new System.Drawing.Size(100, 28);
            this.btnGuardarPrestamo.TabIndex = 11;
            this.btnGuardarPrestamo.Text = "GUARDAR";
            this.btnGuardarPrestamo.UseVisualStyleBackColor = true;
            this.btnGuardarPrestamo.Click += new System.EventHandler(this.btnGuardarPrestamo_Click);
            // 
            // btnCancelarPrestamo
            // 
            this.btnCancelarPrestamo.Location = new System.Drawing.Point(278, 358);
            this.btnCancelarPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            this.btnCancelarPrestamo.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarPrestamo.TabIndex = 12;
            this.btnCancelarPrestamo.Text = "CANCELAR";
            this.btnCancelarPrestamo.UseVisualStyleBackColor = true;
            this.btnCancelarPrestamo.Click += new System.EventHandler(this.btnCancelarPrestamo_Click);
            // 
            // btnAddObraPrestamo
            // 
            this.btnAddObraPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObraPrestamo.Location = new System.Drawing.Point(495, 98);
            this.btnAddObraPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddObraPrestamo.Name = "btnAddObraPrestamo";
            this.btnAddObraPrestamo.Size = new System.Drawing.Size(47, 37);
            this.btnAddObraPrestamo.TabIndex = 13;
            this.btnAddObraPrestamo.Text = "+";
            this.ttpObraPrestamo.SetToolTip(this.btnAddObraPrestamo, "Agregar Obra nueva");
            this.btnAddObraPrestamo.UseVisualStyleBackColor = true;
            this.btnAddObraPrestamo.Click += new System.EventHandler(this.btnAddObraPrestamo_Click);
            // 
            // btnAddCentroPrestamo
            // 
            this.btnAddCentroPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCentroPrestamo.Location = new System.Drawing.Point(477, 261);
            this.btnAddCentroPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCentroPrestamo.Name = "btnAddCentroPrestamo";
            this.btnAddCentroPrestamo.Size = new System.Drawing.Size(47, 37);
            this.btnAddCentroPrestamo.TabIndex = 14;
            this.btnAddCentroPrestamo.Text = "+";
            this.ttpCentroPrestamo.SetToolTip(this.btnAddCentroPrestamo, "Agregar Centro nuevo");
            this.btnAddCentroPrestamo.UseVisualStyleBackColor = true;
            this.btnAddCentroPrestamo.Click += new System.EventHandler(this.btnAddCentroPrestamo_Click);
            // 
            // lblMsjObraPrestamo
            // 
            this.lblMsjObraPrestamo.AutoSize = true;
            this.lblMsjObraPrestamo.ForeColor = System.Drawing.Color.Red;
            this.lblMsjObraPrestamo.Location = new System.Drawing.Point(577, 112);
            this.lblMsjObraPrestamo.Name = "lblMsjObraPrestamo";
            this.lblMsjObraPrestamo.Size = new System.Drawing.Size(0, 17);
            this.lblMsjObraPrestamo.TabIndex = 15;
            // 
            // lblMsjFechaPrestamo
            // 
            this.lblMsjFechaPrestamo.AutoSize = true;
            this.lblMsjFechaPrestamo.ForeColor = System.Drawing.Color.Red;
            this.lblMsjFechaPrestamo.Location = new System.Drawing.Point(237, 222);
            this.lblMsjFechaPrestamo.Name = "lblMsjFechaPrestamo";
            this.lblMsjFechaPrestamo.Size = new System.Drawing.Size(0, 17);
            this.lblMsjFechaPrestamo.TabIndex = 16;
            // 
            // lblMsjCentroPrestamo
            // 
            this.lblMsjCentroPrestamo.AutoSize = true;
            this.lblMsjCentroPrestamo.ForeColor = System.Drawing.Color.Red;
            this.lblMsjCentroPrestamo.Location = new System.Drawing.Point(542, 268);
            this.lblMsjCentroPrestamo.Name = "lblMsjCentroPrestamo";
            this.lblMsjCentroPrestamo.Size = new System.Drawing.Size(0, 17);
            this.lblMsjCentroPrestamo.TabIndex = 18;
            // 
            // lblMsjGuardadoPrestamo
            // 
            this.lblMsjGuardadoPrestamo.AutoSize = true;
            this.lblMsjGuardadoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjGuardadoPrestamo.ForeColor = System.Drawing.Color.Red;
            this.lblMsjGuardadoPrestamo.Location = new System.Drawing.Point(332, 36);
            this.lblMsjGuardadoPrestamo.Name = "lblMsjGuardadoPrestamo";
            this.lblMsjGuardadoPrestamo.Size = new System.Drawing.Size(0, 20);
            this.lblMsjGuardadoPrestamo.TabIndex = 19;
            // 
            // btnLimpiarPrestamo
            // 
            this.btnLimpiarPrestamo.Location = new System.Drawing.Point(429, 358);
            this.btnLimpiarPrestamo.Name = "btnLimpiarPrestamo";
            this.btnLimpiarPrestamo.Size = new System.Drawing.Size(95, 28);
            this.btnLimpiarPrestamo.TabIndex = 20;
            this.btnLimpiarPrestamo.Text = "LIMPIAR";
            this.btnLimpiarPrestamo.UseVisualStyleBackColor = true;
            this.btnLimpiarPrestamo.Click += new System.EventHandler(this.btnLimpiarPrestamo_Click);
            // 
            // frmNuevoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 437);
            this.Controls.Add(this.btnLimpiarPrestamo);
            this.Controls.Add(this.lblMsjGuardadoPrestamo);
            this.Controls.Add(this.lblMsjCentroPrestamo);
            this.Controls.Add(this.lblMsjFechaPrestamo);
            this.Controls.Add(this.lblMsjObraPrestamo);
            this.Controls.Add(this.btnAddCentroPrestamo);
            this.Controls.Add(this.btnAddObraPrestamo);
            this.Controls.Add(this.btnCancelarPrestamo);
            this.Controls.Add(this.btnGuardarPrestamo);
            this.Controls.Add(this.cbxCentroPrestamo);
            this.Controls.Add(this.lblCentroPrestamo);
            this.Controls.Add(this.mkdHastaPrestamo);
            this.Controls.Add(this.mkdDesdePrestamo);
            this.Controls.Add(this.lblHastaPrestamo);
            this.Controls.Add(this.lblDesdePrestamo);
            this.Controls.Add(this.cbxObrasPrestamo);
            this.Controls.Add(this.lblObraPrestamo);
            this.Controls.Add(this.txtIdPrestamo);
            this.Controls.Add(this.lblIdPrestamo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNuevoPrestamo";
            this.Text = "Registrar Nuevo Prestamo";
            this.Load += new System.EventHandler(this.frmNuevoPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPrestamo;
        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblObraPrestamo;
        private System.Windows.Forms.ComboBox cbxObrasPrestamo;
        private System.Windows.Forms.Label lblDesdePrestamo;
        private System.Windows.Forms.Label lblHastaPrestamo;
        private System.Windows.Forms.MaskedTextBox mkdDesdePrestamo;
        private System.Windows.Forms.MaskedTextBox mkdHastaPrestamo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblCentroPrestamo;
        private System.Windows.Forms.ComboBox cbxCentroPrestamo;
        private System.Windows.Forms.Button btnGuardarPrestamo;
        private System.Windows.Forms.Button btnCancelarPrestamo;
        private System.Windows.Forms.Button btnAddObraPrestamo;
        private System.Windows.Forms.Button btnAddCentroPrestamo;
        private System.Windows.Forms.Label lblMsjObraPrestamo;
        private System.Windows.Forms.Label lblMsjFechaPrestamo;
        private System.Windows.Forms.Label lblMsjCentroPrestamo;
        private System.Windows.Forms.Label lblMsjGuardadoPrestamo;
        private System.Windows.Forms.ToolTip ttpObraPrestamo;
        private System.Windows.Forms.ToolTip ttpCentroPrestamo;
        private System.Windows.Forms.Button btnLimpiarPrestamo;
    }
}