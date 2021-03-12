using System;

namespace REcu.Pro
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxele = 10;
            int[] vectorini = new int[maxele];
            string entrada = "";
            int posicion = 0;
            while (posicion < maxele) // pedir números
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
            int[] vectorimpar = new int[maxele];    //creo un vector nuevo para los impares
            Random aleatorio = new Random(maxele);
            for ( int contador3 =0; contador3 < maxele; contador3++)
            {
                vectorimpar[contador3] = Convert.ToInt32(aleatorio.Next(10));
            }
            for (int contador1 = 0; contador1 < maxele; contador1++) //Busco las pos impares
            {
                if (contador1 % 2 == 0)
                {
                    vectorini[contador1] = vectorimpar[contador1]; //sustituyo el numero en la pos impar 
                }
            }
            for (int contador2 = 1; contador2 < maxele; contador2++) //Busco las posiciones pares
            {
                if (contador2 % 2 != 0)
                {
                    while (contador2 < 2)
                    {
                        vectorini[contador2] = vectorini[contador2];
                        contador2++;
                    }
                    vectorini[contador2] = vectorini[contador2 - 2] + vectorini[contador2 - 1]; //sumo los numero de las posiciones pares
                }
            }
            Console.Write(" Los valores del vector final son:\n\n");
            for (int contador3 = 0; contador3 < maxele; contador3++)
            {
                Console.Write(" {0} ", vectorini[contador3]);
            }
        }
    }
}
