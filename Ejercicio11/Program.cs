// See https://aka.ms/new-console-template for more information
Console.WriteLine("EJERCICIO 11");

var resultado = Suma(25,58);


Print(resultado);

Print(Resta(5,8));


Print(Multiplica(20,41));




int Suma(int x, int y)
{
    return x + y; 
}


int Resta (int x, int y)
{
    return x - y; 
}

int Multiplica (int x, int y)
{
    return x * y ;
}


void Print (int resultado)
{
    Console.WriteLine("Resultado = {0}", resultado);
}