using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXA0501REC_Alejandro_Mendivil
{
    class CsFunciones
    {
        //Correcto
        public static int SolicitarNumeroCasas()
        {
            int numcasas = 0;
            bool correcto = false;
            while (!correcto)
            {
                Console.Clear();
                Console.Write("Introduzca el número de casas a revisar (numero entre 10 y 30): ");
                if (Int32.TryParse(Console.ReadLine(), out numcasas))
                {
                    if (numcasas >= 10)
                    {
                        if (numcasas <= 30)
                        {
                            correcto = true;
                            return (numcasas);
                        }
                        else
                        {
                            Console.WriteLine("El número debe ser menor o igual a 30");
                            Console.WriteLine("Pulse una tecla para volver a intentarlo");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("El número debe ser mayor o igual a 10");
                        Console.WriteLine("Pulse una tecla para volver a intentarlo");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("El número debe ser entero");
                    Console.WriteLine("Pulse una tecla para volver a intentarlo");
                    Console.ReadKey();
                }
            }
            return (numcasas);
           
        }
        
        //Correcto
        public static string SolicitarNombreCasa(string[] casas)
        {
            bool correcto = false;
            string nombrecasa="";
            do
            {
                Console.Clear();
                Console.WriteLine("Introduce el nombre de la casa: ");
                nombrecasa = Console.ReadLine().Trim();
                    if ( nombrecasa == "")
                    {
                        Console.WriteLine("El nombre no puede estar vacio");
                        Console.WriteLine("Pulse para intentarlo otra vez");
                        Console.ReadKey();
                    }
                    else
                    {
                    correcto = true;
                    }   
                    if (casas.Length>1)
                    {
                        for(int buscar=0; buscar<casas.Length; buscar++)
                        {
                            if (casas[buscar] == nombrecasa)
                            {
                                Console.WriteLine("El nombre de esta casa ya existe");
                                Console.WriteLine("Pulse una tecla para volver a intentarlo");
                                Console.ReadKey();
                                correcto = false;
                                buscar = casas.Length;
                            }
                        }
                    }
            } while (!correcto);
            return (nombrecasa);
        }
        
        //Dato en cantidad monetaria
        public static double SolicitarCostoCasa(string nombrecasa)
        {
            double costecasas;
            bool correcto = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Introduce el coste de la casa {0} (en euros)", nombrecasa);
                if (double.TryParse(Console.ReadLine(), out costecasas))
                {
                    correcto = true;

                }
                else
                {
                    Console.WriteLine("El coste introducido no es correcto");
                    Console.WriteLine("Pulse para intentarlo otra vez");
                    Console.ReadKey();
                }
            } while (!correcto);
            return (costecasas);
        }        
        
        //Correcto
        public static string[] ListaCasaRango(string[] listacasas, double[] listacostes)
        {
            double limitesuperior = SolicitarLimiteSuperior();
            double limiteinferior = SolicitarLimiteInferior(limitesuperior);
            string[] listadorango = new string[1];
            for(int contar=0; contar<listacostes.Length; contar++)
            {
                if (listacostes[contar] >= limiteinferior)
                {
                    if (listacostes[contar] <= limitesuperior)
                    {
                        listadorango[listadorango.Length-1] = listacasas[contar] + ";" + listacostes[contar];
                        Array.Resize(ref listadorango, listadorango.Length + 1);
                    }
                }
            }
            return (listadorango);
        }
        
        //Correcto
        public static double SolicitarLimiteInferior(double limitesuperior)
        {
            double limiteinferior = 0;
            bool correcto = false;
            do
            {
                Console.Clear();
                Console.Write("Introduce el coste limite inferior: ");
                if (double.TryParse(Console.ReadLine(), out limiteinferior))
                {
                    if(limiteinferior<limitesuperior)
                    {
                        correcto = true;
                    }
                    else
                    {
                        Console.WriteLine("El coste del limite inferior no pudee se mayor al superior");
                        Console.WriteLine("Pulse para intentarlo otra vez");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("El coste introducido no es correcto");
                    Console.WriteLine("Pulse para intentarlo otra vez");
                    Console.ReadKey();
                }
            } while (!correcto);
            return (limiteinferior);
        }

        //Correcto/// <summary>
        public static double SolicitarLimiteSuperior()
        {
            double limitesuperior = 0;
            bool correcto = false;
            do
            {
                Console.Clear();
                Console.Write("Introduce el coste limite superior: ");
                if (double.TryParse(Console.ReadLine(), out limitesuperior))
                {
                    correcto = true;

                }
                else
                {
                    Console.WriteLine("El coste introducido no es correcto");
                    Console.WriteLine("Pulse para intentarlo otra vez");
                    Console.ReadKey();
                }
            } while (!correcto);
            return (limitesuperior);
        }

        //Correcto
        public static string SolitarNombreCasaExistente(string[] listacasas)
        {
            bool correcto = true;
            string casaexistente = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Introduce un nombre de una casa existente: ");
                casaexistente = Console.ReadLine().Trim();
                bool existe = false;
                for (int buscar = 0; buscar < listacasas.Length; buscar++)
                {
                    if (listacasas[buscar] == casaexistente)
                    {
                        correcto = true;
                        existe = true;
                    }
                }
                if (!existe)
                {
                    Console.WriteLine("El nombre de esta casa no existe");
                    Console.WriteLine("Pulse una tecla para volver a intentarlo");
                    Console.ReadKey();
                    correcto = false;                  
                }
            } while (!correcto);
            return (casaexistente);
        }

        public static int NVecesCasa(string nombre, string[] listacasas, double[] listacostos)
        {
            int vecescosteinferior = 0;
            for(int buscnombre=0; buscnombre<listacostos.Length; buscnombre++)
            {
                if (listacasas[buscnombre] == nombre)
                {
                    for(int busccoste=0; busccoste < listacostos.Length; busccoste++)
                    {
                        if (listacostos[buscnombre]>listacostos[busccoste])
                        {
                            vecescosteinferior++;
                        }
                    }
                }
            }
            return (vecescosteinferior);
        }

        public static void PresentarPantalla(int veces, string[] listacasasrango)
        {
            Console.WriteLine("Existe {0} casas con un costo inferior");
            for (int cuenta = 0; cuenta < listacasasrango.Length; cuenta++)
            {
                Console.WriteLine("Dentro de ese rango esta {0}", listacasasrango[cuenta]);
            }
        }
    }
    
}


