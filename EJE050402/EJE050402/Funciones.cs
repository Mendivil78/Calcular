using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE050402
{
    class Funciones
    {
        public static int PedirNLineas()
        {
            int numlinea=0;
            bool correcto = false;
            while (!correcto)
            {
                Console.Clear();
                Console.WriteLine("Introduzca el número de lineas");
                if (Int32.TryParse(Console.ReadLine(), out numlinea))
                {
                    if (numlinea>=0)
                    {
                        correcto = true;
                    }
                    else
                    {
                        Console.WriteLine("El número debe ser positivo");
                    }
                }
                else
                {
                    Console.WriteLine("El número debe que ser un entero");
                }
            }
            return (numlinea);
        }
    }
}
