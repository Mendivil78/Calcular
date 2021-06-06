using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    class CFunciones
    {
        //Alejandro(Mendivil78)
        public static int Resta(int num1, int num2)
        {
            int total = num1 - num2;
            return (total);
        }
        public static int Division(int dividendo, int divisor)
        {
            int total = 0;
            if (divisor != 0)
            {
                if (dividendo > divisor)
                {
                    total = dividendo / divisor;
                }
            }
            return (total);
        }
        //El otro Alejandro(Alejandro789-hub)
        public static int Suma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return (resultado);
        }
        public static int Multiplicador(int num1, int num2)
        {
            int resultado = num1 + num2;
            return (resultado);
        }
        public static void MostrarResultados(int num1, int num2, int suma, int resta, int multi, int division)
        {

        }
    }
}
