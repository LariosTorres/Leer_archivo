using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leer_archivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese palabra a buscar");
            string palabra_bruscar = Console.ReadLine();

            //instanciamos la clase Direccion_archivos para poder acceder a ella
            Direccion_archivos dir = new Direccion_archivos();
            //Lista que almacenaa la lista que retorna el metodo Ruta_archivos
            List<string> list_rutas = dir.Ruta_archivos();
            
            foreach (string ruta in list_rutas)
            {
                Buscador.Buscar_palabra(ruta,palabra_bruscar);
            }
        }
    }
}