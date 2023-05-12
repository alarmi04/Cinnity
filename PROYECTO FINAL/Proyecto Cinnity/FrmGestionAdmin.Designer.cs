
namespace Proyecto_Cinnity
{
    partial class FrmGestionAdmin
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtReparto = new System.Windows.Forms.TextBox();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblReparto = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbInfoPeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoPeli
            // 
            this.gbInfoPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.gbInfoPeli.Controls.Add(this.dateTimePicker1);
            this.gbInfoPeli.Controls.Add(this.label1);
            this.gbInfoPeli.Controls.Add(this.numericUpDown1);
            this.gbInfoPeli.Controls.Add(this.txtDirector);
            this.gbInfoPeli.Controls.Add(this.txtGenero);
            this.gbInfoPeli.Controls.Add(this.txtTitulo);
            this.gbInfoPeli.Controls.Add(this.txtReparto);
            this.gbInfoPeli.Controls.Add(this.lblTítulo);
            this.gbInfoPeli.Controls.Add(this.txtSinopsis);
            this.gbInfoPeli.Controls.Add(this.lblFechaEstreno);
            this.gbInfoPeli.Controls.Add(this.lblSinopsis);
            this.gbInfoPeli.Controls.Add(this.lblDuracion);
            this.gbInfoPeli.Controls.Add(this.lblReparto);
            this.gbInfoPeli.Controls.Add(this.lblDirector);
            this.gbInfoPeli.Controls.Add(this.lblGenero);
            this.gbInfoPeli.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.gbInfoPeli.Location = new System.Drawing.Point(41, 22);
            this.gbInfoPeli.Name = "gbInfoPeli";
            this.gbInfoPeli.Size = new System.Drawing.Size(689, 776);
            this.gbInfoPeli.TabIndex = 1;
            this.gbInfoPeli.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 496);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(380, 32);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(304, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "min.";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 439);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(141, 166);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(517, 32);
            this.txtDirector.TabIndex = 19;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(141, 109);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(517, 32);
            this.txtGenero.TabIndex = 18;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(141, 53);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(517, 32);
            this.txtTitulo.TabIndex = 17;
            // 
            // txtReparto
            // 
            this.txtReparto.BackColor = System.Drawing.Color.White;
            this.txtReparto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtReparto.Location = new System.Drawing.Point(43, 268);
            this.txtReparto.Multiline = true;
            this.txtReparto.Name = "txtReparto";
            this.txtReparto.Size = new System.Drawing.Size(615, 142);
            this.txtReparto.TabIndex = 16;
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblTítulo.Location = new System.Drawing.Point(39, 56);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(65, 24);
            this.lblTítulo.TabIndex = 15;
            this.lblTítulo.Text = "Título:";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.BackColor = System.Drawing.Color.White;
            this.txtSinopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.txtSinopsis.Location = new System.Drawing.Point(43, 605);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(615, 142);
            this.txtSinopsis.TabIndex = 14;
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
            // lblReparto
            // 
            this.lblReparto.AutoSize = true;
            this.lblReparto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblReparto.Location = new System.Drawing.Point(39, 223);
            this.lblReparto.Name = "lblReparto";
            this.lblReparto.Size = new System.Drawing.Size(84, 24);
            this.lblReparto.TabIndex = 10;
            this.lblReparto.Text = "Reparto:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblDirector.Location = new System.Drawing.Point(39, 169);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(86, 24);
            this.lblDirector.TabIndex = 9;
            this.lblDirector.Text = "Director:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.lblGenero.Location = new System.Drawing.Point(39, 112);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(77, 24);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Género:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1140, 717);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.button2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(846, 717);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 81);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.groupBox1.Location = new System.Drawing.Point(730, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 247);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.button3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(38, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(289, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "Seleccionar imagen...";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(446, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(196)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(781, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 343);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmGestionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1445, 826);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbInfoPeli);
            this.Name = "FrmGestionAdmin";
            this.Text = "FrmGestionAdmin";
            this.gbInfoPeli.ResumeLayout(false);
            this.gbInfoPeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoPeli;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtReparto;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblReparto;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}