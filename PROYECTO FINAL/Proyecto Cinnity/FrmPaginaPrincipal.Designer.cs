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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaginaPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.clbFiltrar = new System.Windows.Forms.CheckedListBox();
            this.grbPeliculas = new System.Windows.Forms.GroupBox();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.ptbEmail = new System.Windows.Forms.PictureBox();
            this.ptbTwitter = new System.Windows.Forms.PictureBox();
            this.ptbFacebook = new System.Windows.Forms.PictureBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.ptbInsta = new System.Windows.Forms.PictureBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnMiPerfil = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.grbPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
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
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Candara Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(291, 120);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(270, 40);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // clbFiltrar
            // 
            this.clbFiltrar.FormattingEnabled = true;
            this.clbFiltrar.Items.AddRange(new object[] {
            "Terror",
            "Acción",
            "Comedia",
            "Mayor de edad"});
            this.clbFiltrar.Location = new System.Drawing.Point(276, 9);
            this.clbFiltrar.Name = "clbFiltrar";
            this.clbFiltrar.Size = new System.Drawing.Size(180, 174);
            this.clbFiltrar.TabIndex = 8;
            // 
            // grbPeliculas
            // 
            this.grbPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.grbPeliculas.Controls.Add(this.clbFiltrar);
            this.grbPeliculas.Location = new System.Drawing.Point(291, 170);
            this.grbPeliculas.Name = "grbPeliculas";
            this.grbPeliculas.Size = new System.Drawing.Size(884, 513);
            this.grbPeliculas.TabIndex = 13;
            this.grbPeliculas.TabStop = false;
            // 
            // btnCarrito
            // 
            this.btnCarrito.Image = global::Proyecto_Cinnity.Properties.Resources.carrito_de_compras;
            this.btnCarrito.Location = new System.Drawing.Point(1076, 12);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(99, 89);
            this.btnCarrito.TabIndex = 15;
            this.btnCarrito.UseVisualStyleBackColor = true;
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
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::Proyecto_Cinnity.Properties.Resources.filtrar;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(567, 120);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(150, 44);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar...";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
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
            // 
            // FrmPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1187, 790);
            this.Controls.Add(this.btnCarrito);
            this.Controls.Add(this.btnIdioma);
            this.Controls.Add(this.grbPeliculas);
            this.Controls.Add(this.ptbEmail);
            this.Controls.Add(this.ptbTwitter);
            this.Controls.Add(this.ptbFacebook);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.ptbInsta);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmPaginaPrincipal";
            this.Text = "Página Principal";
            this.Load += new System.EventHandler(this.FrmPaginaPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.grbPeliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
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
        private System.Windows.Forms.CheckedListBox clbFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.PictureBox ptbFacebook;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.PictureBox ptbTwitter;
        private System.Windows.Forms.PictureBox ptbEmail;
        private System.Windows.Forms.GroupBox grbPeliculas;
        private System.Windows.Forms.Button btnCarrito;
        private System.Windows.Forms.Button btnIdioma;
    }
}