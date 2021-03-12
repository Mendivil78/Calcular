using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ficheros_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dado un fichero que, en cada una de sus líneas tenga dos números separados por un punto y coma, 
             * genere un nuevo fichero que contenga la suma de ambos números.*/
            int opcion = 0;
            bool noerror = true;
            if (Fichero.InicioFichero())
            {
                do
                {
                    Menu.VerMenu();
                    opcion = Menu.Leeropcion();
                    switch (opcion)
                    {
                        case 1: noerror = Fichero.EscribirFichero(); break;
                        case 2: noerror = Fichero.EliminarLineaFichero(); break;
                        case 3: noerror = Fichero.MostrarFichero(); break;
                        case 4: noerror = Fichero.CrearFichero(); break;
                        case 5: Console.Clear(); break;
                    }
                } while ((opcion != 5) && (noerror));
            }
            Menu.Adios();
        }
    }
}
