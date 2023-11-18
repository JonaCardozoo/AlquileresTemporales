using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WindowsFormsApp2
{
    interface iImportExport
    {

        void Importar(FileStream fs, StreamReader sr);
        void Exportar(FileStream fs, StreamWriter sw);
    }
}
