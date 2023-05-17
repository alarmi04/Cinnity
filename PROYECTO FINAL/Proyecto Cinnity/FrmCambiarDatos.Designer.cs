
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
            this.grbInformacionPersonal = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCambioDatos = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.cmbSeleccionarApariencia = new System.Windows.Forms.ComboBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.ptbApariencia = new System.Windows.Forms.PictureBox();
            this.grbInformacionPersonal.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbApariencia)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformacionPersonal
            // 
            this.grbInformacionPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.grbInformacionPersonal.Controls.Add(this.cmbSeleccionarApariencia);
            this.grbInformacionPersonal.Controls.Add(this.ptbApariencia);
            this.grbInformacionPersonal.Controls.Add(this.lblImagen);
            this.grbInformacionPersonal.Controls.Add(this.txtCorreo);
            this.grbInformacionPersonal.Controls.Add(this.txtApellidos);
            this.grbInformacionPersonal.Controls.Add(this.txtNombre);
            this.grbInformacionPersonal.Controls.Add(this.lblCorreo);
            this.grbInformacionPersonal.Controls.Add(this.lblApellidos);
            this.grbInformacionPersonal.Controls.Add(this.lblNombre);
            this.grbInformacionPersonal.Controls.Add(this.lblCambioDatos);
            this.grbInformacionPersonal.Location = new System.Drawing.Point(114, 99);
            this.grbInformacionPersonal.Name = "grbInformacionPersonal";
            this.grbInformacionPersonal.Size = new System.Drawing.Size(989, 391);
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
            this.lblCambioDatos.Location = new System.Drawing.Point(357, 18);
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
            this.btnAceptar.Location = new System.Drawing.Point(447, 514);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(277, 72);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "ACEPTAR Y MODIFICAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(684, 69);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(107, 24);
            this.lblImagen.TabIndex = 17;
            this.lblImagen.Text = "Apariencia:";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnVolverPrincipal);
            this.pnlMenu.Location = new System.Drawing.Point(-2, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1200, 70);
            this.pnlMenu.TabIndex = 4;
            // 
            // cmbSeleccionarApariencia
            // 
            this.cmbSeleccionarApariencia.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Femenino"});
            this.cmbSeleccionarApariencia.FormattingEnabled = true;
            this.cmbSeleccionarApariencia.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSeleccionarApariencia.Location = new System.Drawing.Point(663, 320);
            this.cmbSeleccionarApariencia.Name = "cmbSeleccionarApariencia";
            this.cmbSeleccionarApariencia.Size = new System.Drawing.Size(168, 24);
            this.cmbSeleccionarApariencia.TabIndex = 19;
            this.cmbSeleccionarApariencia.SelectedIndexChanged += new System.EventHandler(this.cmbSeleccionarApariencia_SelectedIndexChanged);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = global::Proyecto_Cinnity.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1099, 14);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(66, 50);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnVolverPrincipal
            // 
            this.btnVolverPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnVolverPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverPrincipal.Image = global::Proyecto_Cinnity.Properties.Resources.casa__1_;
            this.btnVolverPrincipal.Location = new System.Drawing.Point(1006, 14);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(66, 50);
            this.btnVolverPrincipal.TabIndex = 5;
            this.btnVolverPrincipal.UseVisualStyleBackColor = false;
            // 
            // ptbApariencia
            // 
            this.ptbApariencia.Image = global::Proyecto_Cinnity.Properties.Resources.Femenino;
            this.ptbApariencia.Location = new System.Drawing.Point(663, 110);
            this.ptbApariencia.Name = "ptbApariencia";
            this.ptbApariencia.Size = new System.Drawing.Size(168, 163);
            this.ptbApariencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbApariencia.TabIndex = 18;
            this.ptbApariencia.TabStop = false;
            // 
            // FrmCambiarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1197, 609);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.grbInformacionPersonal);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmCambiarDatos";
            this.Text = "FrmCambiarDatos";
            this.Load += new System.EventHandler(this.FrmCambiarDatos_Load);
            this.grbInformacionPersonal.ResumeLayout(false);
            this.grbInformacionPersonal.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbApariencia)).EndInit();
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
        private System.Windows.Forms.PictureBox ptbApariencia;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnVolverPrincipal;
        private System.Windows.Forms.ComboBox cmbSeleccionarApariencia;
    }
}