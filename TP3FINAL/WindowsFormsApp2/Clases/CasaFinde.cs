using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clases
{

    [Serializable]
    internal class CasaFinde
    {

        private Image[] imagenesCasaFinde;

        private List<Reserva> reservasCasaFinde ;


        public List<Reserva> ReservasCasaFinde { get { return reservasCasaFinde; } }

        public Image[] imagenes;

        public Image[] Imagenes { get { return imagenesCasaFinde; } }
        
        public double PrecioBase { get; set; }
        public bool Cochera { get; set; }
        public bool Pileta { get; set; }
        public int Nropropiedad { get; set; }
        public string Direccion { get; set; }
        public bool Wifi { get; set; }
        public bool Limpieza { get; set; }
        public bool Desayuno { get; set; }
        public bool Mascotas { get; set; }
        public int MinimoDias { get; set; }
        public int CantidadCamas { get; set; }
        public calendario Calendario { get; set; }
        public string Lugar { get; set; }


        public CasaFinde(bool cochera, bool pileta, bool wifi, bool limpieza, bool desayuno, bool mascotas, string direccion, int nro, int minimodias, int cantcamas, double preciobase, calendario calen, int cantImagenes, string[] directorioImagenes, string lugar)
        {

            Lugar = lugar;
            Calendario = calen;
            Cochera = cochera;
            Pileta = pileta;
            Wifi = wifi;
            Limpieza = limpieza;
            Desayuno = desayuno;
            Mascotas = mascotas;
            Direccion = direccion;
            Nropropiedad = nro;
            this.MinimoDias = minimodias;
            this.CantidadCamas = cantcamas;
            this.PrecioBase = preciobase;

            imagenesCasaFinde = new Image[cantImagenes];
            for (int i = 0; i < cantImagenes; i++)
            {
                imagenesCasaFinde[i] = Image.FromFile(directorioImagenes[i]);
            }
            reservasCasaFinde = new List<Reserva>();

        }


        public double CalcularPrecioCasaFinde() // "acum" acumula los porcentaje de los serivios...
        {
            double acum = 0;
            if (Cochera) acum += 2;
            if (Wifi) acum += 5;
            if (Limpieza) acum += 15;
            if (Desayuno) acum += 10;
            if (Pileta) acum += 5;
            if (Mascotas) acum += 2;
            acum += CantidadCamas * 5;
            double aux = (PrecioBase * acum) / 100; //"aux" varibale auxiliar para guardar el precio del porcentaje total
            return PrecioBase + aux;
        }

        public void AgregarReservaCasaFinde(Reserva res)
        {
            reservasCasaFinde.Add(res);
        }

        public override string ToString()
        {
            return "Casa Finde: " + Direccion + "- " + Nropropiedad + "- " + CantidadCamas + "- " + PrecioBase;
        }

    }
}
