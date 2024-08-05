using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leer_archivo
{
    public class Buscador
    {
        public static void Buscar_palabra(string Rutas, string palabra_bruscar)
        {
            StreamReader lector = new StreamReader(Rutas);
            string linea;
            int num_linea = 1;

            linea = lector.ReadLine();
            
            if (linea.Contains(palabra_bruscar))
                Console.WriteLine($"El archivo {Rutas.Substring(31)} contiene la palabra buscada en la linea {num_linea} en la posicion {linea.IndexOf(palabra_bruscar) + 1}");

            else
                while ((linea = lector.ReadLine()) != null)
                {
                    num_linea++;
                    if (linea.Contains(palabra_bruscar))
                    {
                        Console.WriteLine($"El archivo {Rutas.Substring(31)} contiene la palabra buscada en la linea {num_linea} en la posicion {linea.IndexOf(palabra_bruscar) + 1}");
                        break;

                    }
                }

            lector.Close();
        }
    }
}
