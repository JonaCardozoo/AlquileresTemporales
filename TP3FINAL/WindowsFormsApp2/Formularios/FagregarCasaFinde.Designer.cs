namespace WindowsFormsApp2.Formularios
{
    partial class FagregarCasaFinde
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtDestinoCasaFinde = new System.Windows.Forms.TextBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBDesayuno = new System.Windows.Forms.CheckBox();
            this.rBcochera = new System.Windows.Forms.CheckBox();
            this.rBLimpieza = new System.Windows.Forms.CheckBox();
            this.rBWifi = new System.Windows.Forms.CheckBox();
            this.rBPileta = new System.Windows.Forms.CheckBox();
            this.rBMascota = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDiaMinimoCasaFinde = new System.Windows.Forms.NumericUpDown();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarCasa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCamasCasaFinde = new System.Windows.Forms.NumericUpDown();
            this.nudPrecioPropiedadCasaFinde = new System.Windows.Forms.NumericUpDown();
            this.nudNroPropiedadCasaFinde = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionCasaFinde = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaMinimoCasaFinde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamasCasaFinde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioPropiedadCasaFinde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedadCasaFinde)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Destino";
            // 
            // txtDestinoCasaFinde
            // 
            this.txtDestinoCasaFinde.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtDestinoCasaFinde.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDestinoCasaFinde.Location = new System.Drawing.Point(183, 297);
            this.txtDestinoCasaFinde.Margin = new System.Windows.Forms.Padding(5);
            this.txtDestinoCasaFinde.Name = "txtDestinoCasaFinde";
            this.txtDestinoCasaFinde.Size = new System.Drawing.Size(162, 25);
            this.txtDestinoCasaFinde.TabIndex = 37;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.FlatAppearance.BorderSize = 2;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.Location = new System.Drawing.Point(35, 621);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(366, 56);
            this.btnAgregarImagen.TabIndex = 36;
            this.btnAgregarImagen.Text = "AGREGAR IMAGENES:";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(14, 403);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(402, 208);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // rBDesayuno
            // 
            this.rBDesayuno.AutoSize = true;
            this.rBDesayuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBDesayuno.Location = new System.Drawing.Point(226, 165);
            this.rBDesayuno.Margin = new System.Windows.Forms.Padding(5);
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
            this.rBcochera.Location = new System.Drawing.Point(226, 105);
            this.rBcochera.Margin = new System.Windows.Forms.Padding(5);
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
            this.rBLimpieza.Location = new System.Drawing.Point(222, 41);
            this.rBLimpieza.Margin = new System.Windows.Forms.Padding(5);
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
            this.rBWifi.Location = new System.Drawing.Point(21, 165);
            this.rBWifi.Margin = new System.Windows.Forms.Padding(5);
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
            this.rBPileta.Location = new System.Drawing.Point(21, 105);
            this.rBPileta.Margin = new System.Windows.Forms.Padding(5);
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
            this.rBMascota.Location = new System.Drawing.Point(21, 41);
            this.rBMascota.Margin = new System.Windows.Forms.Padding(5);
            this.rBMascota.Name = "rBMascota";
            this.rBMascota.Size = new System.Drawing.Size(92, 22);
            this.rBMascota.TabIndex = 8;
            this.rBMascota.Text = "Mascota";
            this.rBMascota.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Dia Minimo";
            // 
            // nudDiaMinimoCasaFinde
            // 
            this.nudDiaMinimoCasaFinde.BackColor = System.Drawing.Color.PapayaWhip;
            this.nudDiaMinimoCasaFinde.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudDiaMinimoCasaFinde.Location = new System.Drawing.Point(183, 234);
            this.nudDiaMinimoCasaFinde.Margin = new System.Windows.Forms.Padding(5);
            this.nudDiaMinimoCasaFinde.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDiaMinimoCasaFinde.Name = "nudDiaMinimoCasaFinde";
            this.nudDiaMinimoCasaFinde.Size = new System.Drawing.Size(163, 25);
            this.nudDiaMinimoCasaFinde.TabIndex = 33;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(205, 696);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(196, 44);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCasa
            // 
            this.btnAgregarCasa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarCasa.FlatAppearance.BorderSize = 2;
            this.btnAgregarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCasa.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCasa.Location = new System.Drawing.Point(35, 696);
            this.btnAgregarCasa.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarCasa.Name = "btnAgregarCasa";
            this.btnAgregarCasa.Size = new System.Drawing.Size(154, 44);
            this.btnAgregarCasa.TabIndex = 31;
            this.btnAgregarCasa.Text = "Crear CasaFinde";
            this.btnAgregarCasa.UseVisualStyleBackColor = true;
            this.btnAgregarCasa.Click += new System.EventHandler(this.btnAgregarCasa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Camas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 364);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Precio de la Propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nro Propiedad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, -20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "DIRECCION";
            // 
            // nudCamasCasaFinde
            // 
            this.nudCamasCasaFinde.BackColor = System.Drawing.Color.PapayaWhip;
            this.nudCamasCasaFinde.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudCamasCasaFinde.Location = new System.Drawing.Point(183, 161);
            this.nudCamasCasaFinde.Margin = new System.Windows.Forms.Padding(5);
            this.nudCamasCasaFinde.Name = "nudCamasCasaFinde";
            this.nudCamasCasaFinde.Size = new System.Drawing.Size(163, 25);
            this.nudCamasCasaFinde.TabIndex = 26;
            // 
            // nudPrecioPropiedadCasaFinde
            // 
            this.nudPrecioPropiedadCasaFinde.BackColor = System.Drawing.Color.PapayaWhip;
            this.nudPrecioPropiedadCasaFinde.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudPrecioPropiedadCasaFinde.Location = new System.Drawing.Point(183, 358);
            this.nudPrecioPropiedadCasaFinde.Margin = new System.Windows.Forms.Padding(5);
            this.nudPrecioPropiedadCasaFinde.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudPrecioPropiedadCasaFinde.Name = "nudPrecioPropiedadCasaFinde";
            this.nudPrecioPropiedadCasaFinde.Size = new System.Drawing.Size(163, 25);
            this.nudPrecioPropiedadCasaFinde.TabIndex = 25;
            // 
            // nudNroPropiedadCasaFinde
            // 
            this.nudNroPropiedadCasaFinde.BackColor = System.Drawing.Color.PapayaWhip;
            this.nudNroPropiedadCasaFinde.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudNroPropiedadCasaFinde.Location = new System.Drawing.Point(183, 95);
            this.nudNroPropiedadCasaFinde.Margin = new System.Windows.Forms.Padding(5);
            this.nudNroPropiedadCasaFinde.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNroPropiedadCasaFinde.Name = "nudNroPropiedadCasaFinde";
            this.nudNroPropiedadCasaFinde.Size = new System.Drawing.Size(163, 25);
            this.nudNroPropiedadCasaFinde.TabIndex = 24;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDireccion.Location = new System.Drawing.Point(227, -26);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(162, 25);
            this.txtDireccion.TabIndex = 23;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "DIRECCION";
            // 
            // txtDireccionCasaFinde
            // 
            this.txtDireccionCasaFinde.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccionCasaFinde.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDireccionCasaFinde.Location = new System.Drawing.Point(183, 30);
            this.txtDireccionCasaFinde.Margin = new System.Windows.Forms.Padding(5);
            this.txtDireccionCasaFinde.Name = "txtDireccionCasaFinde";
            this.txtDireccionCasaFinde.Size = new System.Drawing.Size(162, 25);
            this.txtDireccionCasaFinde.TabIndex = 39;
            // 
            // FagregarCasaFinde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(438, 759);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccionCasaFinde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDestinoCasaFinde);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudDiaMinimoCasaFinde);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarCasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCamasCasaFinde);
            this.Controls.Add(this.nudPrecioPropiedadCasaFinde);
            this.Controls.Add(this.nudNroPropiedadCasaFinde);
            this.Controls.Add(this.txtDireccion);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FagregarCasaFinde";
            this.Text = "FagregarCasaFinde";
            this.Load += new System.EventHandler(this.FagregarCasaFinde_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaMinimoCasaFinde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamasCasaFinde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioPropiedadCasaFinde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroPropiedadCasaFinde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtDestinoCasaFinde;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox rBDesayuno;
        public System.Windows.Forms.CheckBox rBcochera;
        public System.Windows.Forms.CheckBox rBLimpieza;
        public System.Windows.Forms.CheckBox rBWifi;
        public System.Windows.Forms.CheckBox rBPileta;
        public System.Windows.Forms.CheckBox rBMascota;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown nudDiaMinimoCasaFinde;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarCasa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nudCamasCasaFinde;
        public System.Windows.Forms.NumericUpDown nudPrecioPropiedadCasaFinde;
        public System.Windows.Forms.NumericUpDown nudNroPropiedadCasaFinde;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDireccionCasaFinde;
    }
}