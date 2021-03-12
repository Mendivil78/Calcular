using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE050402
{
    class Fichero
    {
        public static bool InicioFichero (string nombrefichero)
        {
            bool valor = true;
            if (ExisteFichero(nombrefichero))
            {
                try
                {
                    StreamWriter Swrite = File.CreateText(nombrefichero);
                    Swrite.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    valor = false;
                }
            }
            return (valor);
        }
        public static bool ExisteFichero(string nombrefichero)
        {
            bool existe = true;
            try
            {
                StreamReader Sread = new StreamReader(nombrefichero);
                Sread.Close();
            }
            catch
            {
                existe = false;
            }
            return (existe);
        }
        public static List<string> LeerDatos(string nombrefichero)
        {
            List<string> lineas = new List<string>();
            try
            {
                StreamReader Leer = new StreamReader(nombrefichero);
                while (!(Leer.EndOfStream))
                {
                    lineas.Add(Leer.ReadLine());
                }
                Leer.Close();
                if(lineas.Count == 0)
                {
                    Console.WriteLine("Fichero vacío. Debe tener información para poder usarlo");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                lineas.Clear();
            }
            return (lineas);
        }
        public static List<string> UltimasLineas (int numlineas, List<string> datos)
        {
            datos.Reverse();
            Console.ReadKey();
            return (datos);
        }
    }
}
