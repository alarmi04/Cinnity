
namespace Proyecto_Cinnity
{
    partial class FrmCambiarDatos
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
            this.grbInformacionPersonal = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCambioDatos = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.errorCambiarDatos = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbInformacionPersonal.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCambiarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformacionPersonal
            // 
            this.grbInformacionPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.grbInformacionPersonal.Controls.Add(this.txtCorreo);
            this.grbInformacionPersonal.Controls.Add(this.txtApellidos);
            this.grbInformacionPersonal.Controls.Add(this.txtNombre);
            this.grbInformacionPersonal.Controls.Add(this.lblCorreo);
            this.grbInformacionPersonal.Controls.Add(this.lblApellidos);
            this.grbInformacionPersonal.Controls.Add(this.lblNombre);
            this.grbInformacionPersonal.Controls.Add(this.lblCambioDatos);
            this.grbInformacionPersonal.Location = new System.Drawing.Point(114, 99);
            this.grbInformacionPersonal.Name = "grbInformacionPersonal";
            this.grbInformacionPersonal.Size = new System.Drawing.Size(435, 391);
            this.grbInformacionPersonal.TabIndex = 3;
            this.grbInformacionPersonal.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(22, 320);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(365, 28);
            this.txtCorreo.TabIndex = 16;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(21, 219);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(366, 28);
            this.txtApellidos.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(24, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(363, 28);
            this.txtNombre.TabIndex = 13;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(17, 274);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(175, 24);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(17, 171);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(94, 24);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 24);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCambioDatos
            // 
            this.lblCambioDatos.AutoSize = true;
            this.lblCambioDatos.Font = new System.Drawing.Font("Candara", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambioDatos.Location = new System.Drawing.Point(90, 18);
            this.lblCambioDatos.Name = "lblCambioDatos";
            this.lblCambioDatos.Size = new System.Drawing.Size(263, 35);
            this.lblCambioDatos.TabIndex = 1;
            this.lblCambioDatos.Text = "CAMBIAR MIS DATOS";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Black;
            this.btnAceptar.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(190, 510);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(277, 72);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "ACEPTAR Y MODIFICAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnVolverPrincipal);
            this.pnlMenu.Location = new System.Drawing.Point(-2, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(646, 70);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::Proyecto_Cinnity.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(563, 12);
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
            this.btnVolverPrincipal.Location = new System.Drawing.Point(485, 12);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(66, 50);
            this.btnVolverPrincipal.TabIndex = 5;
            this.btnVolverPrincipal.UseVisualStyleBackColor = false;
            this.btnVolverPrincipal.Click += new System.EventHandler(this.btnVolverPrincipal_Click);
            // 
            // errorCambiarDatos
            // 
            this.errorCambiarDatos.ContainerControl = this;
            // 
            // FrmCambiarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(639, 609);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.grbInformacionPersonal);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmCambiarDatos";
            this.Text = "FrmCambiarDatos";
            this.grbInformacionPersonal.ResumeLayout(false);
            this.grbInformacionPersonal.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorCambiarDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacionPersonal;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCambioDatos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVolverPrincipal;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.ErrorProvider errorCambiarDatos;
    }
}