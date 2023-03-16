// See https://aka.ms/new-console-template for more information
using System;
public class Persona
{

    public int edad;
    public void SetAge(int n)
    {
        edad = n;
    }
    public void Greet()
    {
        Console.WriteLine("Persona: Hola!");
    }
}

public class Estudiante : Persona
{
    public void GoToClasses()
    {
        Console.WriteLine("Estudiante: voy a clase .");
    }

    public void ShowAge()
    {
        Console.WriteLine("Estudiante: Mi Edad es: " + edad + " años");
    }
}

public class Maestro: Persona
{
    public void Explain()
    {
        Console.WriteLine("Maestro:Comienza la explicación.");
    }
}

public class EstudianteAndMaestroTest
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Greet();

        Estudiante estudiante = new Estudiante();
        estudiante.SetAge(21);
        estudiante.Greet();
        estudiante.ShowAge();
        estudiante.GoToClasses();

        Maestro maestro = new Maestro();
        maestro.SetAge(30);
        maestro.Greet();
        maestro.Explain();
    }
}