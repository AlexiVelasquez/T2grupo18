﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2grupo18
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
            Application.Run(new Veterinaria());
        }

        


    }
    // prueba
    public class dueñodatos
    {

         public string nombre { get; set; }
         public string direccion { get; set; }

         public string telefono { get; set; }
         



    }
}
