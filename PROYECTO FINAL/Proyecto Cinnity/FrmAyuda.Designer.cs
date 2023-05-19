namespace Proyecto_Cinnity
{
    partial class FrmAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyuda));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMiPerfil = new System.Windows.Forms.Button();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.ptbCorreo = new System.Windows.Forms.PictureBox();
            this.ptbTwitter = new System.Windows.Forms.PictureBox();
            this.ptbFacebook = new System.Windows.Forms.PictureBox();
            this.ptbInsta = new System.Windows.Forms.PictureBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblInformacion2 = new System.Windows.Forms.Label();
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnVolver);
            this.pnlMenu.Controls.Add(this.btnMiPerfil);
            this.pnlMenu.Location = new System.Drawing.Point(-5, -6);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1006, 64);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = global::Proyecto_Cinnity.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(929, 11);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(62, 50);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Image = global::Proyecto_Cinnity.Properties.Resources.casa__1_;
            this.btnVolver.Location = new System.Drawing.Point(852, 11);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(62, 50);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMiPerfil
            // 
            this.btnMiPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiPerfil.Image = global::Proyecto_Cinnity.Properties.Resources.usuario;
            this.btnMiPerfil.Location = new System.Drawing.Point(17, 11);
            this.btnMiPerfil.Name = "btnMiPerfil";
            this.btnMiPerfil.Size = new System.Drawing.Size(62, 50);
            this.btnMiPerfil.TabIndex = 0;
            this.btnMiPerfil.UseVisualStyleBackColor = false;
            this.btnMiPerfil.Click += new System.EventHandler(this.btnMiPerfil_Click);
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(37)))));
            this.pnlInformacion.Controls.Add(this.ptbCorreo);
            this.pnlInformacion.Controls.Add(this.ptbTwitter);
            this.pnlInformacion.Controls.Add(this.ptbFacebook);
            this.pnlInformacion.Controls.Add(this.ptbInsta);
            this.pnlInformacion.Controls.Add(this.ptbLogo);
            this.pnlInformacion.Location = new System.Drawing.Point(-5, 57);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(316, 802);
            this.pnlInformacion.TabIndex = 1;
            // 
            // ptbCorreo
            // 
            this.ptbCorreo.Image = global::Proyecto_Cinnity.Properties.Resources.gmail;
            this.ptbCorreo.Location = new System.Drawing.Point(125, 678);
            this.ptbCorreo.Name = "ptbCorreo";
            this.ptbCorreo.Size = new System.Drawing.Size(52, 50);
            this.ptbCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCorreo.TabIndex = 4;
            this.ptbCorreo.TabStop = false;
            // 
            // ptbTwitter
            // 
            this.ptbTwitter.Image = global::Proyecto_Cinnity.Properties.Resources.twitter;
            this.ptbTwitter.Location = new System.Drawing.Point(125, 592);
            this.ptbTwitter.Name = "ptbTwitter";
            this.ptbTwitter.Size = new System.Drawing.Size(52, 50);
            this.ptbTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTwitter.TabIndex = 3;
            this.ptbTwitter.TabStop = false;
            // 
            // ptbFacebook
            // 
            this.ptbFacebook.Image = global::Proyecto_Cinnity.Properties.Resources.facebook;
            this.ptbFacebook.Location = new System.Drawing.Point(125, 505);
            this.ptbFacebook.Name = "ptbFacebook";
            this.ptbFacebook.Size = new System.Drawing.Size(52, 50);
            this.ptbFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFacebook.TabIndex = 2;
            this.ptbFacebook.TabStop = false;
            // 
            // ptbInsta
            // 
            this.ptbInsta.Image = global::Proyecto_Cinnity.Properties.Resources.instagram;
            this.ptbInsta.Location = new System.Drawing.Point(125, 426);
            this.ptbInsta.Name = "ptbInsta";
            this.ptbInsta.Size = new System.Drawing.Size(52, 50);
            this.ptbInsta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbInsta.TabIndex = 1;
            this.ptbInsta.TabStop = false;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Proyecto_Cinnity.Properties.Resources.CINNITY;
            this.ptbLogo.Location = new System.Drawing.Point(38, 8);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(250, 250);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Myanmar Text", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblInformacion.Location = new System.Drawing.Point(334, 88);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(231, 50);
            this.lblInformacion.TabIndex = 2;
            this.lblInformacion.Text = "INFORMACIÓN:";
            // 
            // lblInformacion2
            // 
            this.lblInformacion2.AutoSize = true;
            this.lblInformacion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblInformacion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInformacion2.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion2.Location = new System.Drawing.Point(362, 156);
            this.lblInformacion2.Name = "lblInformacion2";
            this.lblInformacion2.Padding = new System.Windows.Forms.Padding(15);
            this.lblInformacion2.Size = new System.Drawing.Size(584, 180);
            this.lblInformacion2.TabIndex = 3;
            this.lblInformacion2.Text = resources.GetString("lblInformacion2.Text");
            // 
            // lblPreguntas
            // 
            this.lblPreguntas.AutoSize = true;
            this.lblPreguntas.Font = new System.Drawing.Font("Myanmar Text", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblPreguntas.Location = new System.Drawing.Point(334, 367);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(371, 50);
            this.lblPreguntas.TabIndex = 4;
            this.lblPreguntas.Text = "PREGUNTAS FRECUENTES:";
            // 
            // FrmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(998, 850);
            this.Controls.Add(this.lblPreguntas);
            this.Controls.Add(this.lblInformacion2);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.pnlInformacion);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmAyuda";
            this.Text = "Ayuda";
            this.pnlMenu.ResumeLayout(false);
            this.pnlInformacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMiPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblInformacion2;
        private System.Windows.Forms.PictureBox ptbCorreo;
        private System.Windows.Forms.PictureBox ptbTwitter;
        private System.Windows.Forms.PictureBox ptbFacebook;
        private System.Windows.Forms.PictureBox ptbInsta;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lblPreguntas;
    }
}