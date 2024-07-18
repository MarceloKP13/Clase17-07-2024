using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ascendente_Descendente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números en orden ascendente:");

            // Imprime números en orden ascendente del 1 al 50
            for (int i = 0; i <= 50; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nNúmeros en orden descendente:");

            // Imprime números en orden descendente del 50 al 1
            for (int i = 50; i >= 0; i--)
            {
                Console.Write(i + " ");
            }

            // Espera a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}