using Proyecto_2.src.Controller;
using Proyecto_2.src.Controller.Conversores;
using Proyecto_2.src.View;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Proyecto_2
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
            Gestor gestor = new Gestor();
            gestor.showLogin();
            Application.Run();




        }
    }
}
