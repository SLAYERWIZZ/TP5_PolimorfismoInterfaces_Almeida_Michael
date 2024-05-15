using System;

abstract class Animal
{
    public string animalType;

    public Animal(string type)
    {
        animalType = type;
    }

    public abstract void animalSound();

    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

class Cerdo : Animal
{
    public Cerdo() : base("Mamífero") { }

    public override void animalSound()
    {
        Console.WriteLine("El cerdo dice: oink oink");
    }
}

class Perro : Animal
{
    public Perro() : base("Mamífero") { }

    public override void animalSound()
    {
        Console.WriteLine("El perro dice: guau guau");
    }
}

class Gato : Animal
{
    public Gato() : base("Mamífero") { }

    public override void animalSound()
    {
        Console.WriteLine("El gato dice: miau miau");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cerdo miCerdo = new Cerdo();
        Console.WriteLine("Tipo de animal: " + miCerdo.animalType);
        miCerdo.animalSound();
        miCerdo.sleep();
        Console.WriteLine();

        Perro miPerro = new Perro();
        Console.WriteLine("Tipo de animal: " + miPerro.animalType);
        miPerro.animalSound();
        miPerro.sleep();
        Console.WriteLine();

        Gato miGato = new Gato();
        Console.WriteLine("Tipo de animal: " + miGato.animalType);
        miGato.animalSound();
        miGato.sleep();
    }
}
