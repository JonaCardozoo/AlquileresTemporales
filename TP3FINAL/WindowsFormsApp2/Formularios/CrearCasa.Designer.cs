namespace WindowsFormsApp2
{
    partial class CrearCasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCasa));
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.nudNroPropiedad = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioPropiedad = new System.Windows.Forms.NumericUpDown();
            this.nudCamas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarCasa = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.nudDiaMinimo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBDesayuno = new System.Windows.Forms.CheckBox();
            this.rBcochera = new System.Windows.Forms.CheckBox();
            this.rBLimpieza = new System.Windows.Forms.CheckBox();
            this.rBWifi = new System.Windows.Forms.CheckBox();
            this.rBPileta = new System.Windows.Forms.CheckBox();
            this.rBMascota = new System.Windows.Forms.CheckBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioPropiedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaMinimo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDireccion.Location = new System.Drawing.Point(150, 12);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(139, 25);
            this.txtDireccion.TabIndex = 0;
            // 
            // nudNroPropiedad
            // 
            this.nudNroPropiedad.BackColor = System.Drawing.SystemColors.Window;
            this.nudNroPropiedad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudNroPropiedad.Location = new System.Drawing.Point(150, 55);
            this.nudNroPropiedad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudNroPropiedad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNroPropiedad.Name = "nudNroPropiedad";
            this.nudNroPropiedad.Size = new System.Drawing.Size(140, 25);
            this.nudNroPropiedad.TabIndex = 1;
            // 
            // nudPrecioPropiedad
            // 
            this.nudPrecioPropiedad.BackColor = System.Drawing.SystemColors.Window;
            this.nudPrecioPropiedad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudPrecioPropiedad.Location = new System.Drawing.Point(187, 259);
            this.nudPrecioPropiedad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudPrecioPropiedad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrecioPropiedad.Name = "nudPrecioPropiedad";
            this.nudPrecioPropiedad.Size = new System.Drawing.Size(140, 25);
            this.nudPrecioPropiedad.TabIndex = 8;
            // 
            // nudCamas
            // 
            this.nudCamas.BackColor = System.Drawing.SystemColors.Window;
            this.nudCamas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudCamas.Location = new System.Drawing.Point(150, 105);
            this.nudCamas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCamas.Name = "nudCamas";
            this.nudCamas.Size = new System.Drawing.Size(140, 25);
            this.nudCamas.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "DIRECCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nro Propiedad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Precio de la Propiedad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Camas";
            // 
            // btnAgregarCasa
            // 
            this.btnAgregarCasa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarCasa.FlatAppearance.BorderSize = 2;
            this.btnAgregarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCasa.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCasa.Location = new System.Drawing.Point(14, 547);
            this.btnAgregarCasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarCasa.Name = "btnAgregarCasa";
            this.btnAgregarCasa.Size = new System.Drawing.Size(153, 54);
            this.btnAgregarCasa.TabIndex = 14;
            this.btnAgregarCasa.Text = "Crear Casa";
            this.btnAgregarCasa.UseVisualStyleBackColor = true;
            this.btnAgregarCasa.Click += new System.EventHandler(this.btnAgregarCasa_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(191, 548);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 52);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // nudDiaMinimo
            // 
            this.nudDiaMinimo.BackColor = System.Drawing.SystemColors.Window;
            this.nudDiaMinimo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudDiaMinimo.Location = new System.Drawing.Point(150, 161);
            this.nudDiaMinimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDiaMinimo.Name = "nudDiaMinimo";
            this.nudDiaMinimo.Size = new System.Drawing.Size(140, 25);
            this.nudDiaMinimo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dia Minimo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.rBDesayuno);
            this.groupBox1.Controls.Add(this.rBcochera);
            this.groupBox1.Controls.Add(this.rBLimpieza);
            this.groupBox1.Controls.Add(this.rBWifi);
            this.groupBox1.Controls.Add(this.rBPileta);
            this.groupBox1.Controls.Add(this.rBMascota);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(14, 293);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(345, 178);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // rBDesayuno
            // 
            this.rBDesayuno.AutoSize = true;
            this.rBDesayuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBDesayuno.Location = new System.Drawing.Point(194, 126);
            this.rBDesayuno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBDesayuno.Name = "rBDesayuno";
            this.rBDesayuno.Size = new System.Drawing.Size(102, 22);
            this.rBDesayuno.TabIndex = 13;
            this.rBDesayuno.Text = "Desayuno";
            this.rBDesayuno.UseVisualStyleBackColor = true;
            // 
            // rBcochera
            // 
            this.rBcochera.AutoSize = true;
            this.rBcochera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBcochera.Location = new System.Drawing.Point(194, 80);
            this.rBcochera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBcochera.Name = "rBcochera";
            this.rBcochera.Size = new System.Drawing.Size(91, 22);
            this.rBcochera.TabIndex = 12;
            this.rBcochera.Text = "Cochera";
            this.rBcochera.UseVisualStyleBackColor = true;
            // 
            // rBLimpieza
            // 
            this.rBLimpieza.AutoSize = true;
            this.rBLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBLimpieza.Location = new System.Drawing.Point(190, 31);
            this.rBLimpieza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBLimpieza.Name = "rBLimpieza";
            this.rBLimpieza.Size = new System.Drawing.Size(94, 22);
            this.rBLimpieza.TabIndex = 11;
            this.rBLimpieza.Text = "Limpieza";
            this.rBLimpieza.UseVisualStyleBackColor = true;
            // 
            // rBWifi
            // 
            this.rBWifi.AutoSize = true;
            this.rBWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBWifi.Location = new System.Drawing.Point(18, 126);
            this.rBWifi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBWifi.Name = "rBWifi";
            this.rBWifi.Size = new System.Drawing.Size(67, 22);
            this.rBWifi.TabIndex = 10;
            this.rBWifi.Text = "Wi-Fi";
            this.rBWifi.UseVisualStyleBackColor = true;
            // 
            // rBPileta
            // 
            this.rBPileta.AutoSize = true;
            this.rBPileta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBPileta.Location = new System.Drawing.Point(18, 80);
            this.rBPileta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBPileta.Name = "rBPileta";
            this.rBPileta.Size = new System.Drawing.Size(69, 22);
            this.rBPileta.TabIndex = 9;
            this.rBPileta.Text = "Pileta";
            this.rBPileta.UseVisualStyleBackColor = true;
            // 
            // rBMascota
            // 
            this.rBMascota.AutoSize = true;
            this.rBMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBMascota.Location = new System.Drawing.Point(18, 31);
            this.rBMascota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBMascota.Name = "rBMascota";
            this.rBMascota.Size = new System.Drawing.Size(92, 22);
            this.rBMascota.TabIndex = 8;
            this.rBMascota.Text = "Mascota";
            this.rBMascota.UseVisualStyleBackColor = true;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.FlatAppearance.BorderSize = 2;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.Location = new System.Drawing.Point(15, 479);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(345, 60);
            this.btnAgregarImagen.TabIndex = 20;
            this.btnAgregarImagen.Text = "AGREGAR IMAGENES:";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.agregarImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.SystemColors.Window;
            this.txtDestino.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDestino.Location = new System.Drawing.Point(150, 209);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(139, 25);
            this.txtDestino.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Destino";
            // 
            // CrearCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(373, 620);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudDiaMinimo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarCasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCamas);
            this.Controls.Add(this.nudPrecioPropiedad);
            this.Controls.Add(this.nudNroPropiedad);
            this.Controls.Add(this.txtDireccion);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearCasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearCasa";
            this.Load += new System.EventHandler(this.CrearCasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioPropiedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaMinimo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarCasa;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.NumericUpDown nudNroPropiedad;
        public System.Windows.Forms.NumericUpDown nudPrecioPropiedad;
        public System.Windows.Forms.NumericUpDown nudCamas;
        public System.Windows.Forms.NumericUpDown nudDiaMinimo;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox rBDesayuno;
        public System.Windows.Forms.CheckBox rBcochera;
        public System.Windows.Forms.CheckBox rBLimpieza;
        public System.Windows.Forms.CheckBox rBWifi;
        public System.Windows.Forms.CheckBox rBPileta;
        public System.Windows.Forms.CheckBox rBMascota;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtDestino;
    }
}