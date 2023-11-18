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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = "Jona";
            txtApellido.Text = "Cardozo";
            txtDNI.Text = "45552753";
            txtTelefono.Text = "3435095739";
        }
    }
}
