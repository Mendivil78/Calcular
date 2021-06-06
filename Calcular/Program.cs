using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proyecto de cálculo");
            int operador1 = 10;
            int operador2 = 5;
            int suma=CFunciones.Suma(operador1,operador2);
            int resta=CFunciones.Resta(operador1, operador2);
            int multiplicacion=CFunciones.Multiplicador(operador1,operador2);
            int division = CFunciones.Division(operador1, operador2);
            CFunciones.MostrarResultado(operador1,operador2,suma,resta,multiplicacion, division);
            Console.WriteLine("Pulsa una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
