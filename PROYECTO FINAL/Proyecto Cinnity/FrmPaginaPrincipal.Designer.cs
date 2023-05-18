namespace Proyecto_Cinnity
{
    partial class FrmPaginaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaginaPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnMiPerfil = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.ptbEmail = new System.Windows.Forms.PictureBox();
            this.ptbTwitter = new System.Windows.Forms.PictureBox();
            this.ptbFacebook = new System.Windows.Forms.PictureBox();
            this.ptbInsta = new System.Windows.Forms.PictureBox();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.pnlPeliculas = new System.Windows.Forms.Panel();
            this.pnlMantenimiento = new System.Windows.Forms.Panel();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtContraAdmin = new System.Windows.Forms.TextBox();
            this.lblContraAdmin = new System.Windows.Forms.Label();
            this.peliculaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.peliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInsta)).BeginInit();
            this.pnlMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.pnlMenu.Controls.Add(this.btnMantenimiento);
            this.pnlMenu.Controls.Add(this.ptbLogo);
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnAyuda);
            this.pnlMenu.Controls.Add(this.btnEntradas);
            this.pnlMenu.Controls.Add(this.btnMiPerfil);
            this.pnlMenu.Location = new System.Drawing.Point(-9, -3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(294, 796);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Image = global::Proyecto_Cinnity.Properties.Resources.configuraciones;
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMantenimiento.Location = new System.Drawing.Point(5, 600);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(289, 50);
            this.btnMantenimiento.TabIndex = 6;
            this.btnMantenimiento.Text = "MANTENIMIENTO";
            this.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Proyecto_Cinnity.Properties.Resources.CINNITY1;
            this.ptbLogo.Location = new System.Drawing.Point(48, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(207, 212);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 5;
            this.ptbLogo.TabStop = false;
            this.ptbLogo.Click += new System.EventHandler(this.ptbLogo_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Image = global::Proyecto_Cinnity.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(5, 521);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(289, 50);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "CERRAR SESIÓN";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Image = global::Proyecto_Cinnity.Properties.Resources.informacion;
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAyuda.Location = new System.Drawing.Point(5, 441);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(289, 53);
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnEntradas
            // 
            this.btnEntradas.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.Image = global::Proyecto_Cinnity.Properties.Resources.billete;
            this.btnEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntradas.Location = new System.Drawing.Point(5, 359);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(289, 53);
            this.btnEntradas.TabIndex = 2;
            this.btnEntradas.Text = "ENTRADAS";
            this.btnEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
            // 
            // btnMiPerfil
            // 
            this.btnMiPerfil.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiPerfil.Image = global::Proyecto_Cinnity.Properties.Resources.usuario;
            this.btnMiPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMiPerfil.Location = new System.Drawing.Point(5, 277);
            this.btnMiPerfil.Name = "btnMiPerfil";
            this.btnMiPerfil.Size = new System.Drawing.Size(289, 52);
            this.btnMiPerfil.TabIndex = 1;
            this.btnMiPerfil.Text = "MI PERFIL";
            this.btnMiPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiPerfil.UseVisualStyleBackColor = true;
            this.btnMiPerfil.Click += new System.EventHandler(this.btnMiPerfil_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(338, 149);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(270, 32);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnCarrito
            // 
            this.btnCarrito.Image = global::Proyecto_Cinnity.Properties.Resources.carrito_de_compras;
            this.btnCarrito.Location = new System.Drawing.Point(1076, 12);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(99, 89);
            this.btnCarrito.TabIndex = 15;
            this.btnCarrito.UseVisualStyleBackColor = true;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // btnIdioma
            // 
            this.btnIdioma.Image = global::Proyecto_Cinnity.Properties.Resources.traductor;
            this.btnIdioma.Location = new System.Drawing.Point(955, 12);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Size = new System.Drawing.Size(101, 89);
            this.btnIdioma.TabIndex = 14;
            this.btnIdioma.UseVisualStyleBackColor = true;
            // 
            // ptbEmail
            // 
            this.ptbEmail.Image = ((System.Drawing.Image)(resources.GetObject("ptbEmail.Image")));
            this.ptbEmail.Location = new System.Drawing.Point(1100, 720);
            this.ptbEmail.Name = "ptbEmail";
            this.ptbEmail.Size = new System.Drawing.Size(32, 32);
            this.ptbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbEmail.TabIndex = 12;
            this.ptbEmail.TabStop = false;
            this.ptbEmail.Click += new System.EventHandler(this.ptbEmail_Click);
            // 
            // ptbTwitter
            // 
            this.ptbTwitter.Image = ((System.Drawing.Image)(resources.GetObject("ptbTwitter.Image")));
            this.ptbTwitter.Location = new System.Drawing.Point(1046, 720);
            this.ptbTwitter.Name = "ptbTwitter";
            this.ptbTwitter.Size = new System.Drawing.Size(32, 32);
            this.ptbTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbTwitter.TabIndex = 11;
            this.ptbTwitter.TabStop = false;
            this.ptbTwitter.Click += new System.EventHandler(this.ptbTwitter_Click);
            // 
            // ptbFacebook
            // 
            this.ptbFacebook.Image = ((System.Drawing.Image)(resources.GetObject("ptbFacebook.Image")));
            this.ptbFacebook.Location = new System.Drawing.Point(993, 720);
            this.ptbFacebook.Name = "ptbFacebook";
            this.ptbFacebook.Size = new System.Drawing.Size(32, 32);
            this.ptbFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbFacebook.TabIndex = 10;
            this.ptbFacebook.TabStop = false;
            this.ptbFacebook.Click += new System.EventHandler(this.ptbFacebook_Click);
            // 
            // ptbInsta
            // 
            this.ptbInsta.Image = global::Proyecto_Cinnity.Properties.Resources.instagram;
            this.ptbInsta.Location = new System.Drawing.Point(939, 720);
            this.ptbInsta.Name = "ptbInsta";
            this.ptbInsta.Size = new System.Drawing.Size(32, 32);
            this.ptbInsta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbInsta.TabIndex = 2;
            this.ptbInsta.TabStop = false;
            this.ptbInsta.Click += new System.EventHandler(this.ptbInsta_Click);
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Items.AddRange(new object[] {
            "Accion",
            "Animacion",
            "Terror",
            "Todas"});
            this.cmbFiltrar.Location = new System.Drawing.Point(614, 149);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(121, 32);
            this.cmbFiltrar.TabIndex = 16;
            this.cmbFiltrar.Text = "Filtrar...";
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrar_SelectedIndexChanged);
            // 
            // pnlPeliculas
            // 
            this.pnlPeliculas.AutoScroll = true;
            this.pnlPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.pnlPeliculas.Location = new System.Drawing.Point(338, 193);
            this.pnlPeliculas.Name = "pnlPeliculas";
            this.pnlPeliculas.Size = new System.Drawing.Size(200, 100);
            this.pnlPeliculas.TabIndex = 0;
            // 
            // pnlMantenimiento
            // 
            this.pnlMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.pnlMantenimiento.Controls.Add(this.btnAcceder);
            this.pnlMantenimiento.Controls.Add(this.txtContraAdmin);
            this.pnlMantenimiento.Controls.Add(this.lblContraAdmin);
            this.pnlMantenimiento.Location = new System.Drawing.Point(312, 12);
            this.pnlMantenimiento.Name = "pnlMantenimiento";
            this.pnlMantenimiento.Size = new System.Drawing.Size(613, 105);
            this.pnlMantenimiento.TabIndex = 17;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnAcceder.Location = new System.Drawing.Point(479, 33);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(114, 38);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txtContraAdmin
            // 
            this.txtContraAdmin.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraAdmin.Location = new System.Drawing.Point(195, 39);
            this.txtContraAdmin.Name = "txtContraAdmin";
            this.txtContraAdmin.Size = new System.Drawing.Size(250, 32);
            this.txtContraAdmin.TabIndex = 1;
            // 
            // lblContraAdmin
            // 
            this.lblContraAdmin.AutoSize = true;
            this.lblContraAdmin.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraAdmin.Location = new System.Drawing.Point(16, 39);
            this.lblContraAdmin.Name = "lblContraAdmin";
            this.lblContraAdmin.Size = new System.Drawing.Size(164, 29);
            this.lblContraAdmin.TabIndex = 0;
            this.lblContraAdmin.Text = "CONTRASEÑA:";
            // 
            // peliculaBindingSource1
            // 
            this.peliculaBindingSource1.DataSource = typeof(Proyecto_Cinnity.Pelicula);
            // 
            // peliculaBindingSource
            // 
            this.peliculaBindingSource.DataSource = typeof(Proyecto_Cinnity.Pelicula);
            // 
            // FrmPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1195, 790);
            this.Controls.Add(this.pnlMantenimiento);
            this.Controls.Add(this.pnlPeliculas);
            this.Controls.Add(this.cmbFiltrar);
            this.Controls.Add(this.btnCarrito);
            this.Controls.Add(this.btnIdioma);
            this.Controls.Add(this.ptbEmail);
            this.Controls.Add(this.ptbTwitter);
            this.Controls.Add(this.ptbFacebook);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.ptbInsta);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmPaginaPrincipal";
            this.Text = "Página Principal";
            this.Load += new System.EventHandler(this.FrmPaginaPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInsta)).EndInit();
            this.pnlMantenimiento.ResumeLayout(false);
            this.pnlMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peliculaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnMiPerfil;
        private System.Windows.Forms.PictureBox ptbInsta;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox ptbFacebook;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.PictureBox ptbTwitter;
        private System.Windows.Forms.PictureBox ptbEmail;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Button btnIdioma;
        private System.Windows.Forms.BindingSource peliculaBindingSource1;
        private System.Windows.Forms.BindingSource peliculaBindingSource;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.Panel pnlPeliculas;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Panel pnlMantenimiento;
        private System.Windows.Forms.TextBox txtContraAdmin;
        private System.Windows.Forms.Label lblContraAdmin;
        private System.Windows.Forms.Button btnAcceder;
    }
}