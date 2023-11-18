using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    internal class Cliente
    {
        string nombre;
        string apellido;
        int dni;
        double telefono;
        List<Reserva> reservasCliente=new List<Reserva>();
        public List<Reserva> ReservasCliente { get { return reservasCliente; } }
        public string Nombre { get { return nombre; } }
        public int Dni { get { return dni; } }
        public double Tlefono { get { return telefono; }  }
        public string Apellido { get { return apellido; } }
        public Cliente(string nombre, string apellido, int dni, double telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return nombre + "- " + apellido + "- " + dni + "- " + telefono;
        }

    }
}
