using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXA0501_Alejandro_Mendívil
{
    class CSContenedores
    {
        public static int SolicitarNumContenedores() //Solicita el nº de contenedores que ha llegado en un mes
        {
            int numcontenedores = 0;
            bool correcto = false;
            while(!correcto)
            {
                Console.Write("Introduzca el número de contenedores que ha llegado este mes: ");
                if (int.TryParse(Console.ReadLine(), out numcontenedores))
                {
                    if (numcontenedores < 0)
                    {
                        Console.WriteLine("El número de contenedores no puede ser menor o igual que 0");
                    }
                    else
                    {
                        correcto = true;
                    }
                }
            }
            return (numcontenedores);
        }

    }
}
