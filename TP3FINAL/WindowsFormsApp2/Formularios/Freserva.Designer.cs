namespace WindowsFormsApp2
{
    partial class Freserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Freserva));
            this.label3 = new System.Windows.Forms.Label();
            this.tDias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dTPReserva = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Personas Admitidas :";
            // 
            // tDias
            // 
            this.tDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.tDias.Location = new System.Drawing.Point(141, 83);
            this.tDias.Margin = new System.Windows.Forms.Padding(4);
            this.tDias.Name = "tDias";
            this.tDias.Size = new System.Drawing.Size(59, 25);
            this.tDias.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de Dias :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de Ingreso :";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(91, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "RESERVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.textBox1.Location = new System.Drawing.Point(156, 133);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 25);
            this.textBox1.TabIndex = 13;
            // 
            // dTPReserva
            // 
            this.dTPReserva.Location = new System.Drawing.Point(141, 31);
            this.dTPReserva.Margin = new System.Windows.Forms.Padding(4);
            this.dTPReserva.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dTPReserva.MinDate = new System.DateTime(2023, 11, 1, 0, 0, 0, 0);
            this.dTPReserva.Name = "dTPReserva";
            this.dTPReserva.Size = new System.Drawing.Size(227, 25);
            this.dTPReserva.TabIndex = 7;
            this.dTPReserva.Value = new System.DateTime(2023, 11, 1, 0, 0, 0, 0);
            // 
            // Freserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(381, 245);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tDias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dTPReserva);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Freserva";
            this.Text = "Freserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DateTimePicker dTPReserva;
    }
}