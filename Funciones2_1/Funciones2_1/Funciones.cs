using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones2_1
{
    class Funciones
    {
        public static int[] PedirYAlmacenarNumero() //Pido un vector de número por teclado para almacenarlo después       
        {
            int[] vectornumero = new int[0];
            bool salida = false;
            while (salida == false)
            {
                Console.Clear();
                Console.Write("Introduzca un número (pulse 00 para salir): ");
                if (int.TryParse(Console.ReadLine(), out int numprovisional))
                {
                    if (numprovisional == 00)
                    {
                        if (vectornumero.Length > 0)
                        {
                            Array.Resize(ref vectornumero, vectornumero.Length - 1);
                        }
                        salida = true;
                    }
                    else
                    {
                        for()
                        vectornumero=Almacenarnumero(numprovisional);    //Función que guarda en un vector los números que cumples las condiciones
                    }
                }
                else
                {
                    Console.WriteLine("El número introducido es erróneo, introduzca un valor entero");
                    Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                    Console.ReadKey();
                }
            }
            return (vectornumero);
        }
        public static int [] Almacenarnumero(int provisional)
        {
            int[] vecto = new int[0];
            Array.Resize(ref vecto, vecto.Length + 1);
            vecto[vecto.Length-1] = provisional;
            return (vecto);

        }
        
    } 
}
