using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE0502R___Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nos han propuesto calcular las personas que están por encima y por debajo de la media de altura en una muestra realizada. 
            //Dicha muestra se almacena en dos arrays distintos (uno con los nombres de las personas y otro con la altura que tienen) y 
            //la cantidad de personas a las que se preguntó no es siempre la misma para diferentes ejecuciones del programa. 
            //Este número de personas se debe solicitar el principio del programa.

            //Pido numero
            int numPersonas = CSFunciones.SolicitarNumeroPersonas();

            //Peido nombre y altura
            string[] listanombres = new string[numPersonas];
            double[] listaalturas = new double[numPersonas];

            //Almaceno nombre y altura
            CSFunciones.LeerDatosMuestra(listaalturas, listanombres);

            //Muestor nombre y altura
            CSFunciones.MostrarDatosMuestra(listaalturas, listanombres);

            //Calculo personas por encima y debajo de la media de altura
            /*string[] nombreencimamedia = CSAlturas.PersonasPorEncimaMedia(listanombres, listaalturas);   (Se comentan porque en la función "Mostrarpersona" se utilizan)
              string[] nomnresdebajomedia = CSAlturas.PersonasPorDebajoMedia(listanombres, listaalturas);*/

            //Leer por teclado una condición y la devuelve en el string "mensaje"
            string mensaje = CSAlturas.LeerMensajes();

            //Dado un mensaje ("menor" o "mayor") muestra las personas con la altura superior o inferior a la media
            CSAlturas.Mostrarpersona(listanombres,mensaje,listaalturas );

            //Finalizar programa
            CSFunciones.Adios();
        }
        //Explicar mejor los pasos a seguir para tener mas claro que hacer en que momento
        //Explicar que hace cada funcion en comentarios a ayuda mucho
        //no las crees private porque entonces no las puedes utilizar fuera de este nameespace
    }
}

