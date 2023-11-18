namespace WindowsFormsApp2
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.lbConsultas = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConsultas
            // 
            this.lbConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.lbConsultas.FormattingEnabled = true;
            this.lbConsultas.ItemHeight = 17;
            this.lbConsultas.Location = new System.Drawing.Point(27, 27);
            this.lbConsultas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbConsultas.Name = "lbConsultas";
            this.lbConsultas.Size = new System.Drawing.Size(269, 378);
            this.lbConsultas.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVolver.Location = new System.Drawing.Point(115, 415);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(88, 30);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(98)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(328, 460);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lbConsultas);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbConsultas;
        private System.Windows.Forms.Button btnVolver;
    }
}