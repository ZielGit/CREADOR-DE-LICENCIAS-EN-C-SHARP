using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CREADOR_DE_LICENCIAS_EN_C_SHARP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Creador_de_licencia());
        }
    }
}
