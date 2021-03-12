using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT0301.Pruebasunitarias
{
    public class Funciones
    {
        
        public static int ContarMinusculas(string cadena)
        {
            int vecesmin = 0;
            foreach(char letra in cadena)
            {
                if (char.IsLower(letra)==true)
                {
                    vecesmin++;
                }
            }
            return (vecesmin);
        }

        public static int ContarMayusculas(string cadena)
        {
            int vecesmasc = 0;
            foreach(char letra in cadena)
            {
                if (char.IsUpper(letra) == true)
                {
                    vecesmasc++;
                }
            }
            return (vecesmasc);
        }
    }
}
