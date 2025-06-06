﻿namespace ProyectoFinal
{
    public class CLProcesos
    {
       
        public double SalarioPlanilla(int codigoEmpleado)
        {
            //logica para buscar el salario en tabla empleados
            return 0;
        }

        public double SalarioBono(double salario)
        {
            return salario * 0.15;
        }

        public double MontoTotal(double salario, double bono, int horasExtras)
        {
            return salario + bono + (horasExtras * 12);
        }

        public double PrecioHabitaciones(string tipoHabitacion)
        {
            if (tipoHabitacion == "Individual") return 500;
            if (tipoHabitacion == "Ejecutiva") return 1500;
            if (tipoHabitacion == "Familiar") return 5000;
            if (tipoHabitacion == "Suite") return 10000;
            if (tipoHabitacion == "Presidencial") return 50000;

            return 0;
        }

        public double Reservacioes(int codigoHabitacion)
        {
            //logica para buscar en la tabla de habitaciones
            return 0;
        }

        public double Servicios(string tipoServicio)
        {
            if (tipoServicio == "Comida") return 250;
            if (tipoServicio == "Bebida") return 100;
            if (tipoServicio == "Transporte") return 125;
            if (tipoServicio == "Lavanderia") return 75;
            if (tipoServicio == "Medicina") return 150;

            return 0;
        }

        public double MontoConsumo(int codigoServicio)
        {
            //logica para buscar en la tabla de servicios
            return 0;
        }

        public double MontoPago(int codigoReserva)
        {
            //logica para buscar en la tabla de reservaciones
            return 0;
        }

        public double PropinaPago(int montoPago)
        {
            return montoPago * 0.10;
        }

        public double ImpuestoPago(int montoPago)
        {
            return montoPago * 0.12;
        }
        public double DescuentoPago(int montoPago)
        {
            if (montoPago >0 && montoPago <= 500) return montoPago * 0.03;
            if (montoPago >500 && montoPago <= 5000) return montoPago * 0.05;
            if (montoPago >5000) return montoPago * 0.07;

            return 0;
        }

        public double DescuentoPago(int montoPago, int propina, int impuesto, int descuento)
        {
            return montoPago + propina + impuesto - descuento;
        }
    }
}
