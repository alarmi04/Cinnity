
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAñadirEntrada = new System.Windows.Forms.Button();
            this.lblSeleccionCine = new System.Windows.Forms.Label();
            this.lblSesionesDisponibles = new System.Windows.Forms.Label();
            this.lblSesiones = new System.Windows.Forms.Label();
            this.lblCineSeleccionado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoPeli
            // 
            this.gbInfoPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.gbInfoPeli.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.gbInfoPeli.Location = new System.Drawing.Point(40, 31);
            this.gbInfoPeli.Name = "gbInfoPeli";
            this.gbInfoPeli.Size = new System.Drawing.Size(689, 776);
            this.gbInfoPeli.TabIndex = 0;
            this.gbInfoPeli.TabStop = false;
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.comboBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(770, 469);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 32);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Seleccionar cine...";
            // 
            // btnAñadirEntrada
            // 
            this.btnAñadirEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnAñadirEntrada.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnAñadirEntrada.Location = new System.Drawing.Point(794, 766);
            this.btnAñadirEntrada.Name = "btnAñadirEntrada";
            this.btnAñadirEntrada.Size = new System.Drawing.Size(273, 41);
            this.btnAñadirEntrada.TabIndex = 3;
            this.btnAñadirEntrada.Text = "Añadir al carrito";
            this.btnAñadirEntrada.UseVisualStyleBackColor = false;
            // 
            // lblSeleccionCine
            // 
            this.lblSeleccionCine.AutoSize = true;
            this.lblSeleccionCine.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.lblSeleccionCine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblSeleccionCine.Location = new System.Drawing.Point(815, 524);
            this.lblSeleccionCine.Name = "lblSeleccionCine";
            this.lblSeleccionCine.Size = new System.Drawing.Size(197, 24);
            this.lblSeleccionCine.TabIndex = 0;
            this.lblSeleccionCine.Text = "CINE SELECCIONADO:";
            // 
            // lblSesionesDisponibles
            // 
            this.lblSesionesDisponibles.AutoSize = true;
            this.lblSesionesDisponibles.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.lblSesionesDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblSesionesDisponibles.Location = new System.Drawing.Point(815, 644);
            this.lblSesionesDisponibles.Name = "lblSesionesDisponibles";
            this.lblSesionesDisponibles.Size = new System.Drawing.Size(220, 24);
            this.lblSesionesDisponibles.TabIndex = 4;
            this.lblSesionesDisponibles.Text = "SESIONES DISPONIBLES:";
            // 
            // lblSesiones
            // 
            this.lblSesiones.AutoSize = true;
            this.lblSesiones.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.lblSesiones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblSesiones.Location = new System.Drawing.Point(881, 708);
            this.lblSesiones.Name = "lblSesiones";
            this.lblSesiones.Size = new System.Drawing.Size(97, 24);
            this.lblSesiones.TabIndex = 5;
            this.lblSesiones.Text = "(Sesiones)";
            // 
            // lblCineSeleccionado
            // 
            this.lblCineSeleccionado.AutoSize = true;
            this.lblCineSeleccionado.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.lblCineSeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblCineSeleccionado.Location = new System.Drawing.Point(881, 573);
            this.lblCineSeleccionado.Name = "lblCineSeleccionado";
            this.lblCineSeleccionado.Size = new System.Drawing.Size(61, 24);
            this.lblCineSeleccionado.TabIndex = 6;
            this.lblCineSeleccionado.Text = "(Cine)";
            // 
            // FrmInformacionPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1107, 837);
            this.Controls.Add(this.lblCineSeleccionado);
            this.Controls.Add(this.lblSesiones);
            this.Controls.Add(this.lblSesionesDisponibles);
            this.Controls.Add(this.lblSeleccionCine);
            this.Controls.Add(this.btnAñadirEntrada);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbInfoPeli);
            this.Name = "FrmInformacionPelicula";
            this.Text = "FrmInformacionPelicula";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoPeli;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAñadirEntrada;
        private System.Windows.Forms.Label lblSeleccionCine;
        private System.Windows.Forms.Label lblSesionesDisponibles;
        private System.Windows.Forms.Label lblSesiones;
        private System.Windows.Forms.Label lblCineSeleccionado;
    }
}