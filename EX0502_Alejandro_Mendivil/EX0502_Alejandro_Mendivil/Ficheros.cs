using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0502_Alejandro_Mendivil
{
    class Ficheros
    {
        public static List<string> LeerDatosFichero(string nombrefichero)
        {
            List<string> datos = new List<string>();
            try
            {
                StreamReader fiche = new StreamReader(nombrefichero);
                while (!(fiche.EndOfStream))
                {
                    datos.Add(fiche.ReadLine());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                datos.Clear();
            }
            return (datos);
        }
        public static List<string> LeerIslas(List<string> DatosIniciales)
        {
            string[] islascanarias = { "El Hierro", "La Palma", "La Gomera", "Tenerife", "Gran Canaria", "Fuerteventura", "Lanzarote" };
            List<string> isla = new List<string>();
            int linea = 5; //Empezamos en la línea 5
            string[] islas = DatosIniciales[linea].Split(';');
                for (int posicionislas = 0; posicionislas < islas.Length; posicionislas++)
                {
                    for (int posicioncanarias = 0; posicioncanarias < islascanarias.Length; posicioncanarias++)
                    {
                        if (islas[posicionislas] == islascanarias[posicioncanarias])
                        {
                            isla.Add(islas[posicionislas]);
                        }
                    }
                }  
            return (isla);
        }   
        public static List<string> LeerMeses(List<string> DatosIniciales)
        {
            string[] losmeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre","Octubre","Noviembre", "Diciembre"};
            List<string> Meses = new List<string>();
            int linea = 7;  //Saltamos la línea 5 porque es la cabecera
            while ((linea < DatosIniciales.Count))
            {
                string[] nlinea = DatosIniciales[linea].Split(' ');

                if (nlinea.Length <= 2) 
                {
                    nlinea = nlinea[1].Split(';');
                    string municipio = nlinea[0].Trim();
                    if (municipio != "")
                    {
                        Meses.Add(municipio);
                        linea++;
                    }
                }
               
            }
            return (Meses);
        }
    }
}

