namespace WindowsFormsApp2
{
    partial class CrearHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearHotel));
            this.txtNombreHotel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstrellas = new System.Windows.Forms.ComboBox();
            this.nudValorBase = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrearHotel = new System.Windows.Forms.Button();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroPropiedad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBDesayuno = new System.Windows.Forms.CheckBox();
            this.rBcochera = new System.Windows.Forms.CheckBox();
            this.rBLimpieza = new System.Windows.Forms.CheckBox();
            this.rBWifi = new System.Windows.Forms.CheckBox();
            this.rBPileta = new System.Windows.Forms.CheckBox();
            this.rBMascota = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorBase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreHotel
            // 
            this.txtNombreHotel.Location = new System.Drawing.Point(124, 31);
            this.txtNombreHotel.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreHotel.Name = "txtNombreHotel";
            this.txtNombreHotel.Size = new System.Drawing.Size(140, 25);
            this.txtNombreHotel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Hotel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hotel Estrellas :";
            // 
            // cbEstrellas
            // 
            this.cbEstrellas.FormattingEnabled = true;
            this.cbEstrellas.Items.AddRange(new object[] {
            "Dos Estrellas",
            "Tres Estrellas"});
            this.cbEstrellas.Location = new System.Drawing.Point(124, 86);
            this.cbEstrellas.Margin = new System.Windows.Forms.Padding(4);
            this.cbEstrellas.Name = "cbEstrellas";
            this.cbEstrellas.Size = new System.Drawing.Size(140, 25);
            this.cbEstrellas.TabIndex = 3;
            // 
            // nudValorBase
            // 
            this.nudValorBase.Location = new System.Drawing.Point(124, 140);
            this.nudValorBase.Margin = new System.Windows.Forms.Padding(4);
            this.nudValorBase.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValorBase.Name = "nudValorBase";
            this.nudValorBase.Size = new System.Drawing.Size(140, 25);
            this.nudValorBase.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor Base :";
            // 
            // btnCrearHotel
            // 
            this.btnCrearHotel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCrearHotel.FlatAppearance.BorderSize = 2;
            this.btnCrearHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearHotel.Location = new System.Drawing.Point(91, 597);
            this.btnCrearHotel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearHotel.Name = "btnCrearHotel";
            this.btnCrearHotel.Size = new System.Drawing.Size(134, 63);
            this.btnCrearHotel.TabIndex = 6;
            this.btnCrearHotel.Text = "Crear Hotel";
            this.btnCrearHotel.UseVisualStyleBackColor = true;
            this.btnCrearHotel.Click += new System.EventHandler(this.btnCrearHotel_Click);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.FlatAppearance.BorderSize = 2;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Location = new System.Drawing.Point(13, 526);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(310, 63);
            this.btnAgregarImagen.TabIndex = 9;
            this.btnAgregarImagen.Text = "Agregar Imagenes:";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.agregarImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Destino  :";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(124, 190);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(140, 25);
            this.txtDestino.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(122, 239);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(140, 25);
            this.txtDireccion.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Direccion :";
            // 
            // txtNroPropiedad
            // 
            this.txtNroPropiedad.Location = new System.Drawing.Point(122, 288);
            this.txtNroPropiedad.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroPropiedad.Name = "txtNroPropiedad";
            this.txtNroPropiedad.Size = new System.Drawing.Size(140, 25);
            this.txtNroPropiedad.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nro Propiedad :";
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
            this.groupBox1.Location = new System.Drawing.Point(13, 321);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(336, 178);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // rBDesayuno
            // 
            this.rBDesayuno.AutoSize = true;
            this.rBDesayuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBDesayuno.Location = new System.Drawing.Point(194, 126);
            this.rBDesayuno.Margin = new System.Windows.Forms.Padding(4);
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
            this.rBcochera.Margin = new System.Windows.Forms.Padding(4);
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
            this.rBLimpieza.Margin = new System.Windows.Forms.Padding(4);
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
            this.rBWifi.Margin = new System.Windows.Forms.Padding(4);
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
            this.rBPileta.Margin = new System.Windows.Forms.Padding(4);
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
            this.rBMascota.Margin = new System.Windows.Forms.Padding(4);
            this.rBMascota.Name = "rBMascota";
            this.rBMascota.Size = new System.Drawing.Size(92, 22);
            this.rBMascota.TabIndex = 8;
            this.rBMascota.Text = "Mascota";
            this.rBMascota.UseVisualStyleBackColor = true;
            // 
            // CrearHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(362, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNroPropiedad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.btnCrearHotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudValorBase);
            this.Controls.Add(this.cbEstrellas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreHotel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CrearHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearHotel";
            ((System.ComponentModel.ISupportInitialize)(this.nudValorBase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrearHotel;
        public System.Windows.Forms.TextBox txtNombreHotel;
        public System.Windows.Forms.ComboBox cbEstrellas;
        public System.Windows.Forms.NumericUpDown nudValorBase;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDestino;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNroPropiedad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox rBDesayuno;
        public System.Windows.Forms.CheckBox rBcochera;
        public System.Windows.Forms.CheckBox rBLimpieza;
        public System.Windows.Forms.CheckBox rBWifi;
        public System.Windows.Forms.CheckBox rBPileta;
        public System.Windows.Forms.CheckBox rBMascota;
    }
}