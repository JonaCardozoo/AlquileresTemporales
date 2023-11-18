using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class vAyuda : Form
    {
        public vAyuda()
        {
            InitializeComponent();
        }
        string url = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Navegador.GoBack();
        }

        private void vAyuda_Load(object sender, EventArgs e)
        {
            //CAMBIAR ESTE USTEDES, entren al index.html de marco y copien la direccion del chrome
            url = @"file:///C:/Users/betra/AppData/Local/Temp/Rar$EXa8456.20251/Pagina%20para%20el%20TP/index.html";
            Navegador.DocumentText = url;
            Navegador.Navigate(url);
        }

        private void Navegador_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {           
            
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            Navegador.GoForward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Navegador.GoHome();
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            Navegador.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Navegador.Stop();
        }
    }
}
