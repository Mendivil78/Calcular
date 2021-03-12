using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXA0501_Alejandro_Mendívil
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumContenedores = CSContenedores.SolicitarNumContenedores();
            string[] paises = CSContenedores.SolicitarPaisDelContenedor(NumContenedores);
            double[] pesos = CSContenedores.SolicitarPesosContenedores(NumContenedores);
            double media = CSContenedores.MediaPeso(pesos);
            //CSContenedores.MostarPaisesEncimaMedia(pesos,paises,media);
            CSContenedores.MostrarDatosPaís(paises, pesos);
            CSContenedores.Adios();
        }
    }
}
