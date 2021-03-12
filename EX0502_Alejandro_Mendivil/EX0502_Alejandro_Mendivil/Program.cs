using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0502_Alejandro_Mendivil
{
    class Program
    {
        static void Main(string[] args)
        {
            bool error = false;
            const string ficheroaviones = "TRAFICO_AEREO_AVIONES.csv";
            //const string fichsalida = "salida.txt";
            List<string> Islas = null;
            List<string> Meses = null;
            //List<int> Dnueve = null;
            //List<int> Dveinte = null;
            //List<double> Diferencia = null;
           
            List<string> DatosIniciales = Ficheros.LeerDatosFichero(ficheroaviones);
            if (DatosIniciales.Count == 0)
            {
                error = true;
            }
            else
            {
                Islas = Ficheros.LeerIslas(DatosIniciales);
            }
            if (!error)
            {
                Meses = Ficheros.LeerMeses(DatosIniciales);
            }
            string islaelegida = Funciones.ElegirIsla();

        }
    }
}
