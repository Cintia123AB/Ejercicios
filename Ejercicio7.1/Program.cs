// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroabsoluto
{
    class Program
    {
       static void Main (string[] args)
    {
        int numero;
        
       Console.Write("Ingresa Un Numero: ");
       numero = int.Parse(Console.ReadLine());
    
    if(numero <  0)
       Console.Write("El numeor es: " + numero + " y su valor absoluto es:" + Math.Abs(numero));
    else
       Console.Write ("El numero es:" + numero);

    Console.ReadKey();

 
    }
}
}