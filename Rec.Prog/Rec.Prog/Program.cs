using System;

namespace Rec.Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxele = 10;
            int[] vectorini = new int[maxele];
            string entrada = "";
            int posicion = 0;
            while (posicion < maxele) // pedir maxele números
            {
                bool pedirnum = true;
                do
                {
                    Console.Write("\n  Introduzca un número entero ");
                    entrada = Console.ReadLine();
                    if (entrada == "")
                    {
                        Console.WriteLine("\n El valor introducido no puede ser una cadena vacía");
                    }
                    else
                    {
                        int numtemporal = 0;
                        if (Int32.TryParse(entrada, out numtemporal))
                        {
                            if (numtemporal == 0)
                            {
                                Console.WriteLine("\n El valor introducido no puede ser una cadena vacía");
                            }
                            else
                            {
                                vectorini[posicion] = numtemporal;
                                posicion++;
                                pedirnum = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("El valor introducido debe ser un número entero");
                        }
                    }
                } while (pedirnum);
                if (posicion < maxele)
                {
                    Console.WriteLine("  Le quedan {0} números por introducir", maxele - posicion);
                }
            }
        }
    }
}
