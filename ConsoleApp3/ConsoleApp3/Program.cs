using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    class Fichero
    {
        public const string fichero = "prueba.txt";
        static void Main(string[] args)
        {
            int opcion = 0;
            bool noerror = true;
            if (Fichero.InicioFichero())
            {
                do
                {
                    Menu.VerMenu();
                    opcion = Menu.Leeropcion();
                    switch (opcion)
                    {
                        case 1: noerror = Fichero.EscribirFichero(), break;
                        case 2: noerror = Fichero.EliminarLineaFichero(), break;
                        case 3: noerror = Fichero.MostrarFichero(), break;
                        case 4: noerror = Fichero.CrearFichero(),break;
                        case 5: noerror = Fichero.Clear(); break;
                    }
                }
                while ((opcion != 5) && (noerror));
            }
            Menu.Adios();
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    valor = false;
                }
            }
            return (valor);
        }
        public static bool ExisteFichero()
        {
            bool valor = true;
            try
            {
                StreamReader Sreader = new StreamReader(fichero);
                Sreader.Close();
            }
            catch
            {
                valor = false;
            }
            return (valor);
        }
        public static void Vermenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-                 Fichero de prueba.txt                   -");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-Pulsar las siguientes opciones");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-1. Añadir línea.                                         -");
            Console.WriteLine("-2. Eliminar primera línea                                -");
            Console.WriteLine("-3. Mostrar contenido                                     -");
            Console.WriteLine("-4. Borrar fichero (y crear uno desde cero)               -");
            Console.WriteLine("-5. Salir                                                 -");
            Console.WriteLine("-----------------------------------------------------------");
        }
        public static int Leeropcion()
        {
            ConsoleKeyInfo tecla;
            int valor;
            do
            {
                valor = 0;
                tecla = Console.ReadKey(true);
                switch(tecla.KeyChar)
                {
                    case '1': valor = 1; break;
                    case '2': valor = 2; break;
                    case '3': valor = 3; break;
                    case '4': valor = 4; break;
                    case '5': valor = 5; break;
                }
            } while (valor == 0);
            return (valor);
        }
        public static void Adios()
        {
            Console.WriteLine("Pulsa una tecla para finalizar");
            Console.ReadKey();
        }
        public static bool CrearFichero()
        {
            bool valor = true;
            try
            {
                StreamWriter Swriter = File.CreateText(fichero);
                Swriter.Close();
                Console.Clear();
                Console.WriteLine("Fichero creado vacío.");
                Console.WriteLine("Pulsa una tecla para continuar");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                valor = false;
            }
            return (valor);
        }
    }
}
