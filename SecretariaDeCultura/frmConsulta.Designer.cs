namespace SecretariaDeCultura
{
    partial class frmConsulta
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
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.radPrestamo = new System.Windows.Forms.RadioButton();
            this.radCentro = new System.Windows.Forms.RadioButton();
            this.radArtista = new System.Windows.Forms.RadioButton();
            this.radObra = new System.Windows.Forms.RadioButton();
            this.pnlObra = new System.Windows.Forms.Panel();
            this.lblMsjBusquedaObra = new System.Windows.Forms.Label();
            this.lblInfoObras = new System.Windows.Forms.Label();
            this.lstInfoObras = new System.Windows.Forms.ListBox();
            this.cbxListaObras = new System.Windows.Forms.ComboBox();
            this.lblListaObras = new System.Windows.Forms.Label();
            this.txtNombreObra = new System.Windows.Forms.TextBox();
            this.lblPorNombreOb = new System.Windows.Forms.Label();
            this.lblFiltroObra = new System.Windows.Forms.Label();
            this.chkCuadro = new System.Windows.Forms.CheckBox();
            this.chkEscultura = new System.Windows.Forms.CheckBox();
            this.btnBuscarObra = new System.Windows.Forms.Button();
            this.pnlArtista = new System.Windows.Forms.Panel();
            this.lblMsjBuscar = new System.Windows.Forms.Label();
            this.gpbFiltroArtista = new System.Windows.Forms.GroupBox();
            this.radNombreArt = new System.Windows.Forms.RadioButton();
            this.radNacArt = new System.Windows.Forms.RadioButton();
            this.lblInfoArtistas = new System.Windows.Forms.Label();
            this.lstInfoArtistas = new System.Windows.Forms.ListBox();
            this.btnBuscarArtista = new System.Windows.Forms.Button();
            this.cbxListaArtistas = new System.Windows.Forms.ComboBox();
            this.lblListaArtistas = new System.Windows.Forms.Label();
            this.txtNombreArtista = new System.Windows.Forms.TextBox();
            this.lblPorNombreArt = new System.Windows.Forms.Label();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblMsjBusquedaCentro = new System.Windows.Forms.Label();
            this.lblInfoCentros = new System.Windows.Forms.Label();
            this.lstInfoCentros = new System.Windows.Forms.ListBox();
            this.btnBuscarCentro = new System.Windows.Forms.Button();
            this.lblListaCentro = new System.Windows.Forms.Label();
            this.cbxListaCentros = new System.Windows.Forms.ComboBox();
            this.lblPorNombreCentro = new System.Windows.Forms.Label();
            this.txtPorNombreCentro = new System.Windows.Forms.TextBox();
            this.gpbFiltroCentro = new System.Windows.Forms.GroupBox();
            this.radPorProvCentro = new System.Windows.Forms.RadioButton();
            this.radPorNombreCentro = new System.Windows.Forms.RadioButton();
            this.pnlPrestamo = new System.Windows.Forms.Panel();
            this.lblInfoPrestamos = new System.Windows.Forms.Label();
            this.lstInfoPrestamos = new System.Windows.Forms.ListBox();
            this.lblListaCentrosPrestamo = new System.Windows.Forms.Label();
            this.lblListaArtistasPrestamo = new System.Windows.Forms.Label();
            this.lblListaObrasPrestamo = new System.Windows.Forms.Label();
            this.cbxCentrosPrestamo = new System.Windows.Forms.ComboBox();
            this.cbxArtistasPrestamo = new System.Windows.Forms.ComboBox();
            this.cbxObrasPrestamo = new System.Windows.Forms.ComboBox();
            this.gpbBusqueda.SuspendLayout();
            this.pnlObra.SuspendLayout();
            this.pnlArtista.SuspendLayout();
            this.gpbFiltroArtista.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            this.gpbFiltroCentro.SuspendLayout();
            this.pnlPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Controls.Add(this.radPrestamo);
            this.gpbBusqueda.Controls.Add(this.radCentro);
            this.gpbBusqueda.Controls.Add(this.radArtista);
            this.gpbBusqueda.Controls.Add(this.radObra);
            this.gpbBusqueda.Location = new System.Drawing.Point(13, 13);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(159, 213);
            this.gpbBusqueda.TabIndex = 0;
            this.gpbBusqueda.TabStop = false;
            this.gpbBusqueda.Text = "Buscar por: ";
            // 
            // radPrestamo
            // 
            this.radPrestamo.AutoSize = true;
            this.radPrestamo.Location = new System.Drawing.Point(24, 170);
            this.radPrestamo.Name = "radPrestamo";
            this.radPrestamo.Size = new System.Drawing.Size(89, 21);
            this.radPrestamo.TabIndex = 3;
            this.radPrestamo.Text = "Préstamo";
            this.radPrestamo.UseVisualStyleBackColor = true;
            // 
            // radCentro
            // 
            this.radCentro.AutoSize = true;
            this.radCentro.Location = new System.Drawing.Point(24, 128);
            this.radCentro.Name = "radCentro";
            this.radCentro.Size = new System.Drawing.Size(123, 21);
            this.radCentro.TabIndex = 2;
            this.radCentro.Text = "Centro Cultural";
            this.radCentro.UseVisualStyleBackColor = true;
            // 
            // radArtista
            // 
            this.radArtista.AutoSize = true;
            this.radArtista.Location = new System.Drawing.Point(24, 89);
            this.radArtista.Name = "radArtista";
            this.radArtista.Size = new System.Drawing.Size(69, 21);
            this.radArtista.TabIndex = 1;
            this.radArtista.Text = "Artista";
            this.radArtista.UseVisualStyleBackColor = true;
            // 
            // radObra
            // 
            this.radObra.AutoSize = true;
            this.radObra.Checked = true;
            this.radObra.Location = new System.Drawing.Point(24, 50);
            this.radObra.Name = "radObra";
            this.radObra.Size = new System.Drawing.Size(61, 21);
            this.radObra.TabIndex = 0;
            this.radObra.TabStop = true;
            this.radObra.Text = "Obra";
            this.radObra.UseVisualStyleBackColor = true;
            // 
            // pnlObra
            // 
            this.pnlObra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlObra.Controls.Add(this.lblMsjBusquedaObra);
            this.pnlObra.Controls.Add(this.lblInfoObras);
            this.pnlObra.Controls.Add(this.lstInfoObras);
            this.pnlObra.Controls.Add(this.cbxListaObras);
            this.pnlObra.Controls.Add(this.lblListaObras);
            this.pnlObra.Controls.Add(this.txtNombreObra);
            this.pnlObra.Controls.Add(this.lblPorNombreOb);
            this.pnlObra.Controls.Add(this.lblFiltroObra);
            this.pnlObra.Controls.Add(this.chkCuadro);
            this.pnlObra.Controls.Add(this.chkEscultura);
            this.pnlObra.Controls.Add(this.btnBuscarObra);
            this.pnlObra.Location = new System.Drawing.Point(202, 20);
            this.pnlObra.Name = "pnlObra";
            this.pnlObra.Size = new System.Drawing.Size(852, 514);
            this.pnlObra.TabIndex = 1;
            // 
            // lblMsjBusquedaObra
            // 
            this.lblMsjBusquedaObra.AutoSize = true;
            this.lblMsjBusquedaObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjBusquedaObra.ForeColor = System.Drawing.Color.Red;
            this.lblMsjBusquedaObra.Location = new System.Drawing.Point(263, 130);
            this.lblMsjBusquedaObra.Name = "lblMsjBusquedaObra";
            this.lblMsjBusquedaObra.Size = new System.Drawing.Size(0, 20);
            this.lblMsjBusquedaObra.TabIndex = 13;
            // 
            // lblInfoObras
            // 
            this.lblInfoObras.AutoSize = true;
            this.lblInfoObras.Location = new System.Drawing.Point(164, 196);
            this.lblInfoObras.Name = "lblInfoObras";
            this.lblInfoObras.Size = new System.Drawing.Size(151, 17);
            this.lblInfoObras.TabIndex = 8;
            this.lblInfoObras.Text = "Información Obtenida: ";
            // 
            // lstInfoObras
            // 
            this.lstInfoObras.FormattingEnabled = true;
            this.lstInfoObras.ItemHeight = 16;
            this.lstInfoObras.Location = new System.Drawing.Point(167, 224);
            this.lstInfoObras.Name = "lstInfoObras";
            this.lstInfoObras.Size = new System.Drawing.Size(678, 196);
            this.lstInfoObras.TabIndex = 7;
            // 
            // cbxListaObras
            // 
            this.cbxListaObras.FormattingEnabled = true;
            this.cbxListaObras.Location = new System.Drawing.Point(458, 50);
            this.cbxListaObras.Name = "cbxListaObras";
            this.cbxListaObras.Size = new System.Drawing.Size(375, 24);
            this.cbxListaObras.TabIndex = 6;
            this.cbxListaObras.SelectedIndexChanged += new System.EventHandler(this.cbxListaObras_SelectedIndexChanged);
            // 
            // lblListaObras
            // 
            this.lblListaObras.AutoSize = true;
            this.lblListaObras.Location = new System.Drawing.Point(490, 22);
            this.lblListaObras.Name = "lblListaObras";
            this.lblListaObras.Size = new System.Drawing.Size(121, 17);
            this.lblListaObras.TabIndex = 5;
            this.lblListaObras.Text = "Listado de Obras:";
            // 
            // txtNombreObra
            // 
            this.txtNombreObra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreObra.Location = new System.Drawing.Point(167, 50);
            this.txtNombreObra.Name = "txtNombreObra";
            this.txtNombreObra.Size = new System.Drawing.Size(285, 22);
            this.txtNombreObra.TabIndex = 4;
            // 
            // lblPorNombreOb
            // 
            this.lblPorNombreOb.AutoSize = true;
            this.lblPorNombreOb.Location = new System.Drawing.Point(164, 22);
            this.lblPorNombreOb.Name = "lblPorNombreOb";
            this.lblPorNombreOb.Size = new System.Drawing.Size(135, 17);
            this.lblPorNombreOb.TabIndex = 3;
            this.lblPorNombreOb.Text = "Buscar por Nombre:";
            // 
            // lblFiltroObra
            // 
            this.lblFiltroObra.AutoSize = true;
            this.lblFiltroObra.Location = new System.Drawing.Point(12, 75);
            this.lblFiltroObra.Name = "lblFiltroObra";
            this.lblFiltroObra.Size = new System.Drawing.Size(77, 17);
            this.lblFiltroObra.TabIndex = 2;
            this.lblFiltroObra.Text = "Filtrar por: ";
            // 
            // chkCuadro
            // 
            this.chkCuadro.AutoSize = true;
            this.chkCuadro.Location = new System.Drawing.Point(39, 151);
            this.chkCuadro.Name = "chkCuadro";
            this.chkCuadro.Size = new System.Drawing.Size(76, 21);
            this.chkCuadro.TabIndex = 1;
            this.chkCuadro.Text = "Cuadro";
            this.chkCuadro.UseVisualStyleBackColor = true;
            this.chkCuadro.CheckedChanged += new System.EventHandler(this.chkCuadro_CheckedChanged);
            // 
            // chkEscultura
            // 
            this.chkEscultura.AutoSize = true;
            this.chkEscultura.Location = new System.Drawing.Point(39, 111);
            this.chkEscultura.Name = "chkEscultura";
            this.chkEscultura.Size = new System.Drawing.Size(89, 21);
            this.chkEscultura.TabIndex = 0;
            this.chkEscultura.Text = "Escultura";
            this.chkEscultura.UseVisualStyleBackColor = true;
            this.chkEscultura.CheckedChanged += new System.EventHandler(this.chkEscultura_CheckedChanged);
            // 
            // btnBuscarObra
            // 
            this.btnBuscarObra.Location = new System.Drawing.Point(360, 83);
            this.btnBuscarObra.Name = "btnBuscarObra";
            this.btnBuscarObra.Size = new System.Drawing.Size(89, 33);
            this.btnBuscarObra.TabIndex = 12;
            this.btnBuscarObra.Text = "Buscar";
            this.btnBuscarObra.UseVisualStyleBackColor = true;
            this.btnBuscarObra.Click += new System.EventHandler(this.btnBuscarObra_Click);
            // 
            // pnlArtista
            // 
            this.pnlArtista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlArtista.Controls.Add(this.lblMsjBuscar);
            this.pnlArtista.Controls.Add(this.gpbFiltroArtista);
            this.pnlArtista.Controls.Add(this.lblInfoArtistas);
            this.pnlArtista.Controls.Add(this.lstInfoArtistas);
            this.pnlArtista.Controls.Add(this.btnBuscarArtista);
            this.pnlArtista.Controls.Add(this.cbxListaArtistas);
            this.pnlArtista.Controls.Add(this.lblListaArtistas);
            this.pnlArtista.Controls.Add(this.txtNombreArtista);
            this.pnlArtista.Controls.Add(this.lblPorNombreArt);
            this.pnlArtista.Location = new System.Drawing.Point(202, 20);
            this.pnlArtista.Name = "pnlArtista";
            this.pnlArtista.Size = new System.Drawing.Size(875, 559);
            this.pnlArtista.TabIndex = 2;
            this.pnlArtista.Visible = false;
            // 
            // lblMsjBuscar
            // 
            this.lblMsjBuscar.AutoSize = true;
            this.lblMsjBuscar.Location = new System.Drawing.Point(408, 91);
            this.lblMsjBuscar.Name = "lblMsjBuscar";
            this.lblMsjBuscar.Size = new System.Drawing.Size(0, 17);
            this.lblMsjBuscar.TabIndex = 12;
            // 
            // gpbFiltroArtista
            // 
            this.gpbFiltroArtista.Controls.Add(this.radNombreArt);
            this.gpbFiltroArtista.Controls.Add(this.radNacArt);
            this.gpbFiltroArtista.Location = new System.Drawing.Point(15, 95);
            this.gpbFiltroArtista.Name = "gpbFiltroArtista";
            this.gpbFiltroArtista.Size = new System.Drawing.Size(200, 100);
            this.gpbFiltroArtista.TabIndex = 11;
            this.gpbFiltroArtista.TabStop = false;
            this.gpbFiltroArtista.Text = "Filtrar por";
            // 
            // radNombreArt
            // 
            this.radNombreArt.AutoSize = true;
            this.radNombreArt.Checked = true;
            this.radNombreArt.Location = new System.Drawing.Point(20, 35);
            this.radNombreArt.Name = "radNombreArt";
            this.radNombreArt.Size = new System.Drawing.Size(105, 21);
            this.radNombreArt.TabIndex = 0;
            this.radNombreArt.TabStop = true;
            this.radNombreArt.Text = "Por Nombre";
            this.radNombreArt.UseVisualStyleBackColor = true;
            this.radNombreArt.CheckedChanged += new System.EventHandler(this.radNombreArt_CheckedChanged);
            // 
            // radNacArt
            // 
            this.radNacArt.AutoSize = true;
            this.radNacArt.Location = new System.Drawing.Point(20, 73);
            this.radNacArt.Name = "radNacArt";
            this.radNacArt.Size = new System.Drawing.Size(137, 21);
            this.radNacArt.TabIndex = 1;
            this.radNacArt.Text = "Por Nacionalidad";
            this.radNacArt.UseVisualStyleBackColor = true;
            // 
            // lblInfoArtistas
            // 
            this.lblInfoArtistas.AutoSize = true;
            this.lblInfoArtistas.Location = new System.Drawing.Point(253, 196);
            this.lblInfoArtistas.Name = "lblInfoArtistas";
            this.lblInfoArtistas.Size = new System.Drawing.Size(151, 17);
            this.lblInfoArtistas.TabIndex = 10;
            this.lblInfoArtistas.Text = "Información Obtenida: ";
            // 
            // lstInfoArtistas
            // 
            this.lstInfoArtistas.FormattingEnabled = true;
            this.lstInfoArtistas.ItemHeight = 16;
            this.lstInfoArtistas.Location = new System.Drawing.Point(255, 224);
            this.lstInfoArtistas.Name = "lstInfoArtistas";
            this.lstInfoArtistas.Size = new System.Drawing.Size(590, 196);
            this.lstInfoArtistas.TabIndex = 9;
            // 
            // btnBuscarArtista
            // 
            this.btnBuscarArtista.Location = new System.Drawing.Point(355, 119);
            this.btnBuscarArtista.Name = "btnBuscarArtista";
            this.btnBuscarArtista.Size = new System.Drawing.Size(110, 32);
            this.btnBuscarArtista.TabIndex = 8;
            this.btnBuscarArtista.Text = "Buscar";
            this.btnBuscarArtista.UseVisualStyleBackColor = true;
            this.btnBuscarArtista.Click += new System.EventHandler(this.btnBuscarArtista_Click);
            // 
            // cbxListaArtistas
            // 
            this.cbxListaArtistas.FormattingEnabled = true;
            this.cbxListaArtistas.Location = new System.Drawing.Point(498, 59);
            this.cbxListaArtistas.Name = "cbxListaArtistas";
            this.cbxListaArtistas.Size = new System.Drawing.Size(244, 24);
            this.cbxListaArtistas.TabIndex = 7;
            this.cbxListaArtistas.SelectedIndexChanged += new System.EventHandler(this.cbxListaArtistas_SelectedIndexChanged);
            // 
            // lblListaArtistas
            // 
            this.lblListaArtistas.AutoSize = true;
            this.lblListaArtistas.Location = new System.Drawing.Point(495, 24);
            this.lblListaArtistas.Name = "lblListaArtistas";
            this.lblListaArtistas.Size = new System.Drawing.Size(0, 17);
            this.lblListaArtistas.TabIndex = 6;
            // 
            // txtNombreArtista
            // 
            this.txtNombreArtista.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreArtista.Location = new System.Drawing.Point(255, 59);
            this.txtNombreArtista.Name = "txtNombreArtista";
            this.txtNombreArtista.Size = new System.Drawing.Size(210, 22);
            this.txtNombreArtista.TabIndex = 5;
            // 
            // lblPorNombreArt
            // 
            this.lblPorNombreArt.AutoSize = true;
            this.lblPorNombreArt.Location = new System.Drawing.Point(252, 24);
            this.lblPorNombreArt.Name = "lblPorNombreArt";
            this.lblPorNombreArt.Size = new System.Drawing.Size(0, 17);
            this.lblPorNombreArt.TabIndex = 4;
            // 
            // pnlCentro
            // 
            this.pnlCentro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCentro.Controls.Add(this.lblMsjBusquedaCentro);
            this.pnlCentro.Controls.Add(this.lblInfoCentros);
            this.pnlCentro.Controls.Add(this.lstInfoCentros);
            this.pnlCentro.Controls.Add(this.btnBuscarCentro);
            this.pnlCentro.Controls.Add(this.lblListaCentro);
            this.pnlCentro.Controls.Add(this.cbxListaCentros);
            this.pnlCentro.Controls.Add(this.lblPorNombreCentro);
            this.pnlCentro.Controls.Add(this.txtPorNombreCentro);
            this.pnlCentro.Controls.Add(this.gpbFiltroCentro);
            this.pnlCentro.Location = new System.Drawing.Point(202, 20);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(879, 533);
            this.pnlCentro.TabIndex = 2;
            this.pnlCentro.Visible = false;
            // 
            // lblMsjBusquedaCentro
            // 
            this.lblMsjBusquedaCentro.AutoSize = true;
            this.lblMsjBusquedaCentro.Location = new System.Drawing.Point(357, 83);
            this.lblMsjBusquedaCentro.Name = "lblMsjBusquedaCentro";
            this.lblMsjBusquedaCentro.Size = new System.Drawing.Size(0, 17);
            this.lblMsjBusquedaCentro.TabIndex = 8;
            // 
            // lblInfoCentros
            // 
            this.lblInfoCentros.AutoSize = true;
            this.lblInfoCentros.Location = new System.Drawing.Point(251, 214);
            this.lblInfoCentros.Name = "lblInfoCentros";
            this.lblInfoCentros.Size = new System.Drawing.Size(144, 17);
            this.lblInfoCentros.TabIndex = 7;
            this.lblInfoCentros.Text = "Información obtenida:";
            // 
            // lstInfoCentros
            // 
            this.lstInfoCentros.FormattingEnabled = true;
            this.lstInfoCentros.ItemHeight = 16;
            this.lstInfoCentros.Location = new System.Drawing.Point(250, 237);
            this.lstInfoCentros.Name = "lstInfoCentros";
            this.lstInfoCentros.Size = new System.Drawing.Size(618, 212);
            this.lstInfoCentros.TabIndex = 6;
            // 
            // btnBuscarCentro
            // 
            this.btnBuscarCentro.Location = new System.Drawing.Point(379, 111);
            this.btnBuscarCentro.Name = "btnBuscarCentro";
            this.btnBuscarCentro.Size = new System.Drawing.Size(81, 34);
            this.btnBuscarCentro.TabIndex = 5;
            this.btnBuscarCentro.Text = "Buscar";
            this.btnBuscarCentro.UseVisualStyleBackColor = true;
            this.btnBuscarCentro.Click += new System.EventHandler(this.btnBuscarCentro_Click);
            // 
            // lblListaCentro
            // 
            this.lblListaCentro.AutoSize = true;
            this.lblListaCentro.Location = new System.Drawing.Point(478, 31);
            this.lblListaCentro.Name = "lblListaCentro";
            this.lblListaCentro.Size = new System.Drawing.Size(198, 17);
            this.lblListaCentro.TabIndex = 4;
            this.lblListaCentro.Text = "Listado de Centros Culturales:";
            // 
            // cbxListaCentros
            // 
            this.cbxListaCentros.FormattingEnabled = true;
            this.cbxListaCentros.Location = new System.Drawing.Point(478, 52);
            this.cbxListaCentros.Name = "cbxListaCentros";
            this.cbxListaCentros.Size = new System.Drawing.Size(281, 24);
            this.cbxListaCentros.TabIndex = 3;
            this.cbxListaCentros.SelectedIndexChanged += new System.EventHandler(this.cbxListaCentros_SelectedIndexChanged);
            // 
            // lblPorNombreCentro
            // 
            this.lblPorNombreCentro.AutoSize = true;
            this.lblPorNombreCentro.Location = new System.Drawing.Point(250, 31);
            this.lblPorNombreCentro.Name = "lblPorNombreCentro";
            this.lblPorNombreCentro.Size = new System.Drawing.Size(135, 17);
            this.lblPorNombreCentro.TabIndex = 2;
            this.lblPorNombreCentro.Text = "Escribir para buscar";
            // 
            // txtPorNombreCentro
            // 
            this.txtPorNombreCentro.Location = new System.Drawing.Point(250, 54);
            this.txtPorNombreCentro.Name = "txtPorNombreCentro";
            this.txtPorNombreCentro.Size = new System.Drawing.Size(210, 22);
            this.txtPorNombreCentro.TabIndex = 1;
            // 
            // gpbFiltroCentro
            // 
            this.gpbFiltroCentro.Controls.Add(this.radPorProvCentro);
            this.gpbFiltroCentro.Controls.Add(this.radPorNombreCentro);
            this.gpbFiltroCentro.Location = new System.Drawing.Point(30, 66);
            this.gpbFiltroCentro.Name = "gpbFiltroCentro";
            this.gpbFiltroCentro.Size = new System.Drawing.Size(137, 140);
            this.gpbFiltroCentro.TabIndex = 0;
            this.gpbFiltroCentro.TabStop = false;
            this.gpbFiltroCentro.Text = "Filtrar por: ";
            // 
            // radPorProvCentro
            // 
            this.radPorProvCentro.AutoSize = true;
            this.radPorProvCentro.Location = new System.Drawing.Point(27, 87);
            this.radPorProvCentro.Name = "radPorProvCentro";
            this.radPorProvCentro.Size = new System.Drawing.Size(87, 21);
            this.radPorProvCentro.TabIndex = 1;
            this.radPorProvCentro.TabStop = true;
            this.radPorProvCentro.Text = "Provincia";
            this.radPorProvCentro.UseVisualStyleBackColor = true;
            this.radPorProvCentro.CheckedChanged += new System.EventHandler(this.radPorProvCentro_CheckedChanged);
            // 
            // radPorNombreCentro
            // 
            this.radPorNombreCentro.AutoSize = true;
            this.radPorNombreCentro.Location = new System.Drawing.Point(27, 49);
            this.radPorNombreCentro.Name = "radPorNombreCentro";
            this.radPorNombreCentro.Size = new System.Drawing.Size(79, 21);
            this.radPorNombreCentro.TabIndex = 0;
            this.radPorNombreCentro.TabStop = true;
            this.radPorNombreCentro.Text = "Nombre";
            this.radPorNombreCentro.UseVisualStyleBackColor = true;
            // 
            // pnlPrestamo
            // 
            this.pnlPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPrestamo.Controls.Add(this.lblInfoPrestamos);
            this.pnlPrestamo.Controls.Add(this.lstInfoPrestamos);
            this.pnlPrestamo.Controls.Add(this.lblListaCentrosPrestamo);
            this.pnlPrestamo.Controls.Add(this.lblListaArtistasPrestamo);
            this.pnlPrestamo.Controls.Add(this.lblListaObrasPrestamo);
            this.pnlPrestamo.Controls.Add(this.cbxCentrosPrestamo);
            this.pnlPrestamo.Controls.Add(this.cbxArtistasPrestamo);
            this.pnlPrestamo.Controls.Add(this.cbxObrasPrestamo);
            this.pnlPrestamo.Location = new System.Drawing.Point(202, 20);
            this.pnlPrestamo.Name = "pnlPrestamo";
            this.pnlPrestamo.Size = new System.Drawing.Size(835, 469);
            this.pnlPrestamo.TabIndex = 3;
            this.pnlPrestamo.Visible = false;
            // 
            // lblInfoPrestamos
            // 
            this.lblInfoPrestamos.AutoSize = true;
            this.lblInfoPrestamos.Location = new System.Drawing.Point(31, 163);
            this.lblInfoPrestamos.Name = "lblInfoPrestamos";
            this.lblInfoPrestamos.Size = new System.Drawing.Size(144, 17);
            this.lblInfoPrestamos.TabIndex = 7;
            this.lblInfoPrestamos.Text = "Información obtenida:";
            // 
            // lstInfoPrestamos
            // 
            this.lstInfoPrestamos.FormattingEnabled = true;
            this.lstInfoPrestamos.HorizontalExtent = 60;
            this.lstInfoPrestamos.HorizontalScrollbar = true;
            this.lstInfoPrestamos.ItemHeight = 16;
            this.lstInfoPrestamos.Location = new System.Drawing.Point(34, 192);
            this.lstInfoPrestamos.Name = "lstInfoPrestamos";
            this.lstInfoPrestamos.Size = new System.Drawing.Size(778, 260);
            this.lstInfoPrestamos.TabIndex = 6;
            // 
            // lblListaCentrosPrestamo
            // 
            this.lblListaCentrosPrestamo.AutoSize = true;
            this.lblListaCentrosPrestamo.Location = new System.Drawing.Point(537, 20);
            this.lblListaCentrosPrestamo.Name = "lblListaCentrosPrestamo";
            this.lblListaCentrosPrestamo.Size = new System.Drawing.Size(198, 17);
            this.lblListaCentrosPrestamo.TabIndex = 5;
            this.lblListaCentrosPrestamo.Text = "Listado de Centros Culturales:";
            // 
            // lblListaArtistasPrestamo
            // 
            this.lblListaArtistasPrestamo.AutoSize = true;
            this.lblListaArtistasPrestamo.Location = new System.Drawing.Point(278, 20);
            this.lblListaArtistasPrestamo.Name = "lblListaArtistasPrestamo";
            this.lblListaArtistasPrestamo.Size = new System.Drawing.Size(129, 17);
            this.lblListaArtistasPrestamo.TabIndex = 4;
            this.lblListaArtistasPrestamo.Text = "Listado de Artistas:";
            // 
            // lblListaObrasPrestamo
            // 
            this.lblListaObrasPrestamo.AutoSize = true;
            this.lblListaObrasPrestamo.Location = new System.Drawing.Point(31, 20);
            this.lblListaObrasPrestamo.Name = "lblListaObrasPrestamo";
            this.lblListaObrasPrestamo.Size = new System.Drawing.Size(121, 17);
            this.lblListaObrasPrestamo.TabIndex = 3;
            this.lblListaObrasPrestamo.Text = "Listado de Obras:";
            // 
            // cbxCentrosPrestamo
            // 
            this.cbxCentrosPrestamo.FormattingEnabled = true;
            this.cbxCentrosPrestamo.Location = new System.Drawing.Point(536, 42);
            this.cbxCentrosPrestamo.Name = "cbxCentrosPrestamo";
            this.cbxCentrosPrestamo.Size = new System.Drawing.Size(276, 24);
            this.cbxCentrosPrestamo.TabIndex = 2;
            this.cbxCentrosPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbxCentrosPrestamo_SelectedIndexChanged);
            // 
            // cbxArtistasPrestamo
            // 
            this.cbxArtistasPrestamo.FormattingEnabled = true;
            this.cbxArtistasPrestamo.Location = new System.Drawing.Point(281, 43);
            this.cbxArtistasPrestamo.Name = "cbxArtistasPrestamo";
            this.cbxArtistasPrestamo.Size = new System.Drawing.Size(222, 24);
            this.cbxArtistasPrestamo.TabIndex = 1;
            this.cbxArtistasPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbxArtistasPrestamo_SelectedIndexChanged);
            // 
            // cbxObrasPrestamo
            // 
            this.cbxObrasPrestamo.FormattingEnabled = true;
            this.cbxObrasPrestamo.Location = new System.Drawing.Point(31, 43);
            this.cbxObrasPrestamo.Name = "cbxObrasPrestamo";
            this.cbxObrasPrestamo.Size = new System.Drawing.Size(222, 24);
            this.cbxObrasPrestamo.TabIndex = 0;
            this.cbxObrasPrestamo.SelectedIndexChanged += new System.EventHandler(this.cbxObrasPrestamo_SelectedIndexChanged);
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 628);
            this.Controls.Add(this.pnlObra);
            this.Controls.Add(this.pnlArtista);
            this.Controls.Add(this.pnlPrestamo);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.gpbBusqueda);
            this.Name = "frmConsulta";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.gpbBusqueda.ResumeLayout(false);
            this.gpbBusqueda.PerformLayout();
            this.pnlObra.ResumeLayout(false);
            this.pnlObra.PerformLayout();
            this.pnlArtista.ResumeLayout(false);
            this.pnlArtista.PerformLayout();
            this.gpbFiltroArtista.ResumeLayout(false);
            this.gpbFiltroArtista.PerformLayout();
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            this.gpbFiltroCentro.ResumeLayout(false);
            this.gpbFiltroCentro.PerformLayout();
            this.pnlPrestamo.ResumeLayout(false);
            this.pnlPrestamo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.RadioButton radPrestamo;
        private System.Windows.Forms.RadioButton radCentro;
        private System.Windows.Forms.RadioButton radArtista;
        private System.Windows.Forms.RadioButton radObra;
        private System.Windows.Forms.Panel pnlObra;
        private System.Windows.Forms.Label lblFiltroObra;
        private System.Windows.Forms.CheckBox chkCuadro;
        private System.Windows.Forms.CheckBox chkEscultura;
        private System.Windows.Forms.Button btnBuscarObra;
        private System.Windows.Forms.Label lblInfoObras;
        private System.Windows.Forms.ListBox lstInfoObras;
        private System.Windows.Forms.ComboBox cbxListaObras;
        private System.Windows.Forms.Label lblListaObras;
        private System.Windows.Forms.TextBox txtNombreObra;
        private System.Windows.Forms.Label lblPorNombreOb;
        private System.Windows.Forms.Panel pnlArtista;
        private System.Windows.Forms.RadioButton radNacArt;
        private System.Windows.Forms.RadioButton radNombreArt;
        private System.Windows.Forms.ComboBox cbxListaArtistas;
        private System.Windows.Forms.Label lblListaArtistas;
        private System.Windows.Forms.TextBox txtNombreArtista;
        private System.Windows.Forms.Label lblPorNombreArt;
        private System.Windows.Forms.Button btnBuscarArtista;
        private System.Windows.Forms.ListBox lstInfoArtistas;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label lblInfoArtistas;
        private System.Windows.Forms.Panel pnlPrestamo;
        private System.Windows.Forms.GroupBox gpbFiltroArtista;
        private System.Windows.Forms.Label lblMsjBuscar;
        private System.Windows.Forms.Label lblMsjBusquedaObra;
        private System.Windows.Forms.Button btnBuscarCentro;
        private System.Windows.Forms.Label lblListaCentro;
        private System.Windows.Forms.ComboBox cbxListaCentros;
        private System.Windows.Forms.Label lblPorNombreCentro;
        private System.Windows.Forms.TextBox txtPorNombreCentro;
        private System.Windows.Forms.GroupBox gpbFiltroCentro;
        private System.Windows.Forms.RadioButton radPorProvCentro;
        private System.Windows.Forms.RadioButton radPorNombreCentro;
        private System.Windows.Forms.Label lblMsjBusquedaCentro;
        private System.Windows.Forms.Label lblInfoCentros;
        private System.Windows.Forms.ListBox lstInfoCentros;
        private System.Windows.Forms.Label lblInfoPrestamos;
        private System.Windows.Forms.ListBox lstInfoPrestamos;
        private System.Windows.Forms.Label lblListaCentrosPrestamo;
        private System.Windows.Forms.Label lblListaArtistasPrestamo;
        private System.Windows.Forms.Label lblListaObrasPrestamo;
        private System.Windows.Forms.ComboBox cbxCentrosPrestamo;
        private System.Windows.Forms.ComboBox cbxArtistasPrestamo;
        private System.Windows.Forms.ComboBox cbxObrasPrestamo;
    }
}