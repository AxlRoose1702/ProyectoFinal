﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Logica
{
    internal class CLEmpleados
    {
        // Devuleve el salario del empleado en base a su cargo
        public double SalarioEmpleado(string cargo)
        {
            if (cargo == "Gerente") return 35000;
            if (cargo == "Recepcionista") return 7000;
            if (cargo == "Botones") return 5000;
            if (cargo == "Conserje") return 3000;
            if (cargo == "Chef") return 1000;

            return 0;
        }

    }
}
