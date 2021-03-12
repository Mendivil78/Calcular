using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar una función a la que se le pasa una cadena de caracteres y una letra 
            //y devuelve la cantidad de veces que aparece esta letra en la cadena.
            string cadena = "Esto es una cadena de ejemplo";
            char letra = 'a';
            int veces = 0;
            foreach(char a in cadena)
            {
                veces += 1;
            }
        }
    }
}

