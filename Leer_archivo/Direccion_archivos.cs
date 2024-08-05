using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leer_archivo
{
    public class Direccion_archivos
    {
        //Metodo publico, en el que se declara el uso de una lista para poder devolver de forma sencilla una lista
        public List<string> Ruta_archivos()
        {
            //Creacion de lista vacia
            List<string> ruta = [];
            //Directorio dara acceso a todos los archivos de la carpeta que usemos
            DirectoryInfo directorio = new DirectoryInfo(@"C:\Users\l1610\Downloads\Final");

            //Loop que guardara la direccion completa de cada archivo del directorio
            foreach(var dir in directorio.GetFiles())
            {
                ruta.Add(dir.FullName);
            }

            //Devolucion de lista ya con las rutas
            return ruta;
        }
    }
}
