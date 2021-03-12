using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros_1
{
    class Fichero
    {
        public const string fichero = "prueba.txt";
        public static bool ExisteFichero()
        {
            bool valor = true;
            try
            {
                StreamReader SRead = new StreamReader(fichero);
                SRead.Close();
            }
            catch
            {
                valor = false;
            }
            return (valor);
        }
        public static bool InicioFichero()
        {
            bool valor = true;
            if (!ExisteFichero())
            {
                try
                {
                    StreamWriter Swriter = File.CreateText(fichero);
                    Swriter.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    valor = false;
                }
            }
            return (valor);
        }
    }
}
