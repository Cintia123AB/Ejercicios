// See https://aka.ms/new-console-template for more information
Console.WriteLine("EJERCICIO 12.1");

string texto = "PARA CHECAR ESTE EJERCICO SE NECESITA UNA CADENA CON ESPACIOS COMO ESTA .";
int cantidadEspacios = cuantosespacio(texto);
Console.WriteLine($"La cantidad de espacios en la cadena es: {cantidadEspacios}");
static int cuantosespacio(string texto)
{
    int cantidadEspacios = 0;
    foreach (char caracter in texto)
    {
        if (caracter == ' ')
        {
            cantidadEspacios++;
        }
    }
    return cantidadEspacios;
}