using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXA0501_Alejandro_Mendívil
{

    class CSContenedores
    {
        //Solicita el nº de contenedores que ha llegado en un mes
        public static int SolicitarNumContenedores() 
        {
            int numcontenedores = 0;
            bool correcto = false;
            while (!correcto)
            {
                Console.Clear();
                Console.Write("Introduzca el número de contenedores que ha llegado este mes: ");
                if (int.TryParse(Console.ReadLine(), out numcontenedores))
                {
                    if (numcontenedores > 0)
                    {
                        correcto = true; 
                    }
                    else
                    {
                        Console.WriteLine("El número de contenedores no puede ser menor o igual que 0");
                        Console.WriteLine("Pulse para intentarlo otra vez");
                        Console.ReadKey();
                    }
                }
                else
                { 
                    Console.WriteLine("El número introducido no es correcto");
                    Console.WriteLine("Pulse para intentarlo otra vez");
                    Console.ReadKey();
                }
            }
            return (numcontenedores);
        }
        //Solicito y devuelvo en un vector de string el pais de cada contenedor
        public static string[] SolicitarPaisDelContenedor(int numcontenedores)
        {
            string[] paisescontenedores = new string[numcontenedores];
            for(int contar=0; contar < numcontenedores; contar++)
            {
                bool correcto = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Introduce el país del contenedor {0}", contar+1);
                    string revisarpais = Console.ReadLine();
                    if (revisarpais.Length >= 4)
                    {
                        paisescontenedores[contar] = revisarpais;
                        correcto = true;
                    }
                    else
                    {
                        Console.WriteLine("El país no puede tener menos de 4 letras");
                        Console.WriteLine("Pulse para intentarlo otra vez");
                        Console.ReadKey();
                    }
                } while (!correcto);
            }
            return (paisescontenedores);
        }
        //Solicito y devuelvo en un vector de double el peso de cada contenedor
        public static double[] SolicitarPesosContenedores(int numcontenedores)
        {
            double[] pesoscontenedores = new double[numcontenedores];
            for (int contar = 0; contar < numcontenedores; contar++)
            {
                bool correcto = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Introduce el peso del contenedor {0} (en Kg)", contar + 1);
                    if(double.TryParse(Console.ReadLine(), out double revisarpeso))
                    {
                        if (revisarpeso>=100)
                        {
                            pesoscontenedores[contar] = revisarpeso;
                            correcto = true;
                        }
                        else
                        {
                            Console.WriteLine("El peso no puede ser menor de 100");
                            Console.WriteLine("Pulse para intentarlo otra vez");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("El peso introducido no es correcto");
                        Console.WriteLine("Pulse para intentarlo otra vez");
                        Console.ReadKey();
                    }
                } while (!correcto);
            }
            return (pesoscontenedores);
        } 
        public static double MediaPeso(double [] listapesos)
        {
            double suma = 0;
            for(int cuentalista=0; cuentalista<listapesos.Length; cuentalista++)
            {
                suma += listapesos[cuentalista];
            }
            double media = suma / listapesos.Length;
            return (media);
        }
        //Muestra los paises que estna por encima de la media (peso)
        public static void MostarPaisesEncimaMedia(double[] listapesos, string[] listapaises, double media)
        {
            string[] paisesmedia=ListaPaisesEncimaMedia(listapesos, listapaises, media);
            MostrarLosPaisesEncimaMedia(paisesmedia, listapaises);
        }
        //Saco en un vector de string, los paises que estan por encima de la media del peso
        public static string[] ListaPaisesEncimaMedia(double[] listapesos, string[] listapaises, double media)
        {
            string[] paisesencimamedia = new string[0];
            for(int cuentapesos=0; cuentapesos<listapesos.Length; cuentapesos++)
            {
                if (listapesos[cuentapesos] > media)
                {
                    Array.Resize(ref paisesencimamedia, paisesencimamedia.Length + 1);
                    paisesencimamedia[paisesencimamedia.Length-1] = listapaises[cuentapesos];
                }
            }
            return (paisesencimamedia);
        } 
        /*public static void MostrarLosPaisesEncimaMedia(string[] paismedia, string [] paises)
        {
            for(int mostrarpais =0; mostrarpais< paises.Length; mostrarpais++) 
            {
                Console.WriteLine(paismedia[mostrarpais]);
            }
        }*/
        public static void MostrarDatosPaís(string[] paises, double[] listapesos)
        {
            string pais = SolicitarPais(paises);
            MostrarPaisElegido(pais, listapesos, paises);
        }
        //Solicita el pais y revisa que este en los datos
        public static string SolicitarPais(string[] listapaises)
        {
            string pais = "";
            bool correcto = false;
            while (!correcto)
            {
                Console.Clear();
                Console.Write("Introduzca el país que quiere consultar: ");
                string revisarpais = Console.ReadLine();
                for(int buscarpais=0; buscarpais<listapaises.Length; buscarpais++)
                {
                    if (revisarpais == listapaises[buscarpais])
                    {
                        pais = revisarpais;
                        correcto = true;
                    }
                }
                if (pais == "")
                {
                    Console.WriteLine("El país introducido no existe en los datos");
                    Console.WriteLine("Pulse una tecla para volver a intentarlo");
                    Console.ReadKey();
                }
            }
            return (pais);
        }
        //Muestra los pesos del pais escogido
        public static void MostrarPaisElegido(string pais, double[] listapesos, string[] listapaises)
        {
            Console.Clear();
            Console.WriteLine("Los pesos de los contenedores de {0} son: ", pais);
            for (int contarlista = 0; contarlista<listapesos.Length; contarlista++)
            {
                if (listapaises[contarlista] == pais)
                {
                    Console.WriteLine(listapesos[contarlista]);
                }
            }
        } 
        public static void Adios()
        {
            Console.WriteLine("PUlse una tecla para finalizar");
            Console.ReadKey();
        }
        
    }
}
