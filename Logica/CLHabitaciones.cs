using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Logica
{
    internal class CLHabitaciones
    {
        public double MtdPrecioHabitacion(string Tipo)
        {
            if (Tipo == "Individual") return 500;
            else if (Tipo == "Ejecutiva") return 1500;
            else if (Tipo == "Familiar") return 5000;
            else if (Tipo == "Suite") return 10000;
            else if (Tipo == "Presidencial") return 50000;
            else return 0;
        }
    }
}
