namespace Proyecto_Cinnity
{
    partial class FrmCarrito
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnVolverPrincipal = new System.Windows.Forms.Button();
            this.btnMiPerfil = new System.Windows.Forms.Button();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.lblTotalEntradas2 = new System.Windows.Forms.Label();
            this.lblPrecioTotal2 = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.entradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnVolverPrincipal);
            this.pnlMenu.Controls.Add(this.btnMiPerfil);
            this.pnlMenu.Location = new System.Drawing.Point(-1, -7);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(796, 68);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnCerrarSesion.Image = global::Proyecto_Cinnity.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(710, 15);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(66, 50);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnVolverPrincipal
            // 
            this.btnVolverPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnVolverPrincipal.Image = global::Proyecto_Cinnity.Properties.Resources.casa__1_;
            this.btnVolverPrincipal.Location = new System.Drawing.Point(631, 15);
            this.btnVolverPrincipal.Name = "btnVolverPrincipal";
            this.btnVolverPrincipal.Size = new System.Drawing.Size(66, 50);
            this.btnVolverPrincipal.TabIndex = 5;
            this.btnVolverPrincipal.UseVisualStyleBackColor = false;
            this.btnVolverPrincipal.Click += new System.EventHandler(this.btnVolverPrincipal_Click);
            // 
            // btnMiPerfil
            // 
            this.btnMiPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnMiPerfil.Image = global::Proyecto_Cinnity.Properties.Resources.usuario;
            this.btnMiPerfil.Location = new System.Drawing.Point(3, 15);
            this.btnMiPerfil.Name = "btnMiPerfil";
            this.btnMiPerfil.Size = new System.Drawing.Size(66, 50);
            this.btnMiPerfil.TabIndex = 0;
            this.btnMiPerfil.UseVisualStyleBackColor = false;
            this.btnMiPerfil.Click += new System.EventHandler(this.btnMiPerfil_Click);
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Location = new System.Drawing.Point(26, 16);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.RowHeadersWidth = 51;
            this.dgvEntradas.RowTemplate.Height = 24;
            this.dgvEntradas.Size = new System.Drawing.Size(680, 263);
            this.dgvEntradas.TabIndex = 1;
            this.dgvEntradas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradas_CellDoubleClick);
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.pnlGeneral.Controls.Add(this.lblTotalEntradas2);
            this.pnlGeneral.Controls.Add(this.lblPrecioTotal2);
            this.pnlGeneral.Controls.Add(this.lblPrecioTotal);
            this.pnlGeneral.Controls.Add(this.lblTotalEntradas);
            this.pnlGeneral.Controls.Add(this.btnPagar);
            this.pnlGeneral.Controls.Add(this.btnVaciar);
            this.pnlGeneral.Controls.Add(this.btnVolver);
            this.pnlGeneral.Controls.Add(this.dgvEntradas);
            this.pnlGeneral.Location = new System.Drawing.Point(28, 79);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(728, 539);
            this.pnlGeneral.TabIndex = 5;
            // 
            // lblTotalEntradas2
            // 
            this.lblTotalEntradas2.AutoSize = true;
            this.lblTotalEntradas2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas2.Location = new System.Drawing.Point(167, 303);
            this.lblTotalEntradas2.Name = "lblTotalEntradas2";
            this.lblTotalEntradas2.Size = new System.Drawing.Size(142, 24);
            this.lblTotalEntradas2.TabIndex = 11;
            this.lblTotalEntradas2.Text = "(total entradas)";
            // 
            // lblPrecioTotal2
            // 
            this.lblPrecioTotal2.AutoSize = true;
            this.lblPrecioTotal2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal2.Location = new System.Drawing.Point(517, 303);
            this.lblPrecioTotal2.Name = "lblPrecioTotal2";
            this.lblPrecioTotal2.Size = new System.Drawing.Size(120, 24);
            this.lblPrecioTotal2.TabIndex = 10;
            this.lblPrecioTotal2.Text = "(precio total)";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(389, 303);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(113, 24);
            this.lblPrecioTotal.TabIndex = 9;
            this.lblPrecioTotal.Text = "Precio Total:";
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.Location = new System.Drawing.Point(22, 303);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(139, 24);
            this.lblTotalEntradas.TabIndex = 8;
            this.lblTotalEntradas.Text = "Total entradas: ";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnPagar.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(549, 461);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(155, 62);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click_1);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnVaciar.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.ForeColor = System.Drawing.Color.White;
            this.btnVaciar.Location = new System.Drawing.Point(288, 461);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(155, 62);
            this.btnVaciar.TabIndex = 6;
            this.btnVaciar.Text = "VACIAR";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnVolver.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(17, 461);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(155, 62);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // entradasBindingSource
            // 
            this.entradasBindingSource.DataSource = typeof(Proyecto_Cinnity.Entradas);
            // 
            // FrmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(787, 630);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmCarrito";
            this.Text = "Carrito de la compra";
            this.Load += new System.EventHandler(this.FrmCarrito_Load_1);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMiPerfil;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnVolverPrincipal;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.BindingSource entradasBindingSource;
        private System.Windows.Forms.Label lblPrecioTotal2;
        private System.Windows.Forms.Label lblTotalEntradas2;
    }
}