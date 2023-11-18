using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    internal class Habitacion
    {
        public enum Plazas { Simple=1,Doble,Triple}
        
        Plazas tipo;
        int numerohabitacion;
        double precio;
        calendario calen;
        public calendario Calendario { get { return calen; } }
        public double Precio { get { return precio; }set { precio = value; } }
        public int NumeroHabitacion
        {
            get { return numerohabitacion; }
        }
        public Plazas TípoPlaza
        {
            get { return tipo; }
        }
        public Habitacion(int nro, Plazas tipo, calendario calen)
        {
            this.calen = calen;
            numerohabitacion = nro;
            this.tipo = tipo;
        }
    }
}
