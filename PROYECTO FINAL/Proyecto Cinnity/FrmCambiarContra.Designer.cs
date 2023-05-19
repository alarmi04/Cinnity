namespace Proyecto_Cinnity
{
    partial class FrmCambiarContra
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
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lblContraActual = new System.Windows.Forms.Label();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.lblNuevaContra = new System.Windows.Forms.Label();
            this.txtNuevaContra = new System.Windows.Forms.TextBox();
            this.lblConfirmaContra = new System.Windows.Forms.Label();
            this.txtConfirmaContra = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.errorCambiarContra = new System.Windows.Forms.ErrorProvider(this.components);
            this.chbMostrarContra = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCambiarContra)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Proyecto_Cinnity.Properties.Resources.CINNITY;
            this.ptbLogo.Location = new System.Drawing.Point(234, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(271, 258);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // lblContraActual
            // 
            this.lblContraActual.AutoSize = true;
            this.lblContraActual.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblContraActual.Location = new System.Drawing.Point(99, 300);
            this.lblContraActual.Name = "lblContraActual";
            this.lblContraActual.Size = new System.Drawing.Size(260, 36);
            this.lblContraActual.TabIndex = 2;
            this.lblContraActual.Text = "Escribe tu contraseña actual:";
            // 
            // txtContraActual
            // 
            this.txtContraActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.txtContraActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraActual.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraActual.Location = new System.Drawing.Point(384, 300);
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.PasswordChar = '*';
            this.txtContraActual.Size = new System.Drawing.Size(270, 32);
            this.txtContraActual.TabIndex = 3;
            // 
            // lblNuevaContra
            // 
            this.lblNuevaContra.AutoSize = true;
            this.lblNuevaContra.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblNuevaContra.Location = new System.Drawing.Point(99, 367);
            this.lblNuevaContra.Name = "lblNuevaContra";
            this.lblNuevaContra.Size = new System.Drawing.Size(260, 36);
            this.lblNuevaContra.TabIndex = 4;
            this.lblNuevaContra.Text = "Escribe tu nueva contraseña:";
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.txtNuevaContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNuevaContra.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaContra.Location = new System.Drawing.Point(384, 367);
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.PasswordChar = '*';
            this.txtNuevaContra.Size = new System.Drawing.Size(270, 32);
            this.txtNuevaContra.TabIndex = 5;
            // 
            // lblConfirmaContra
            // 
            this.lblConfirmaContra.AutoSize = true;
            this.lblConfirmaContra.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblConfirmaContra.Location = new System.Drawing.Point(80, 439);
            this.lblConfirmaContra.Name = "lblConfirmaContra";
            this.lblConfirmaContra.Size = new System.Drawing.Size(279, 36);
            this.lblConfirmaContra.TabIndex = 6;
            this.lblConfirmaContra.Text = "Confirma tu nueva contraseña:";
            // 
            // txtConfirmaContra
            // 
            this.txtConfirmaContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.txtConfirmaContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmaContra.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmaContra.Location = new System.Drawing.Point(384, 443);
            this.txtConfirmaContra.Name = "txtConfirmaContra";
            this.txtConfirmaContra.PasswordChar = '*';
            this.txtConfirmaContra.Size = new System.Drawing.Size(270, 32);
            this.txtConfirmaContra.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.btnAceptar.Location = new System.Drawing.Point(168, 550);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(420, 60);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "ACEPTAR Y CAMBIAR CONTRASEÑA";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // errorCambiarContra
            // 
            this.errorCambiarContra.ContainerControl = this;
            // 
            // chbMostrarContra
            // 
            this.chbMostrarContra.AutoSize = true;
            this.chbMostrarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMostrarContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.chbMostrarContra.Location = new System.Drawing.Point(384, 497);
            this.chbMostrarContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbMostrarContra.Name = "chbMostrarContra";
            this.chbMostrarContra.Size = new System.Drawing.Size(177, 24);
            this.chbMostrarContra.TabIndex = 11;
            this.chbMostrarContra.Text = "Mostrar contraseña";
            this.chbMostrarContra.UseVisualStyleBackColor = true;
            this.chbMostrarContra.Click += new System.EventHandler(this.chbMostrarContra_Click);
            // 
            // FrmCambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(741, 663);
            this.Controls.Add(this.chbMostrarContra);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtConfirmaContra);
            this.Controls.Add(this.lblConfirmaContra);
            this.Controls.Add(this.txtNuevaContra);
            this.Controls.Add(this.lblNuevaContra);
            this.Controls.Add(this.txtContraActual);
            this.Controls.Add(this.lblContraActual);
            this.Controls.Add(this.ptbLogo);
            this.Name = "FrmCambiarContra";
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.FrmCambiarContra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCambiarContra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lblContraActual;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.Label lblNuevaContra;
        private System.Windows.Forms.TextBox txtNuevaContra;
        private System.Windows.Forms.Label lblConfirmaContra;
        private System.Windows.Forms.TextBox txtConfirmaContra;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ErrorProvider errorCambiarContra;
        private System.Windows.Forms.CheckBox chbMostrarContra;
    }
}