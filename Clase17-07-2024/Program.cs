using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17_07_2024
{
    internal class Program
    {
        //
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese hasta que numero desea imprimir");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numero; i++)
            {

                Console.WriteLine(i);
                if (i == numero)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
        
    }
}
