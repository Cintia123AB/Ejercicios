// See https://aka.ms/new-console-template for more information
namespace Ejercicio9;
static class Program
{
    static void Main(string[] args)
    {
        SmallApartment apartment = new SmallApartment();
        Person person = new Person("Cintia");
        apartment.door = new House.Door("Blanca");
        person.house = apartment;
        person.ShowData();
    }
}

public class House
{
    public int Area { get; set; }
    public Door door;

    public House(int area = 200)
    {
        Area = area;
    }

    public void ShowData()
    {
        Console.WriteLine("La casa tiene  una área de: {0} m2",Area);
    }

    public Door GetDoor()
    {
        return door;
    }

    public class Door
    {
        public string Color { get; set; }

        public Door(string color = "Blanca")
        {
            Color = color;
        }

        public void ShowData()
        {
            Console.WriteLine("La puerta  es de color: {0}", Color);
        }
    }
}

public class SmallApartment : House
{
    public SmallApartment(int area = 50) : base(area)
    {
    }
}

public class Person
{
    private string name;
    public House house { get; set; }

    public  Person(string name)
    {
        this.name = name;
    }

    public void ShowData()
    {
        Console.WriteLine("Una persona de nombre: {0}",name);
        Console.WriteLine("Valores de la casa");
        house.ShowData();
        Console.WriteLine("Valores de la puerta");
        house.GetDoor().ShowData();
    }
}