using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EJE050402
{
    class Program
    { 
        static void Main(string[] args)
        {
            const string fichero = "fichero.txt";
            int numlineas = Funciones.PedirNLineas();
            if (Fichero.InicioFichero(fichero))
            {
                List<string> datos = Fichero.LeerDatos(fichero);
                List<string> ultimalineas = Fichero.UltimasLineas(numlineas, datos);
            }
        }
    }
}
