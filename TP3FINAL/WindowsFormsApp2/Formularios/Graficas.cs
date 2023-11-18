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
    public partial class Graficas : Form
    {
        public Graficas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int[] datosHuespedes = null;
        int[] datosAlojamiento = null;//0 casa, 1 hotel
        bool estado = false;
        public Graficas(int[] dataHuespedes, int[] dataAloj)
        {
            datosHuespedes = dataHuespedes;
            datosAlojamiento = dataAloj;
            estado = true;
        }
        private void Graficas_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Width = 1150;
            Height = 600;
            object o = new object();
            Graficas_Paint(o, e);

        }
        public void Graficas_Paint(object sender, PaintEventArgs e)
        {
            if (estado)
            {
                int p1 = datosHuespedes[1], p2 = datosHuespedes[2], p3 = datosHuespedes[3];
                int p4 = datosHuespedes[4], p5 = datosHuespedes[5], p6 = datosHuespedes[6], pMayorA6 = datosHuespedes[7];
                int mayor = 0;
                for (int i = 0; i < datosHuespedes.Length; i++)
                {
                    if (datosHuespedes[i] > mayor)
                        mayor = datosHuespedes[i];
                }
                int largo1 = p1 * 500 / mayor, largo2 = p2 * 500 / mayor, largo3 = p3 * 500 / mayor;
                int largo4 = p4 * 500 / mayor, largo5 = p5 * 500 / mayor, largo6 = p6 * 500 / mayor, largo7 = pMayorA6 * 500 / mayor;
                Font fuente = new Font("Segoe UI", 10);

                e.Graphics.DrawString("Grafico por cantidad de personas", fuente, new SolidBrush(Color.Black), 10, 15);
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), 10, 50, largo1, 50);
                e.Graphics.DrawString("1 sola persona: " + p1, fuente, new SolidBrush(Color.Black), 20, 65);
                e.Graphics.FillRectangle(new SolidBrush(Color.Green), 10, 120, largo2, 50);
                e.Graphics.DrawString("2 personas: " + p2, fuente, new SolidBrush(Color.Black), 20, 135);
                e.Graphics.FillRectangle(new SolidBrush(Color.Blue), 10, 190, largo3, 50);
                e.Graphics.DrawString("3 personas: " + p3, fuente, new SolidBrush(Color.Black), 20, 205);
                e.Graphics.FillRectangle(new SolidBrush(Color.Brown), 10, 260, largo4, 50);
                e.Graphics.DrawString("4 personas: " + p4, fuente, new SolidBrush(Color.Black), 20, 275);
                e.Graphics.FillRectangle(new SolidBrush(Color.DarkMagenta), 10, 330, largo5, 50);
                e.Graphics.DrawString("5 personas: " + p5, fuente, new SolidBrush(Color.Black), 20, 345);
                e.Graphics.FillRectangle(new SolidBrush(Color.DarkSalmon), 10, 400, largo6, 50);
                e.Graphics.DrawString("6 personas: " + p6, fuente, new SolidBrush(Color.Black), 20, 415);
                e.Graphics.FillRectangle(new SolidBrush(Color.LightCoral), 10, 470, largo7, 50);
                e.Graphics.DrawString("Mas de 6 personas: " + pMayorA6, fuente, new SolidBrush(Color.Black), 20, 485);

                //hasta acá el primer gráfico

                int total = datosAlojamiento[0] + datosAlojamiento[1];
                int gradosCasa = datosAlojamiento[0] * 360 / total;
                int gradosHotel = datosAlojamiento[1] * 360 / total;
                double porcCasas = datosAlojamiento[0] / total * 100;
                double porcHoteles = datosAlojamiento[1] / total * 100;

                e.Graphics.DrawString("Grafico por tipo de alojamiento", fuente, new SolidBrush(Color.Black), 650, 15);
                e.Graphics.FillPie(new SolidBrush(Color.LightSkyBlue), 650, 40, 400, 400, 0, gradosCasa);
                e.Graphics.FillPie(new SolidBrush(Color.Orange), 650, 40, 400, 400, gradosCasa, gradosHotel);

                e.Graphics.FillRectangle(new SolidBrush(Color.LightSkyBlue), 650, 450, 20, 20);
                e.Graphics.DrawString(string.Format(": CASAS = {0:00}%", porcCasas), new Font("Arial", 10), new SolidBrush(Color.Black), 675, 455);
                e.Graphics.FillRectangle(new SolidBrush(Color.Orange), 650, 475, 20, 20);
                e.Graphics.DrawString(string.Format(": HOTELES = {0:00}%", porcHoteles), new Font("Arial", 10), new SolidBrush(Color.Black), 675, 480);

                e.Graphics.DrawString(string.Format("Casas reservadas: {0}\nHoteles reservados: {1}\nTotal: {2}",
                    datosAlojamiento[0], datosAlojamiento[1], total), new Font("Arial", 10), new SolidBrush(Color.Black), 850, 450);
            }
        }

        private void Graficas_Load_1(object sender, EventArgs e)
        {

        }
    }
}

