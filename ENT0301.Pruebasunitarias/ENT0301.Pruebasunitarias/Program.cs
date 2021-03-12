using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT0301.Pruebasunitarias
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string cadena = "Esta Es La Cadena";
            int vecesmin = Funciones.ContarMinusculas(cadena);
            int vecesmasc = Funciones.ContarMayusculas(cadena);
            Console.WriteLine("La cadena tiene {0} minúsculas y {1} mayúsculas", vecesmin, vecesmasc);
            Console.WriteLine("Pulse una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
