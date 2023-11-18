using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    internal class Administrador
    {
        public string Nombre { get; private set; }
        public string Contraseña { get; private set; }
        public long Dni { get; private set; }

        public Administrador(string nombre, string contraseña, long dni)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Dni = dni;
        }

    }
}
