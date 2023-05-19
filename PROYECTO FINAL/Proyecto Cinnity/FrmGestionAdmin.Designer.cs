
namespace Proyecto_Cinnity
{
    partial class FrmGestionAdmin
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
            this.gbInfoPeli = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.lblMin = new System.Windows.Forms.Label();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtReparto = new System.Windows.Forms.TextBox();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblReparto = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.btnMiPerfil = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.errorGestionAdmin = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repartoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionMinutosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopsisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEstrenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbInfoPeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorGestionAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoPeli
            // 
            this.gbInfoPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.gbInfoPeli.Controls.Add(this.txtId);
            this.gbInfoPeli.Controls.Add(this.lblId);
            this.gbInfoPeli.Controls.Add(this.dtpFechaEstreno);
            this.gbInfoPeli.Controls.Add(this.lblMin);
            this.gbInfoPeli.Controls.Add(this.nudDuracion);
            this.gbInfoPeli.Controls.Add(this.txtDirector);
            this.gbInfoPeli.Controls.Add(this.txtGenero);
            this.gbInfoPeli.Controls.Add(this.txtTitulo);
            this.gbInfoPeli.Controls.Add(this.txtReparto);
            this.gbInfoPeli.Controls.Add(this.lblTítulo);
            this.gbInfoPeli.Controls.Add(this.txtSinopsis);
            this.gbInfoPeli.Controls.Add(this.lblFechaEstreno);
            this.gbInfoPeli.Controls.Add(this.lblSinopsis);
            this.gbInfoPeli.Controls.Add(this.lblDuracion);
            this.gbInfoPeli.Controls.Add(this.lblReparto);
            this.gbInfoPeli.Controls.Add(this.lblDirector);
            this.gbInfoPeli.Controls.Add(this.lblGenero);
            this.gbInfoPeli.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.gbInfoPeli.Location = new System.Drawing.Point(41, 94);
            this.gbInfoPeli.Name = "gbInfoPeli";
            this.gbInfoPeli.Size = new System.Drawing.Size(745, 825);
            this.gbInfoPeli.TabIndex = 1;
            this.gbInfoPeli.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(156, 41);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(120, 25);
            this.txtId.TabIndex = 23;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblId.Location = new System.Drawing.Point(40, 44);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(104, 24);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "ID Película:";
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEstreno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstreno.Location = new System.Drawing.Point(213, 144);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(149, 25);
            this.dtpFechaEstreno.TabIndex = 2;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblMin.Location = new System.Drawing.Point(288, 187);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(48, 24);
            this.lblMin.TabIndex = 21;
            this.lblMin.Text = "min.";
            // 
            // nudDuracion
            // 
            this.nudDuracion.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDuracion.Location = new System.Drawing.Point(144, 186);
            this.nudDuracion.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(120, 25);
            this.nudDuracion.TabIndex = 20;
            this.nudDuracion.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtDirector
            // 
            this.txtDirector.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Location = new System.Drawing.Point(384, 97);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(326, 25);
            this.txtDirector.TabIndex = 19;
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(122, 94);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(154, 25);
            this.txtGenero.TabIndex = 18;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(360, 41);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(350, 25);
            this.txtTitulo.TabIndex = 17;
            // 
            // txtReparto
            // 
            this.txtReparto.BackColor = System.Drawing.Color.White;
            this.txtReparto.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReparto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtReparto.Location = new System.Drawing.Point(43, 279);
            this.txtReparto.Multiline = true;
            this.txtReparto.Name = "txtReparto";
            this.txtReparto.Size = new System.Drawing.Size(666, 142);
            this.txtReparto.TabIndex = 16;
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblTítulo.Location = new System.Drawing.Point(288, 44);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(65, 24);
            this.lblTítulo.TabIndex = 15;
            this.lblTítulo.Text = "Título:";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BackColor = System.Drawing.Color.White;
            this.txtSinopsis.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtSinopsis.Location = new System.Drawing.Point(43, 491);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(666, 298);
            this.txtSinopsis.TabIndex = 14;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblFechaEstreno.Location = new System.Drawing.Point(39, 144);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(159, 24);
            this.lblFechaEstreno.TabIndex = 13;
            this.lblFechaEstreno.Text = "Fecha de estreno:";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblSinopsis.Location = new System.Drawing.Point(39, 455);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(84, 24);
            this.lblSinopsis.TabIndex = 12;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblDuracion.Location = new System.Drawing.Point(40, 187);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(93, 24);
            this.lblDuracion.TabIndex = 11;
            this.lblDuracion.Text = "Duración:";
            // 
            // lblReparto
            // 
            this.lblReparto.AutoSize = true;
            this.lblReparto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblReparto.Location = new System.Drawing.Point(39, 234);
            this.lblReparto.Name = "lblReparto";
            this.lblReparto.Size = new System.Drawing.Size(84, 24);
            this.lblReparto.TabIndex = 10;
            this.lblReparto.Text = "Reparto:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblDirector.Location = new System.Drawing.Point(288, 97);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(86, 24);
            this.lblDirector.TabIndex = 9;
            this.lblDirector.Text = "Director:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblGenero.Location = new System.Drawing.Point(39, 97);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(77, 24);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Género:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(1508, 281);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(223, 60);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.groupBox1.Controls.Add(this.ptbImagen);
            this.groupBox1.Controls.Add(this.btnCargarImagen);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.groupBox1.Location = new System.Drawing.Point(814, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 247);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(384, 22);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(185, 207);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagen.TabIndex = 6;
            this.ptbImagen.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnCargarImagen.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnCargarImagen.Location = new System.Drawing.Point(38, 96);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(289, 57);
            this.btnCargarImagen.TabIndex = 5;
            this.btnCargarImagen.Text = "Seleccionar imagen...";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AutoGenerateColumns = false;
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeliculas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.directorDataGridViewTextBoxColumn,
            this.repartoDataGridViewTextBoxColumn,
            this.duracionMinutosDataGridViewTextBoxColumn,
            this.sinopsisDataGridViewTextBoxColumn,
            this.fechaEstrenoDataGridViewTextBoxColumn});
            this.dgvPeliculas.DataSource = this.peliculaBindingSource;
            this.dgvPeliculas.Location = new System.Drawing.Point(814, 373);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.RowHeadersWidth = 51;
            this.dgvPeliculas.RowTemplate.Height = 24;
            this.dgvPeliculas.Size = new System.Drawing.Size(917, 491);
            this.dgvPeliculas.TabIndex = 5;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnVolverPrincipal);
            this.pnlMenu.Controls.Add(this.btnMiPerfil);
            this.pnlMenu.Location = new System.Drawing.Point(-1, -1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1791, 68);
            this.pnlMenu.TabIndex = 6;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::Proyecto_Cinnity.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1690, 10);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(66, 50);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnVolverPrincipal
            // 
            this.btnVolverPrincipal.BackColor = System.Drawing.Color.White;
            this.btnVolverPrincipal.Image = global::Proyecto_Cinnity.Properties.Resources.casa__1_;
            this.btnVolverPrincipal.Location = new System.Drawing.Point(1611, 10);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(66, 50);
            this.btnVolverPrincipal.TabIndex = 5;
            this.btnVolverPrincipal.UseVisualStyleBackColor = false;
            this.btnVolverPrincipal.Click += new System.EventHandler(this.btnVolverPrincipal_Click);
            // 
            // btnMiPerfil
            // 
            this.btnMiPerfil.BackColor = System.Drawing.Color.White;
            this.btnMiPerfil.Image = global::Proyecto_Cinnity.Properties.Resources.usuario;
            this.btnMiPerfil.Location = new System.Drawing.Point(13, 10);
            this.btnMiPerfil.Name = "btnMiPerfil";
            this.btnMiPerfil.Size = new System.Drawing.Size(66, 50);
            this.btnMiPerfil.TabIndex = 0;
            this.btnMiPerfil.UseVisualStyleBackColor = false;
            this.btnMiPerfil.Click += new System.EventHandler(this.btnMiPerfil_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location = new System.Drawing.Point(1508, 188);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(223, 59);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // errorGestionAdmin
            // 
            this.errorGestionAdmin.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Location = new System.Drawing.Point(1508, 94);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(223, 59);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar Información";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.White;
            this.lblInformacion.Location = new System.Drawing.Point(810, 883);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(357, 20);
            this.lblInformacion.TabIndex = 10;
            this.lblInformacion.Text = "Haz click en una fila para modificar la película.";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            this.directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            this.directorDataGridViewTextBoxColumn.HeaderText = "Director";
            this.directorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            // 
            // repartoDataGridViewTextBoxColumn
            // 
            this.repartoDataGridViewTextBoxColumn.DataPropertyName = "Reparto";
            this.repartoDataGridViewTextBoxColumn.HeaderText = "Reparto";
            this.repartoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.repartoDataGridViewTextBoxColumn.Name = "repartoDataGridViewTextBoxColumn";
            // 
            // duracionMinutosDataGridViewTextBoxColumn
            // 
            this.duracionMinutosDataGridViewTextBoxColumn.DataPropertyName = "DuracionMinutos";
            this.duracionMinutosDataGridViewTextBoxColumn.HeaderText = "DuracionMinutos";
            this.duracionMinutosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duracionMinutosDataGridViewTextBoxColumn.Name = "duracionMinutosDataGridViewTextBoxColumn";
            // 
            // sinopsisDataGridViewTextBoxColumn
            // 
            this.sinopsisDataGridViewTextBoxColumn.DataPropertyName = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.HeaderText = "Sinopsis";
            this.sinopsisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinopsisDataGridViewTextBoxColumn.Name = "sinopsisDataGridViewTextBoxColumn";
            // 
            // fechaEstrenoDataGridViewTextBoxColumn
            // 
            this.fechaEstrenoDataGridViewTextBoxColumn.DataPropertyName = "FechaEstreno";
            this.fechaEstrenoDataGridViewTextBoxColumn.HeaderText = "FechaEstreno";
            this.fechaEstrenoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaEstrenoDataGridViewTextBoxColumn.Name = "fechaEstrenoDataGridViewTextBoxColumn";
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataSource = typeof(Proyecto_Cinnity.Pelicula);
            // 
            // FrmGestionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1767, 936);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbInfoPeli);
            this.Name = "FrmGestionAdmin";
            this.Text = "FrmGestionAdmin";
            this.Load += new System.EventHandler(this.FrmGestionAdmin_Load);
            this.gbInfoPeli.ResumeLayout(false);
            this.gbInfoPeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorGestionAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoPeli;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtReparto;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblReparto;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptbImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnVolverPrincipal;
        private System.Windows.Forms.Button btnMiPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repartoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionMinutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopsisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEstrenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ErrorProvider errorGestionAdmin;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblInformacion;
    }
}