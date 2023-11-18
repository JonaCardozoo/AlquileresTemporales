using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    internal class Casa 
    {
        
        calendario calen;
        Image[] imagenes;


        public List<Reserva> reservasCasa = new List<Reserva>();

        public List<Reserva> ReservasCasa { get; set; }

        public calendario Calendario { get; set; }

        public Image[] Images { get { return imagenes; } }         
        public string Lugar { get; set; }

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
        public Casa(bool cochera, bool pileta, bool wifi, bool limpieza, bool desayuno, bool mascotas, string direccion, int nro, int minimodias, int cantcamas, double preciobase, calendario calen, int cantImagenes, string[] directorioImagenes,string lugar)
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
            imagenes = new Image[cantImagenes];
            for (int i = 0; i < cantImagenes; i++)
            {
                imagenes[i] = Image.FromFile(directorioImagenes[i]);
            }
            reservasCasa = new List<Reserva>();
        }

        public double CalcularPrecio() // "acum" acumula los porcentaje de los serivios...
        {
            double acum = 0;
            if (Cochera) acum += 2;
            if (Wifi) acum += 5;
            if (Limpieza) acum += 15;
            if (Desayuno) acum += 10;
            if (Pileta) acum += 5;
            if (Mascotas) acum += 2;
            acum += CantidadCamas * 5;
            double aux = (PrecioBase * acum)/100; //"aux" varibale auxiliar para guardar el precio del porcentaje total
            return PrecioBase+aux;
        }

        public void AgregarReservaCasa(Reserva res)
        {
            reservasCasa.Add(res);
        }


        public override string ToString()
        {
            return "Casa;"+Direccion+";"+Nropropiedad+";"+CantidadCamas+";"+PrecioBase;  
        }


    }
}
