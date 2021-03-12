using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXA0501REC_Alejandro_Mendivil
{
    class Program
    {
        static void Main(string[] args)
        {
            int numcasas = CsFunciones.SolicitarNumeroCasas();
            string[] Casas = new string[1];
            double[] Coste = new double[numcasas];
            for(int posicion=0; posicion<numcasas; posicion++)
            { 
                Casas[posicion] = CsFunciones.SolicitarNombreCasa(Casas);
                if (posicion != numcasas - 1)
                {
                    Array.Resize(ref Casas, Casas.Length + 1);
                }
                Coste[posicion] = CsFunciones.SolicitarCostoCasa(Casas[posicion]);
            }
            string[] listacasasrango = CsFunciones.ListaCasaRango(Casas, Coste);
            string nombrecasa = CsFunciones.SolitarNombreCasaExistente(Casas);
            int vecescosteinferior = CsFunciones.NVecesCasa(nombrecasa, Casas, Coste);
            CsFunciones.PresentarPantalla(vecescosteinferior, listacasasrango);
            Console.WriteLine("Pulsa para finalizar");
            Console.ReadKey();

            
        }
    }
}
