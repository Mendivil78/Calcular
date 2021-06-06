using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{
    class CFunciones
    {
        public static decimal Resta(decimal num1, decimal num2)
        {
            decimal total = num1 - num2;
            return (total);
        }
        public static decimal Division(decimal dividendo, decimal divisor)
        {
            decimal total = 0;
            if (divisor != 0)
            {
                if (dividendo > divisor)
                {
                    total = dividendo / divisor;
                }
            }
            return (total);
        }
    }
}
