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
    public partial class Ingresar_Cliente : Form
    {
        public Ingresar_Cliente()
        {
            InitializeComponent();
        }

        private void Ingresar_Cliente_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Jona";
            textBox2.Text = "45552753";
        }
    }
}
