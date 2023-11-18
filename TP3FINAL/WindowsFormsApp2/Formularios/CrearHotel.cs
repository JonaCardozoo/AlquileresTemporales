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
    public partial class CrearHotel : Form
    {

        string[] directorio = new string[5];
        int cantidad;

        public string[] Directorio
        {
            get { return directorio; }
        }

        public int Cantidad
        {
            get { return cantidad; }
        }
        public CrearHotel()
        {
            InitializeComponent();
        }

        private void agregarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\TP2\WindowsFormsApp2\Imagenes";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directorio[cantidad] = openFileDialog1.FileName;
                cantidad++;
            }

        }

        private void btnCrearHotel_Click(object sender, EventArgs e)
        {

        }
    }
}
