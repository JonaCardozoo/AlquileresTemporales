using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class DniExcepction:ApplicationException
    {
        public DniExcepction() : base("Error al ingresar Datos del DNI") { }
        public DniExcepction(string message) : base(message) { }
        public DniExcepction(string message,Exception e) : base(message, e) { }
        
    }
}
