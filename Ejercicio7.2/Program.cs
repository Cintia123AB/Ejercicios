// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace numerosImpares
{

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Imprimir numero impares del a al 99");




        for (int i = 0; i < 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"Numero: {i}");
            }
        }
        Console.ReadKey();
    }

}
}