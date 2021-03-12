using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE0502R___Repaso
{
    class CSAlturas
    {
        
        //Correcto 
        public static string[] PersonasPorEncimaMedia(string[] personas, double[] alturas)
        {
            double suma=0;
            for (int posicion=0; posicion<alturas.Length; posicion++)   //Posible foreach
            {
                suma+=alturas[posicion];
            }
            double media = suma / alturas.Length;

            int contadorpersona = 0;
            string[] nombremayormedia = new string[0];
            for (int posicion=0; posicion<alturas.Length; posicion++)
            {
                if (alturas[posicion] > media)
                {
                    Array.Resize(ref nombremayormedia, nombremayormedia.Length + 1);
                    nombremayormedia[contadorpersona] = personas[posicion];
                    contadorpersona++;
                }
            }
            return (nombremayormedia);
        }
        //Correcto
        public static string[] PersonasPorDebajoMedia(string[] personas, double[] alturas)
        {
            double suma = 0;
            for (int posicion = 0; posicion < alturas.Length; posicion++)   //Posible foreach
            {
                suma += alturas[posicion];
            }
            double media = suma / alturas.Length;

            int contadorpersona = 0;
            string[] nombremenormedia = new string[0];
            for (int posicion = 0; posicion < alturas.Length; posicion++)
            {
                if (alturas[posicion] < media)
                {
                    Array.Resize(ref nombremenormedia, nombremenormedia.Length + 1);
                    nombremenormedia[contadorpersona] = personas[posicion];
                    contadorpersona++;
                }
            }
            return (nombremenormedia);
        }
        //(Pasamos el vector "double[] alturas" porque al llamar a las funciones PersonasPorDebajoMedia y PersonasPorEcimaMedia necesitamos darle ese parámetro)
        public static void Mostrarpersona(string[] personas, string mensaje, double[] alturas )
        {
            string[] nombresmostrar = new string[0];
            if (mensaje == "menor")
            {
                 nombresmostrar= PersonasPorDebajoMedia(personas,alturas);
                 Console.WriteLine("Las personas con la altura menor a la media son: ");
            }
            else
            {
                if(mensaje == "mayor")
                {
                    nombresmostrar = PersonasPorEncimaMedia(personas, alturas);
                    Console.WriteLine("Las personas con la altura mayor a la media son: ");
                }
            }
            foreach (string recorrer in nombresmostrar)
            {
                Console.Write(recorrer+"\t");
            }
        }//Mostrar por debajo o por encima de la media
        //Correcto EXTRA
        public static string LeerMensajes() //No es necesario pero se hizo para pedir por teclado la condicion que se desee
        {
            string mensaje = "";
            bool correcto = false;
            while (!correcto)
            {
                Console.Clear();
                Console.WriteLine("\nEscriba condicion: \"mayor\" o \"menor\"");
                mensaje = Console.ReadLine();
                mensaje = mensaje.Trim().ToLower();
                if ((mensaje== "menor") || (mensaje=="mayor")) //La condición multiple me la propuso Aytami
                {
                    correcto = true;
                }
                else
                {
                    Console.WriteLine("\nLa condicion escrita no es correcta");
                    Console.ReadKey();
                }
            }
            return (mensaje);
        }
    }
}
