// See https://aka.ms/new-console-template for more information
Console.WriteLine("EJERCICIO 12");

Console.WriteLine("Cuantos numeros deseas sumar?");

int sizeArray = Int32.Parse(Console.ReadLine());
int[] numeros = new int[sizeArray];


int i = 0;

while(i<numeros.Length)
{
    Console.WriteLine("Introduce numero {0}", i);
    numeros[i] = Int32.Parse(  Console.ReadLine());
    i++;
}

Console.WriteLine("El resultado es {0}", SumaArreglo(numeros)); 

 

 int SumaArreglo (int [] arreglo)
 {
    int result = 0;
    for(int i = 0; i < arreglo.Length; i++)
    {   
        result += arreglo[i];
    }
    return result;
 }