using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Logica
{
    internal class CLPagoPlanillas
    {
        public double MtdBono(double Salario)
        {
            return Salario * 0.15;
        }
        public double MtdMontoTotal(double Salario, double Bono, int HorasExtra)
        {
            return Salario + Bono + (HorasExtra * 12);
        }
        

    }
}
