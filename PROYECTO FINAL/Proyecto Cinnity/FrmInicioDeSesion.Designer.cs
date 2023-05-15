namespace Proyecto_Cinnity
{
    partial class FrmInicioDeSesion
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblContraOlvidada = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblUsuario.Location = new System.Drawing.Point(169, 299);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(204, 23);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "CORREO ELECTRÓNICO:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(173, 335);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(368, 21);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblContra.Location = new System.Drawing.Point(169, 394);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(130, 23);
            this.lblContra.TabIndex = 3;
            this.lblContra.Text = "CONTRASEÑA:";
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(173, 438);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(368, 21);
            this.txtContra.TabIndex = 4;
            // 
            // lblContraOlvidada
            // 
            this.lblContraOlvidada.AutoSize = true;
            this.lblContraOlvidada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraOlvidada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblContraOlvidada.Location = new System.Drawing.Point(236, 528);
            this.lblContraOlvidada.Name = "lblContraOlvidada";
            this.lblContraOlvidada.Size = new System.Drawing.Size(253, 17);
            this.lblContraOlvidada.TabIndex = 6;
            this.lblContraOlvidada.Text = "¿HAS OLVIDADO  TU CONTRASEÑA?";
            this.lblContraOlvidada.Click += new System.EventHandler(this.lblContraOlvidada_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.Location = new System.Drawing.Point(81, 612);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(176, 55);
            this.btnIniciarSesion.TabIndex = 7;
            this.btnIniciarSesion.Text = "INICIAR SESIÓN";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.Black;
            this.btnCrearCuenta.Location = new System.Drawing.Point(444, 612);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(176, 55);
            this.btnCrearCuenta.TabIndex = 8;
            this.btnCrearCuenta.Text = "CREAR MI CUENTA";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnIdioma
            // 
            this.btnIdioma.Image = global::Proyecto_Cinnity.Properties.Resources.traductor;
            this.btnIdioma.Location = new System.Drawing.Point(595, 32);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Size = new System.Drawing.Size(101, 95);
            this.btnIdioma.TabIndex = 9;
            this.btnIdioma.UseVisualStyleBackColor = true;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Proyecto_Cinnity.Properties.Resources.CINNITY;
            this.ptbLogo.Location = new System.Drawing.Point(230, 2);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(263, 250);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // FrmInicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(735, 691);
            this.Controls.Add(this.btnIdioma);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblContraOlvidada);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.ptbLogo);
            this.Name = "FrmInicioDeSesion";
            this.Text = "Inicio De Sesión";
            this.Load += new System.EventHandler(this.FrmInicioDeSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblContraOlvidada;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnIdioma;
    }
}

