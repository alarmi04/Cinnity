namespace Proyecto_Cinnity
{
    partial class FrmGestionDeEntradas
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.btnMiPerfil = new System.Windows.Forms.Button();
            this.dgvEntradasActivas = new System.Windows.Forms.DataGridView();
            this.lblEntradasActivas = new System.Windows.Forms.Label();
            this.btnVenderEntrada = new System.Windows.Forms.Button();
            this.btnBuscarEntrada = new System.Windows.Forms.Button();
            this.lblIdEntrada = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.ptbImagenPeli = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradasActivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenPeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnVolverPrincipal);
            this.pnlMenu.Controls.Add(this.btnMiPerfil);
            this.pnlMenu.Location = new System.Drawing.Point(-2, -4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1334, 63);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnCerrarSesion.Image = global::Proyecto_Cinnity.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1248, 8);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(66, 50);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnVolverPrincipal
            // 
            this.btnVolverPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnVolverPrincipal.Image = global::Proyecto_Cinnity.Properties.Resources.casa__1_;
            this.btnVolverPrincipal.Location = new System.Drawing.Point(1162, 8);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(66, 50);
            this.btnVolverPrincipal.TabIndex = 4;
            this.btnVolverPrincipal.UseVisualStyleBackColor = false;
            this.btnVolverPrincipal.Click += new System.EventHandler(this.btnVolverPrincipal_Click);
            // 
            // btnMiPerfil
            // 
            this.btnMiPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnMiPerfil.Image = global::Proyecto_Cinnity.Properties.Resources.usuario;
            this.btnMiPerfil.Location = new System.Drawing.Point(14, 8);
            this.btnMiPerfil.Name = "btnMiPerfil";
            this.btnMiPerfil.Size = new System.Drawing.Size(66, 50);
            this.btnMiPerfil.TabIndex = 3;
            this.btnMiPerfil.UseVisualStyleBackColor = false;
            this.btnMiPerfil.Click += new System.EventHandler(this.btnMiPerfil_Click);
            // 
            // dgvEntradasActivas
            // 
            this.dgvEntradasActivas.AllowUserToAddRows = false;
            this.dgvEntradasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradasActivas.Location = new System.Drawing.Point(36, 191);
            this.dgvEntradasActivas.Name = "dgvEntradasActivas";
            this.dgvEntradasActivas.ReadOnly = true;
            this.dgvEntradasActivas.RowHeadersWidth = 51;
            this.dgvEntradasActivas.RowTemplate.Height = 24;
            this.dgvEntradasActivas.Size = new System.Drawing.Size(744, 265);
            this.dgvEntradasActivas.TabIndex = 1;
            this.dgvEntradasActivas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradasActivas_CellContentClick);
            // 
            // lblEntradasActivas
            // 
            this.lblEntradasActivas.AutoSize = true;
            this.lblEntradasActivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblEntradasActivas.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradasActivas.Location = new System.Drawing.Point(36, 93);
            this.lblEntradasActivas.Name = "lblEntradasActivas";
            this.lblEntradasActivas.Padding = new System.Windows.Forms.Padding(233, 30, 233, 30);
            this.lblEntradasActivas.Size = new System.Drawing.Size(726, 95);
            this.lblEntradasActivas.TabIndex = 2;
            this.lblEntradasActivas.Text = "ENTRADAS ACTIVAS";
            // 
            // btnVenderEntrada
            // 
            this.btnVenderEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnVenderEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderEntrada.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenderEntrada.Location = new System.Drawing.Point(522, 607);
            this.btnVenderEntrada.Name = "btnVenderEntrada";
            this.btnVenderEntrada.Size = new System.Drawing.Size(272, 84);
            this.btnVenderEntrada.TabIndex = 6;
            this.btnVenderEntrada.Text = "DEVOLVER ENTRADA";
            this.btnVenderEntrada.UseVisualStyleBackColor = false;
            this.btnVenderEntrada.Click += new System.EventHandler(this.btnVenderEntrada_Click);
            // 
            // btnBuscarEntrada
            // 
            this.btnBuscarEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnBuscarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEntrada.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEntrada.Location = new System.Drawing.Point(42, 607);
            this.btnBuscarEntrada.Name = "btnBuscarEntrada";
            this.btnBuscarEntrada.Size = new System.Drawing.Size(272, 84);
            this.btnBuscarEntrada.TabIndex = 5;
            this.btnBuscarEntrada.Text = "BUSCAR ENTRADA";
            this.btnBuscarEntrada.UseVisualStyleBackColor = false;
            this.btnBuscarEntrada.Click += new System.EventHandler(this.btnBuscarEntrada_Click);
            // 
            // lblIdEntrada
            // 
            this.lblIdEntrada.AutoSize = true;
            this.lblIdEntrada.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEntrada.ForeColor = System.Drawing.Color.White;
            this.lblIdEntrada.Location = new System.Drawing.Point(61, 540);
            this.lblIdEntrada.Name = "lblIdEntrada";
            this.lblIdEntrada.Size = new System.Drawing.Size(80, 24);
            this.lblIdEntrada.TabIndex = 3;
            this.lblIdEntrada.Text = "TÍTULO:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(160, 538);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(634, 32);
            this.txtTitulo.TabIndex = 4;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.White;
            this.lblInformacion.Location = new System.Drawing.Point(42, 472);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(384, 20);
            this.lblInformacion.TabIndex = 9;
            this.lblInformacion.Text = "Haz click en la entrada  para visualizar la película.";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Image = global::Proyecto_Cinnity.Properties.Resources.seleccionar_todo;
            this.btnMostrar.Location = new System.Drawing.Point(363, 607);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(108, 84);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // ptbImagenPeli
            // 
            this.ptbImagenPeli.Location = new System.Drawing.Point(887, 104);
            this.ptbImagenPeli.Name = "ptbImagenPeli";
            this.ptbImagenPeli.Size = new System.Drawing.Size(389, 567);
            this.ptbImagenPeli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagenPeli.TabIndex = 8;
            this.ptbImagenPeli.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(863, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(434, 606);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // FrmGestionDeEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1324, 719);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.ptbImagenPeli);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVenderEntrada);
            this.Controls.Add(this.btnBuscarEntrada);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblIdEntrada);
            this.Controls.Add(this.lblEntradasActivas);
            this.Controls.Add(this.dgvEntradasActivas);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmGestionDeEntradas";
            this.Text = "Gestión De Entradas";
            this.Load += new System.EventHandler(this.FrmGestionDeEntradas_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradasActivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenPeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.DataGridView dgvEntradasActivas;
        private System.Windows.Forms.Label lblEntradasActivas;
        private System.Windows.Forms.Button btnVenderEntrada;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMiPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnVolverPrincipal;
        private System.Windows.Forms.Button btnBuscarEntrada;
        private System.Windows.Forms.Label lblIdEntrada;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.PictureBox ptbImagenPeli;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnMostrar;
    }
}