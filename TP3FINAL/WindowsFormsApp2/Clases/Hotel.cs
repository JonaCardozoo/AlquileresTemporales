using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApp2
{
    [Serializable]
    internal class Hotel
    {
        static Random rnd = new Random();
        public enum HotelEstrella { DosEstrellas, TresEstrellas }
        HotelEstrella tipoHotel;
        double valorBase = 0;
        string nombre;
        List<Habitacion> listaHabitaciones = new List<Habitacion>();
        Image[] imagenHotel;
        List<Reserva> reservaHotel= new List<Reserva>();
        public List<Reserva> ReservaHotel { get { return reservaHotel; } }
        public List<Habitacion> ListaDeHabitacion { get { return listaHabitaciones; } }

        public bool Cochera { get; set; }
        public bool Pileta { get; set; }
        public bool Wifi { get; set; }
        public bool Limpieza { get; set; }
        public bool Desayuno { get; set; }
        public bool Mascotas { get; set; }

        public double ValorBase { get { return valorBase; } set { valorBase = value; CalcularPrecio(); } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Lugar { get; set; }
        public string Direccion{get; set;}
        public int NroPropiedad{get; set;}
        public Image[] ImagenHotel { get { return imagenHotel; } set { imagenHotel = value; } }
        public HotelEstrella TipoHotel { get { return tipoHotel; } set { tipoHotel = value; } }

        public Hotel(bool cochera, bool pileta, bool wifi, bool limpieza, bool desayuno, bool mascotas, string nombre, HotelEstrella tipo, double valorBase, int cantImagenes, string[] directorioImagenes, string lugar, string direccion, int nro)
        {

            //SERVICIOS HOTEL
            Cochera = cochera;
            Pileta = pileta;
            Wifi = wifi;
            Limpieza = limpieza;
            Desayuno = desayuno;
            Mascotas = mascotas;

            if (tipo != 0)
            {
                this.valorBase = valorBase + (valorBase / 100) * 40;
            } else this.valorBase = valorBase;
            tipoHotel = tipo;
            this.nombre = nombre;
            Lugar = lugar;
            Direccion=direccion;
            NroPropiedad=nro;
            for (int i = 0; i < 7; i++)
            {
                calendario calen = new calendario(DateTime.Now.Month + 1, DateTime.Now.Year);
                Habitacion hab = new Habitacion(i, (Habitacion.Plazas)rnd.Next(3) + 1, calen);
                listaHabitaciones.Add(hab);
            }
            CalcularPrecio();
            imagenHotel = new Image[cantImagenes];
            for (int i = 0; i < cantImagenes; i++)
            {
                imagenHotel[i] = Image.FromFile(directorioImagenes[i]);
            }
        }

        public void CalcularPrecio()
        {
            foreach (Habitacion hab in listaHabitaciones)
            {

                double acum = 0;
                if (Cochera) acum += 2;
                if (Wifi) acum += 5;
                if (Limpieza) acum += 15;
                if (Desayuno) acum += 10;
                if (Pileta) acum += 5;
                if (Mascotas) acum += 2;
                
                if (tipoHotel == 0)
                {
                    switch (hab.TípoPlaza)
                    {
                        case Habitacion.Plazas.Simple:
                            {
                                hab.Precio = valorBase + acum;
                            } break;
                        case Habitacion.Plazas.Doble:
                            {
                                hab.Precio = valorBase + acum +((valorBase / 100) * 80);
                            } break;
                        case Habitacion.Plazas.Triple:
                            {
                                hab.Precio = valorBase + acum+((valorBase / 100) * 150);
                            } break;
                    }
                } else
                {

                    switch (hab.TípoPlaza)
                    {
                        case Habitacion.Plazas.Simple:
                            {
                                hab.Precio = valorBase + acum;
                            }
                            break;
                        case Habitacion.Plazas.Doble:
                            {
                                hab.Precio = valorBase + acum + ((valorBase / 100) * 80);
                            }
                            break;
                        case Habitacion.Plazas.Triple:
                            {
                                hab.Precio = valorBase + acum + ((valorBase / 100) * 150);
                            }
                            break;
                    }
                }
            }
        }


        public void AgregarReservaHotel(Reserva res)
        {
            reservaHotel.Add(res);
        }
        public override string ToString()
        {
            return "Hotel;" + Direccion + ";" + NroPropiedad + ";" + "1,2 y 3" + ";" + valorBase+" Simple";
        }
            
        
        
    }
}
