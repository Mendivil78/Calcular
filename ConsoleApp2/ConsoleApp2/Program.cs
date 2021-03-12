using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string prueba = "esta es la prueba para el foreach";
            char a = 'a';
            for (int i = 0; i < prueba.Length; i++)
            {
                a = prueba[i];
                Console.Write(a);
            }
        }
    }
}
