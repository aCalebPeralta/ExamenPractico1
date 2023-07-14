using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPractico
{
    public class Empleados
    {
        public  string nombre = "";
        public  string apellido = "";
        public  int sueldoDiario = 0;

        public  int CalcularSueldo(int diasTrabajados)
        {
            diasTrabajados = sueldoDiario * 30;

            return diasTrabajados;
        }
    }
}
