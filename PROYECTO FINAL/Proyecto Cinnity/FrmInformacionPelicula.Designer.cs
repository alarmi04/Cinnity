
namespace Proyecto_Cinnity
{
    partial class FrmInformacionPelicula
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
            this.gbInfoPeli = new System.Windows.Forms.GroupBox();
            this.btnAñadirEntrada = new System.Windows.Forms.Button();
            this.lblSesionesDisponibles = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblReparto = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbSesion = new System.Windows.Forms.ComboBox();
            this.dttDiaEmision = new System.Windows.Forms.DateTimePicker();
            this.gbInfoPeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoPeli
            // 
            this.gbInfoPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.gbInfoPeli.Controls.Add(this.textBox1);
            this.gbInfoPeli.Controls.Add(this.lblFechaEstreno);
            this.gbInfoPeli.Controls.Add(this.lblSinopsis);
            this.gbInfoPeli.Controls.Add(this.lblDuracion);
            this.gbInfoPeli.Controls.Add(this.lblReparto);
            this.gbInfoPeli.Controls.Add(this.lblDirector);
            this.gbInfoPeli.Controls.Add(this.label1);
            this.gbInfoPeli.Controls.Add(this.lblGenero);
            this.gbInfoPeli.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.gbInfoPeli.Location = new System.Drawing.Point(40, 31);
            this.gbInfoPeli.Name = "gbInfoPeli";
            this.gbInfoPeli.Size = new System.Drawing.Size(689, 776);
            this.gbInfoPeli.TabIndex = 0;
            this.gbInfoPeli.TabStop = false;
            // 
            // btnAñadirEntrada
            // 
            this.btnAñadirEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnAñadirEntrada.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnAñadirEntrada.Location = new System.Drawing.Point(794, 745);
            this.btnAñadirEntrada.Name = "btnAñadirEntrada";
            this.btnAñadirEntrada.Size = new System.Drawing.Size(273, 62);
            this.btnAñadirEntrada.TabIndex = 3;
            this.btnAñadirEntrada.Text = "Añadir al carrito";
            this.btnAñadirEntrada.UseVisualStyleBackColor = false;
            // 
            // lblSesionesDisponibles
            // 
            this.lblSesionesDisponibles.AutoSize = true;
            this.lblSesionesDisponibles.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.lblSesionesDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblSesionesDisponibles.Location = new System.Drawing.Point(815, 533);
            this.lblSesionesDisponibles.Name = "lblSesionesDisponibles";
            this.lblSesionesDisponibles.Size = new System.Drawing.Size(220, 24);
            this.lblSesionesDisponibles.TabIndex = 4;
            this.lblSesionesDisponibles.Text = "SESIONES DISPONIBLES:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblGenero.Location = new System.Drawing.Point(39, 134);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(77, 24);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Género:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(106, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "(NOMBRE DE LA PELÍCULA)";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblDirector.Location = new System.Drawing.Point(39, 220);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(86, 24);
            this.lblDirector.TabIndex = 9;
            this.lblDirector.Text = "Director:";
            // 
            // lblReparto
            // 
            this.lblReparto.AutoSize = true;
            this.lblReparto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblReparto.Location = new System.Drawing.Point(39, 311);
            this.lblReparto.Name = "lblReparto";
            this.lblReparto.Size = new System.Drawing.Size(84, 24);
            this.lblReparto.TabIndex = 10;
            this.lblReparto.Text = "Reparto:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblDuracion.Location = new System.Drawing.Point(39, 441);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(93, 24);
            this.lblDuracion.TabIndex = 11;
            this.lblDuracion.Text = "Duración:";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblSinopsis.Location = new System.Drawing.Point(39, 569);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(84, 24);
            this.lblSinopsis.TabIndex = 12;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblFechaEstreno.Location = new System.Drawing.Point(39, 502);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(159, 24);
            this.lblFechaEstreno.TabIndex = 13;
            this.lblFechaEstreno.Text = "Fecha de estreno:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.textBox1.Location = new System.Drawing.Point(43, 605);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(615, 142);
            this.textBox1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(770, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 404);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmbSesion
            // 
            this.cmbSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.cmbSesion.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.cmbSesion.FormattingEnabled = true;
            this.cmbSesion.Location = new System.Drawing.Point(770, 600);
            this.cmbSesion.Name = "cmbSesion";
            this.cmbSesion.Size = new System.Drawing.Size(308, 32);
            this.cmbSesion.TabIndex = 5;
            this.cmbSesion.Text = "Seleccionar sesión";
            // 
            // dttDiaEmision
            // 
            this.dttDiaEmision.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.dttDiaEmision.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.dttDiaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttDiaEmision.Location = new System.Drawing.Point(854, 472);
            this.dttDiaEmision.Name = "dttDiaEmision";
            this.dttDiaEmision.Size = new System.Drawing.Size(144, 32);
            this.dttDiaEmision.TabIndex = 6;
            // 
            // FrmInformacionPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1107, 837);
            this.Controls.Add(this.dttDiaEmision);
            this.Controls.Add(this.cmbSesion);
            this.Controls.Add(this.lblSesionesDisponibles);
            this.Controls.Add(this.btnAñadirEntrada);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbInfoPeli);
            this.Name = "FrmInformacionPelicula";
            this.Text = "FrmInformacionPelicula";
            this.gbInfoPeli.ResumeLayout(false);
            this.gbInfoPeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoPeli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAñadirEntrada;
        private System.Windows.Forms.Label lblSesionesDisponibles;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblReparto;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbSesion;
        private System.Windows.Forms.DateTimePicker dttDiaEmision;
    }
}