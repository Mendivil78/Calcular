using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE0301.Pruebas_unitarias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuantos números quiere meter? ");
            if (int.TryParse(Console.ReadLine(), out int max))
            {
                for (int contar=0;contar<max; contar++) 
                {
                    int[] numero= new int[max];
                    Console.Write("Escribe un número o pulse 0 para salir: ");
                    int numprovisional =Convert.ToInt32(Console.ReadLine());                    
                }
            
            }
            
        }
    }
}
