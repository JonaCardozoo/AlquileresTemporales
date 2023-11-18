using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Clases;

namespace WindowsFormsApp2
{
    [Serializable]
    internal class Reserva
    {
        int dias;
        
        DateTime ingreso,FechaReservacion;
        double valorbasecontratado=0, preciofinal;
        Habitacion hab=null;
        Casa cas=null;
        Cliente cliente=null;
        Hotel hot=null;
        CasaFinde casafinde = null;
        public int Dni { get; set; }
        int personasAdmitidas = 0;
        public DateTime FechaDeReservacion { get { return FechaReservacion; } }
        public Hotel Hotel { get { return hot; } }
        public Habitacion Habitacion { get { return hab; } }

        public CasaFinde Casafinde { get { return casafinde; } }

        public Casa Casa { get { return cas; } }

        public Cliente Cliente { get { return cliente; } }
        public int PersonasAdmitidas { get { return personasAdmitidas; } set { personasAdmitidas = value; } }
        public string[] DatosHuesped { get; private set; }
        public DateTime Ingreso
        {
            get { return ingreso; } set { ingreso = value; }
        }
        public DateTime Salida
        {
            get { return ingreso.AddDays(dias); }
        }
        public double ValorBaseContratado
        {
            get { return valorbasecontratado; }
        }
        public double PrecioFinal { get { return preciofinal; } }

        public Reserva(Cliente cliente, DateTime ingreso, DateTime reserva, int dias, int cant, Habitacion hab, Hotel hot)
        {
            FechaReservacion = reserva;
            personasAdmitidas = cant;
            this.hab = hab;
            this.cliente = cliente;
            this.dias = dias;
            this.hot = hot;
            this.ingreso = ingreso;
            valorbasecontratado = hab.Precio;
            preciofinal=hab.Precio*dias;
            
        }
        public Reserva(Cliente cliente,DateTime ingreso,DateTime reserva, int dias,int cant, Casa cas)
        {
            FechaReservacion = reserva;
            personasAdmitidas = cant;
            this.cliente = cliente;
            this.cas = cas;
            this.dias = dias;
            this.ingreso = ingreso;
            valorbasecontratado = cas.CalcularPrecio();
            preciofinal = valorbasecontratado * dias;
            Dni = cliente.Dni;
        }

        public Reserva(Cliente cliente, DateTime ingreso, DateTime reserva, int dias, int cant,CasaFinde casafinde)
        {
            FechaReservacion = reserva;
            personasAdmitidas = cant;
            this.cliente = cliente;
            this.dias = dias;
            this.casafinde =casafinde;
            this.ingreso = ingreso;
            valorbasecontratado = hab.Precio;
            preciofinal = hab.Precio * dias;

        }
        int i = 0;
        public override string ToString()
        {
            i++;
            return ("Reserva: "+ i +" Ingreso: "+Ingreso.ToShortDateString() +" Salida: "+ Salida.ToShortDateString());
           
        }


    }
}
