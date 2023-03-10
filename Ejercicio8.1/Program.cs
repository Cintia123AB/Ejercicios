// See https://aka.ms/new-console-template for more information
using System;
namespace rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float area, perimetro, diagonal;
            Console.WriteLine("Insertar ancho:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Insertar Alto:");
            float h = float.Parse(Console.ReadLine());
            area = b * h;
            perimetro = 2 * (h+b);
            diagonal = (float)Math.Sqrt(Math.Pow(h,2) + Math.Pow(b,2));
            Console.WriteLine("EL area es :{0} \nEl Perimetro es:{1} \nLa diagonal es:{2}", area,perimetro,diagonal);
            Console.ReadKey();
                    }
    }
}

