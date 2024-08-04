namespace Leer_archivo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader lector = new StreamReader(@"C:\Users\l1610\Downloads\Final\archivo.txt");
            string linea;
            linea = lector.ReadLine();

            int num_linea = 1;

            Console.WriteLine("¿Que palabra buscas?");
            string palabra_buscada = Console.ReadLine();

            if (linea.Contains(palabra_buscada))
                Console.WriteLine($"La palabra que buscas esta en la linea {num_linea} y esta en la posision {linea.IndexOf(palabra_buscada) + 1}");
            else
                while ((linea = lector.ReadLine()) != null)
                {
                    num_linea++;
                    if (linea.Contains(palabra_buscada))
                    {
                        Console.WriteLine($"La palabra que buscas esta en la linea {num_linea} y esta en la posision {linea.IndexOf(palabra_buscada) + 1}");
                        break;
                    }

                }
            lector.Close();
        }
    }
}