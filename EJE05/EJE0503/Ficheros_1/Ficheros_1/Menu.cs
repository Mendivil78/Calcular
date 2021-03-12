using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros_1
{
    class Menu
    {
        public static void VerMenu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("-            Fichero prueba.txt              -");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("- Pulsar las siguiente opciones              -");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("- 1. Añadir línea.                            ");
            Console.WriteLine("- 2. Eliminar primera línea.                  ");
            Console.WriteLine("- 3. Mostrar Contenido.                       ");
            Console.WriteLine("- 4. Borrar fichero (y crearlo vacío).        ");
            Console.WriteLine("- 5. Salir                                    ");
        }
        public static int Leeropcion()
        {
            ConsoleKeyInfo tecla;
            int valor;
            do
            {
                valor = 0;
                tecla = Console.ReadKey(true);
                switch (tecla.KeyChar)
                {
                    case '1': valor = 1; break;
                    case '2': valor = 2; break;
                    case '3': valor = 3; break;
                    case '4': valor = 4; break;
                    case '5': valor = 5; break;
                        //default: break;
                }
            } while (valor == 0);
            return (valor);
        }
        public static void Adios()
        {
            Console.Write("Pulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
