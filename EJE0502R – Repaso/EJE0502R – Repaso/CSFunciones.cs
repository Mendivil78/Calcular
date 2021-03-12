using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE0502R___Repaso
{
    class CSFunciones
    {
        //Correcto
        public static int SolicitarNumeroPersonas()
        {
            int npersonas = 0;
            bool correcto = false;
            while (!correcto)
            {
                Console.Write("Introducir el número de personas: ");
                if (int.TryParse(Console.ReadLine(), out npersonas))
                {
                    if (npersonas > 0)
                    {
                        correcto = true;
                    }
                    else
                    {
                        Console.WriteLine("Tiene que haber más de una persona");
                    }
                }
                else
                {
                    Console.WriteLine("No es un caracter valido");
                }
            }
            return (npersonas);
        }//terminada(solicita el número de personas a preguntar)
        //Correcto 
        public static string SolicitarNombre()
        {
            string nombre = "";
            bool correcto = false;
            while (!correcto)
            {
                Console.Write("Introducir el nombre de la personas: ");
                nombre = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    nombre = nombre.Trim();
                    correcto = true;
                }
                else
                {
                    Console.WriteLine("El nombre no puede ser vacio");
                }
            }
            return (nombre);
        }   //Pido por teclado un nombre
        public static double SolicitarAltura()  //Pido por teclado una altura.         Mirar que la altura tenga dos decimales
        {
            double altura = 0;
            bool correcto = false;
            while (!correcto)
            {
                Console.Write("Introduce la altura: ");
                if (double.TryParse(Console.ReadLine(), out altura))
                {
                    if (altura >= 0)
                    {
                        if (altura <= 3)
                        {
                            correcto = true;
                        }
                        else
                        {
                            Console.WriteLine("La altura no puede ser mayor que 3");
                        }
                    }
                    else
                    {
                        Console.WriteLine("La altura no puede ser menos que 0");
                    }
                }    
            }
            return (altura);
        }
        //Correcto
        public static void LeerDatosMuestra(double[] altura, string[] nombres) //Leo el nombre y la altura y los almacenos.
        {
            for (int contadorperso = 0; contadorperso < altura.Length; contadorperso++)
            {
                nombres[contadorperso] = SolicitarNombre();
                altura[contadorperso] = SolicitarAltura();
                Console.Clear();
            }
        }
        //Correcto        
        public static void MostrarDatosMuestra(double[] listaalturas, string[] listanombres) //Muestro el nombre y sus respectivas alturas
        {
            Console.Clear();
            for (int mostrar = 0; mostrar < listaalturas.Length; mostrar++)
            {
                Console.WriteLine("Nombre: {0}\t Altura: {1}m", listanombres[mostrar], listaalturas[mostrar]);
            }
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        //Correcto
        public static void Adios()
        {
            Console.WriteLine("\n\nPulsa una tecla para finalizar");
            Console.ReadKey();
        }

        /*public static int NombreYAltura(int numPersonas, double tamaño)
        {
            string[] nombres;
            nombres = new string[numPersonas];
            double[] altura;
            altura = new double[numPersonas];
            for (int contador = 0; contador < numPersonas; contador++)
            {
                bool correcto = false;
                while (!correcto)
                {
                    Console.WriteLine("Introducir el nombre de la personas: ");
                    string revision = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(revision))      
                    {
                        revision.Trim();
                        nombres[contador] = revision;
                        correcto = true;
                    }
                    else
                    {
                        Console.WriteLine("El nombre no puede ser vacio");
                    }
                }
                correcto = false;
                while(!correcto)
                {
                    Console.Write("Introduce la altura de {0}: ", nombres[contador]);
                    if (double.TryParse(Console.ReadLine(), out double provisional))
                    {
                        if (provisional >= 0)
                        {
                            if (provisional <= 3)
                            {
                                altura[contador] = provisional;
                                correcto = true;
                            }
                            else
                            {
                                Console.WriteLine("La altura no puede ser mayor que 3");
                            }
                        }
                        else
                        {
                            Console.WriteLine("La altura no puede ser menor que 0");
                        }

                    }
                }  
            }
            return nombres;
        }*/
    }
}
