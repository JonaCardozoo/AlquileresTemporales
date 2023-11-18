using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace WindowsFormsApp2
{
    [Serializable]

    internal class calendario
    {
        int diasemana;
        int diasTotales;
        int[,] DiaMes1 = new int[40, 2];
        int[,] DiaMes2 = new int[40, 2];
        int[,] DiaMes3 = new int[40, 2];
        DateTime fecha;
        public int[,] DiaaMes1
        {
            get { return DiaMes1; } set { DiaMes1 = value; }   
        }
        public int[,] DiaaMes2 { get { return DiaMes2; }set { DiaaMes2 = value; } }
        public int[,] DiaaMes3 { get { return DiaMes3; }set { DiaaMes3 = value; } }
        public calendario(int mes, int año)
        {
            mes = 11;
            for (int e = 1; e < 4; e++)
            {
                fecha = new DateTime(año, mes, 1);
                diasemana = (int)fecha.DayOfWeek;
                diasTotales = DateTime.DaysInMonth(año, mes);
                if (e==1)
                {
                    for (int d = 0; d < diasTotales; d++)
                    {
                        DiaMes1[diasemana + d, 0] = d + 1;
                    }
                }else if (e==2)
                {
                    for (int d = 0; d < diasTotales; d++)
                    {
                        DiaMes2[diasemana + d, 0] = d + 1;
                    }
                }
                else
                {
                    for (int d = 0; d < diasTotales; d++)
                    {
                        DiaMes3[diasemana + d, 0] = d + 1;
                    }
                }
                mes++;
                if (mes > 12)
                {
                    mes = 1; año++;
                }
            }
        }
        

    }
}

