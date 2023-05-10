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
            this.pnlGestionEntradas = new System.Windows.Forms.Panel();
            this.dgvEntradasActivas = new System.Windows.Forms.DataGridView();
            this.lblEntradasActivas = new System.Windows.Forms.Label();
            this.lblIdEntrada = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarEntrada = new System.Windows.Forms.Button();
            this.btnVenderEntrada = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ptbVolverPrincipal = new System.Windows.Forms.PictureBox();
            this.ptbCerrarSesion = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlGestionEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradasActivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVolverPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGestionEntradas
            // 
            this.pnlGestionEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlGestionEntradas.Controls.Add(this.ptbVolverPrincipal);
            this.pnlGestionEntradas.Controls.Add(this.ptbCerrarSesion);
            this.pnlGestionEntradas.Controls.Add(this.pictureBox1);
            this.pnlGestionEntradas.Location = new System.Drawing.Point(-2, -4);
            this.pnlGestionEntradas.Name = "pnlGestionEntradas";
            this.pnlGestionEntradas.Size = new System.Drawing.Size(1119, 63);
            this.pnlGestionEntradas.TabIndex = 0;
            // 
            // dgvEntradasActivas
            // 
            this.dgvEntradasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradasActivas.Location = new System.Drawing.Point(36, 191);
            this.dgvEntradasActivas.Name = "dgvEntradasActivas";
            this.dgvEntradasActivas.RowHeadersWidth = 51;
            this.dgvEntradasActivas.RowTemplate.Height = 24;
            this.dgvEntradasActivas.Size = new System.Drawing.Size(560, 265);
            this.dgvEntradasActivas.TabIndex = 1;
            // 
            // lblEntradasActivas
            // 
            this.lblEntradasActivas.AutoSize = true;
            this.lblEntradasActivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.lblEntradasActivas.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradasActivas.Location = new System.Drawing.Point(36, 93);
            this.lblEntradasActivas.Name = "lblEntradasActivas";
            this.lblEntradasActivas.Padding = new System.Windows.Forms.Padding(142, 30, 142, 30);
            this.lblEntradasActivas.Size = new System.Drawing.Size(544, 95);
            this.lblEntradasActivas.TabIndex = 2;
            this.lblEntradasActivas.Text = "ENTRADAS ACTIVAS";
            // 
            // lblIdEntrada
            // 
            this.lblIdEntrada.AutoSize = true;
            this.lblIdEntrada.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEntrada.ForeColor = System.Drawing.Color.White;
            this.lblIdEntrada.Location = new System.Drawing.Point(38, 503);
            this.lblIdEntrada.Name = "lblIdEntrada";
            this.lblIdEntrada.Size = new System.Drawing.Size(102, 24);
            this.lblIdEntrada.TabIndex = 3;
            this.lblIdEntrada.Text = "ID Entrada:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.textBox1.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(146, 503);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 32);
            this.textBox1.TabIndex = 4;
            // 
            // btnBuscarEntrada
            // 
            this.btnBuscarEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnBuscarEntrada.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEntrada.Location = new System.Drawing.Point(42, 565);
            this.btnBuscarEntrada.Name = "btnBuscarEntrada";
            this.btnBuscarEntrada.Size = new System.Drawing.Size(272, 84);
            this.btnBuscarEntrada.TabIndex = 5;
            this.btnBuscarEntrada.Text = "BUSCAR ENTRADA";
            this.btnBuscarEntrada.UseVisualStyleBackColor = false;
            // 
            // btnVenderEntrada
            // 
            this.btnVenderEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.btnVenderEntrada.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenderEntrada.Location = new System.Drawing.Point(331, 565);
            this.btnVenderEntrada.Name = "btnVenderEntrada";
            this.btnVenderEntrada.Size = new System.Drawing.Size(272, 84);
            this.btnVenderEntrada.TabIndex = 6;
            this.btnVenderEntrada.Text = "VENDER ENTRADA";
            this.btnVenderEntrada.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(667, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(408, 556);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // ptbVolverPrincipal
            // 
            this.ptbVolverPrincipal.Image = global::Proyecto_Cinnity.Properties.Resources.casa__1_;
            this.ptbVolverPrincipal.Location = new System.Drawing.Point(985, 8);
            this.ptbVolverPrincipal.Name = "ptbVolverPrincipal";
            this.ptbVolverPrincipal.Size = new System.Drawing.Size(64, 52);
            this.ptbVolverPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbVolverPrincipal.TabIndex = 2;
            this.ptbVolverPrincipal.TabStop = false;
            // 
            // ptbCerrarSesion
            // 
            this.ptbCerrarSesion.Image = global::Proyecto_Cinnity.Properties.Resources.cerrar_sesion;
            this.ptbCerrarSesion.Location = new System.Drawing.Point(1055, 8);
            this.ptbCerrarSesion.Name = "ptbCerrarSesion";
            this.ptbCerrarSesion.Size = new System.Drawing.Size(61, 52);
            this.ptbCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbCerrarSesion.TabIndex = 1;
            this.ptbCerrarSesion.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Cinnity.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGestionDeEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1114, 695);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnVenderEntrada);
            this.Controls.Add(this.btnBuscarEntrada);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIdEntrada);
            this.Controls.Add(this.lblEntradasActivas);
            this.Controls.Add(this.dgvEntradasActivas);
            this.Controls.Add(this.pnlGestionEntradas);
            this.Name = "FrmGestionDeEntradas";
            this.Text = "Gestión De Entradas";
            this.Load += new System.EventHandler(this.FrmGestionDeEntradas_Load);
            this.pnlGestionEntradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradasActivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVolverPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGestionEntradas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbCerrarSesion;
        private System.Windows.Forms.PictureBox ptbVolverPrincipal;
        private System.Windows.Forms.DataGridView dgvEntradasActivas;
        private System.Windows.Forms.Label lblEntradasActivas;
        private System.Windows.Forms.Label lblIdEntrada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarEntrada;
        private System.Windows.Forms.Button btnVenderEntrada;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}