using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0502_Alejandro_Mendivil
{
    class Funciones
    {
        public static string ElegirIsla()
        {
            string[] islascanarias = { "El Hierro", "La Palma", "La Gomera", "Tenerife", "Gran Canaria", "Fuerteventura", "Lanzarote" };
            string islaelegida ="";
            bool correcto = false;
            while (!correcto)
            {
                Console.Clear();
                Console.WriteLine("Escriba el nombre de una isla Canaria");
                islaelegida = Console.ReadLine();
                for(int posicion=0;posicion<islascanarias.Length; posicion++)
                {
                    if (islascanarias[posicion]==islaelegida)
                    {
                        islaelegida = islascanarias[posicion];
                        correcto = true;
                    }
                }
                if (!correcto)
                {
                    Console.WriteLine("La isla introducida no existe o lo ha escrito mal");
                    Console.WriteLine("Pulse para intentarlo de nuevo");
                    Console.ReadKey();
                }
            }
            return (islaelegida);
        }
    }
}
