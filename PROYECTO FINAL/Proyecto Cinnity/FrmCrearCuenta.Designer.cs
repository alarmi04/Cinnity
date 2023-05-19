namespace Proyecto_Cinnity
{
    partial class FrmCrearCuenta
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
            this.errorCrearCuenta = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtConfirmarCorreo = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.grbInformacionPersonal = new System.Windows.Forms.GroupBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.chbMostrarContra = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorCrearCuenta)).BeginInit();
            this.grbInformacionPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // errorCrearCuenta
            // 
            this.errorCrearCuenta.ContainerControl = this;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.Black;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCrearCuenta.Location = new System.Drawing.Point(178, 416);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(277, 73);
            this.btnCrearCuenta.TabIndex = 0;
            this.btnCrearCuenta.Text = "CREAR CUENTA";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(326, 204);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(227, 28);
            this.dtpFechaNacimiento.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(75, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(227, 28);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(326, 49);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(227, 27);
            this.txtApellidos.TabIndex = 14;
            this.txtApellidos.Text = "Apellidos";
            this.txtApellidos.Click += new System.EventHandler(this.txtApellidos_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(75, 99);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(478, 28);
            this.txtCorreo.TabIndex = 16;
            this.txtCorreo.Text = "Correo electrónico";
            this.txtCorreo.Click += new System.EventHandler(this.txtCorreo_Click);
            // 
            // txtConfirmarCorreo
            // 
            this.txtConfirmarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarCorreo.Location = new System.Drawing.Point(75, 150);
            this.txtConfirmarCorreo.Name = "txtConfirmarCorreo";
            this.txtConfirmarCorreo.Size = new System.Drawing.Size(478, 28);
            this.txtConfirmarCorreo.TabIndex = 17;
            this.txtConfirmarCorreo.Text = "Confirmar correo";
            this.txtConfirmarCorreo.Click += new System.EventHandler(this.txtConfirmarCorreo_Click);
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(75, 262);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(478, 28);
            this.txtContra.TabIndex = 18;
            this.txtContra.Text = "Contraseña";
            this.txtContra.Click += new System.EventHandler(this.txtContra_Click);
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContra.Location = new System.Drawing.Point(75, 313);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.Size = new System.Drawing.Size(478, 28);
            this.txtConfirmarContra.TabIndex = 19;
            this.txtConfirmarContra.Text = "Confirmar contraseña";
            this.txtConfirmarContra.Click += new System.EventHandler(this.txtConfirmarContra_Click);
            // 
            // cmbPais
            // 
            this.cmbPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(75, 203);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(227, 30);
            this.cmbPais.TabIndex = 20;
            this.cmbPais.Text = "País";
            // 
            // grbInformacionPersonal
            // 
            this.grbInformacionPersonal.BackColor = System.Drawing.Color.Transparent;
            this.grbInformacionPersonal.Controls.Add(this.chbMostrarContra);
            this.grbInformacionPersonal.Controls.Add(this.cmbPais);
            this.grbInformacionPersonal.Controls.Add(this.txtConfirmarContra);
            this.grbInformacionPersonal.Controls.Add(this.txtContra);
            this.grbInformacionPersonal.Controls.Add(this.txtConfirmarCorreo);
            this.grbInformacionPersonal.Controls.Add(this.txtCorreo);
            this.grbInformacionPersonal.Controls.Add(this.txtApellidos);
            this.grbInformacionPersonal.Controls.Add(this.txtNombre);
            this.grbInformacionPersonal.Controls.Add(this.dtpFechaNacimiento);
            this.grbInformacionPersonal.Controls.Add(this.btnCrearCuenta);
            this.grbInformacionPersonal.Location = new System.Drawing.Point(62, 210);
            this.grbInformacionPersonal.Name = "grbInformacionPersonal";
            this.grbInformacionPersonal.Size = new System.Drawing.Size(642, 507);
            this.grbInformacionPersonal.TabIndex = 2;
            this.grbInformacionPersonal.TabStop = false;
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Proyecto_Cinnity.Properties.Resources.CINNITY;
            this.ptbLogo.Location = new System.Drawing.Point(283, 2);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(210, 218);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // chbMostrarContra
            // 
            this.chbMostrarContra.AutoSize = true;
            this.chbMostrarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMostrarContra.ForeColor = System.Drawing.Color.White;
            this.chbMostrarContra.Location = new System.Drawing.Point(75, 359);
            this.chbMostrarContra.Name = "chbMostrarContra";
            this.chbMostrarContra.Size = new System.Drawing.Size(186, 26);
            this.chbMostrarContra.TabIndex = 26;
            this.chbMostrarContra.Text = "Mostrar contraseña";
            this.chbMostrarContra.UseVisualStyleBackColor = true;
            this.chbMostrarContra.CheckedChanged += new System.EventHandler(this.chbMostrarContra_CheckedChanged);
            // 
            // FrmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(779, 767);
            this.Controls.Add(this.grbInformacionPersonal);
            this.Controls.Add(this.ptbLogo);
            this.Name = "FrmCrearCuenta";
            this.Text = "Crear Cuenta";
            this.Load += new System.EventHandler(this.FrmCrearCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorCrearCuenta)).EndInit();
            this.grbInformacionPersonal.ResumeLayout(false);
            this.grbInformacionPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ErrorProvider errorCrearCuenta;
        private System.Windows.Forms.GroupBox grbInformacionPersonal;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtConfirmarCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.CheckBox chbMostrarContra;
    }
}