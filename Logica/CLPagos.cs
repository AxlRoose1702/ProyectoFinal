using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Logica
{
    internal class CLPagos
    {
        public double MtdPropinaPago (double Monto)
        {
            return (Monto * 0.10);
        }
        public double MtdImpuestoPago (double Monto){
            return (Monto * 0.12);
        }
        public double MtdDescuentoPago(double Monto)
        {
            if (Monto > 0 && Monto <= 500) { return (Monto * 0.03); }
            else if (Monto > 500 && Monto <= 5000) { return (Monto * 0.005); }
            else if (Monto > 5000) { return (Monto * 0.07); }
            else { return 0; }
        }
        public double MtdTotalPago (double Monto, double Propina, double Impuesto, double Descuento)
        {
            return (Monto+Propina+Impuesto-Descuento);
        }
    }
}
