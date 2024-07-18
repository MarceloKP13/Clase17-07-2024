using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NúmerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bucle para imprimir números pares del 0 al 100
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " es par");
                }
            }

            // Bucle para imprimir números impares del 1 al 93
            for (int a = 1; a <= 93; a++)
            {
                if (a % 2 != 0)
                {
                    Console.WriteLine(a + " es impar");
                }
            }

            // Espera a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}