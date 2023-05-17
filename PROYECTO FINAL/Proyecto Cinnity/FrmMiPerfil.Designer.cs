namespace Proyecto_Cinnity
{
    partial class FrmMiPerfil
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlInformacionPerfil = new System.Windows.Forms.Panel();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCambiarContra = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblEntradasAdquiridas = new System.Windows.Forms.Label();
            this.dgvEntradasActivas = new System.Windows.Forms.DataGridView();
            this.lblEditarInformacion = new System.Windows.Forms.Label();
            this.lblMetodosDePago = new System.Windows.Forms.Label();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlInformacionPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradasActivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnVolverPrincipal);
            this.pnlMenu.Location = new System.Drawing.Point(-2, -2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1211, 70);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlInformacionPerfil
            // 
            this.pnlInformacionPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacionPerfil.Controls.Add(this.lblCorreo);
            this.pnlInformacionPerfil.Controls.Add(this.lblCambiarContra);
            this.pnlInformacionPerfil.Controls.Add(this.lblNombreUsuario);
            this.pnlInformacionPerfil.Controls.Add(this.ptbFoto);
            this.pnlInformacionPerfil.Location = new System.Drawing.Point(48, 91);
            this.pnlInformacionPerfil.Name = "pnlInformacionPerfil";
            this.pnlInformacionPerfil.Size = new System.Drawing.Size(472, 549);
            this.pnlInformacionPerfil.TabIndex = 2;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblCorreo.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblCorreo.Location = new System.Drawing.Point(109, 352);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(266, 37);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "correo@gmail.com";
            // 
            // lblCambiarContra
            // 
            this.lblCambiarContra.AutoSize = true;
            this.lblCambiarContra.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblCambiarContra.Location = new System.Drawing.Point(121, 485);
            this.lblCambiarContra.Name = "lblCambiarContra";
            this.lblCambiarContra.Size = new System.Drawing.Size(254, 35);
            this.lblCambiarContra.TabIndex = 8;
            this.lblCambiarContra.Text = "Cambiar Contraseña";
            this.lblCambiarContra.Click += new System.EventHandler(this.lblCambiarContra_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblNombreUsuario.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(165, 293);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(147, 37);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Username";
            // 
            // lblEntradasAdquiridas
            // 
            this.lblEntradasAdquiridas.AutoSize = true;
            this.lblEntradasAdquiridas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblEntradasAdquiridas.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradasAdquiridas.Location = new System.Drawing.Point(568, 93);
            this.lblEntradasAdquiridas.Name = "lblEntradasAdquiridas";
            this.lblEntradasAdquiridas.Padding = new System.Windows.Forms.Padding(142, 30, 142, 30);
            this.lblEntradasAdquiridas.Size = new System.Drawing.Size(598, 95);
            this.lblEntradasAdquiridas.TabIndex = 5;
            this.lblEntradasAdquiridas.Text = "ENTRADAS ADQUIRIDAS";
            // 
            // dgvEntradasActivas
            // 
            this.dgvEntradasActivas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.dgvEntradasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradasActivas.Location = new System.Drawing.Point(568, 191);
            this.dgvEntradasActivas.Name = "dgvEntradasActivas";
            this.dgvEntradasActivas.RowHeadersWidth = 51;
            this.dgvEntradasActivas.RowTemplate.Height = 24;
            this.dgvEntradasActivas.Size = new System.Drawing.Size(598, 265);
            this.dgvEntradasActivas.TabIndex = 4;
            // 
            // lblEditarInformacion
            // 
            this.lblEditarInformacion.AutoSize = true;
            this.lblEditarInformacion.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblEditarInformacion.Location = new System.Drawing.Point(562, 521);
            this.lblEditarInformacion.Name = "lblEditarInformacion";
            this.lblEditarInformacion.Size = new System.Drawing.Size(236, 35);
            this.lblEditarInformacion.TabIndex = 6;
            this.lblEditarInformacion.Text = "Editar Información";
            this.lblEditarInformacion.Click += new System.EventHandler(this.lblEditarInformacion_Click);
            // 
            // lblMetodosDePago
            // 
            this.lblMetodosDePago.AutoSize = true;
            this.lblMetodosDePago.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodosDePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblMetodosDePago.Location = new System.Drawing.Point(568, 593);
            this.lblMetodosDePago.Name = "lblMetodosDePago";
            this.lblMetodosDePago.Size = new System.Drawing.Size(223, 35);
            this.lblMetodosDePago.TabIndex = 7;
            this.lblMetodosDePago.Text = "Métodos de Pago";
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.BackColor = System.Drawing.Color.Black;
            this.lblTotalEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalEntradas.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblTotalEntradas.Location = new System.Drawing.Point(932, 593);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalEntradas.Size = new System.Drawing.Size(209, 47);
            this.lblTotalEntradas.TabIndex = 9;
            this.lblTotalEntradas.Text = "Total Entradas: ";
            // 
            // ptbFoto
            // 
            this.ptbFoto.Image = global::Proyecto_Cinnity.Properties.Resources.perfil__1_;
            this.ptbFoto.Location = new System.Drawing.Point(116, 35);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(243, 236);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoto.TabIndex = 0;
            this.ptbFoto.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = global::Proyecto_Cinnity.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1128, 14);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(66, 50);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnVolverPrincipal
            // 
            this.btnVolverPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnVolverPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverPrincipal.Image = global::Proyecto_Cinnity.Properties.Resources.casa__1_;
            this.btnVolverPrincipal.Location = new System.Drawing.Point(1040, 14);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(66, 50);
            this.btnVolverPrincipal.TabIndex = 5;
            this.btnVolverPrincipal.UseVisualStyleBackColor = false;
            this.btnVolverPrincipal.Click += new System.EventHandler(this.btnVolverPrincipal_Click);
            // 
            // FrmMiPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1204, 702);
            this.Controls.Add(this.lblTotalEntradas);
            this.Controls.Add(this.lblMetodosDePago);
            this.Controls.Add(this.lblEditarInformacion);
            this.Controls.Add(this.lblEntradasAdquiridas);
            this.Controls.Add(this.dgvEntradasActivas);
            this.Controls.Add(this.pnlInformacionPerfil);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmMiPerfil";
            this.Text = "Mi Perfil";
            this.Load += new System.EventHandler(this.FrmMiPerfil_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlInformacionPerfil.ResumeLayout(false);
            this.pnlInformacionPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradasActivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnVolverPrincipal;
        private System.Windows.Forms.Panel pnlInformacionPerfil;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblEntradasAdquiridas;
        private System.Windows.Forms.DataGridView dgvEntradasActivas;
        private System.Windows.Forms.Label lblEditarInformacion;
        private System.Windows.Forms.Label lblMetodosDePago;
        private System.Windows.Forms.Label lblCambiarContra;
        private System.Windows.Forms.Label lblTotalEntradas;
    }
}