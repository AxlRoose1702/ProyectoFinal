﻿using CapaPresentacion.Seguridad;
using ProyectoFinal.Presentacion;
using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
