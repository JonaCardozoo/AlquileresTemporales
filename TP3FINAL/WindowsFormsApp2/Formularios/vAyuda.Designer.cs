
namespace WindowsFormsApp2
{
    partial class vAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vAyuda));
            this.Navegador = new System.Windows.Forms.WebBrowser();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Navegador
            // 
            this.Navegador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navegador.Location = new System.Drawing.Point(0, 42);
            this.Navegador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Navegador.MinimumSize = new System.Drawing.Size(23, 26);
            this.Navegador.Name = "Navegador";
            this.Navegador.Size = new System.Drawing.Size(1381, 741);
            this.Navegador.TabIndex = 0;
            this.Navegador.Url = new System.Uri("", System.UriKind.Relative);
            this.Navegador.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Navegador_DocumentCompleted);
            // 
            // btnAtras
            // 
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(14, 4);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(27, 30);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdelante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdelante.Location = new System.Drawing.Point(48, 4);
            this.btnAdelante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(27, 30);
            this.btnAdelante.TabIndex = 2;
            this.btnAdelante.Text = ">";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnF5
            // 
            this.btnF5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF5.Location = new System.Drawing.Point(82, 4);
            this.btnF5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(27, 30);
            this.btnF5.TabIndex = 3;
            this.btnF5.Text = "R";
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(115, 4);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(27, 30);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "S";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(161, 4);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(27, 30);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "H";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // vAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 783);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.Navegador);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "vAyuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.vAyuda_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser Navegador;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnF5;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnHome;
    }
}