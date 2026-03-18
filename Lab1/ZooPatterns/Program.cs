using System;
using ZooPatterns.Singleton;
using ZooPatterns.Factory;
using ZooPatterns.FactoryMethod;
using ZooPatterns.AbstractFactory;
using ZooPatterns.Builder;
using ZooPatterns.Prototype;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // -------------------- Singleton --------------------
        var zoo = Zoo.GetInstance();
        Console.WriteLine("Зоопарк відкритий? 1 - Так, 2 - Ні");
        string openChoice = Console.ReadLine();
        if (openChoice == "1")
        {
            zoo.Open();
            Console.WriteLine($"Зоопарк: {zoo.State} — Заходьте!");
        }
        else
        {
            zoo.Close();
            Console.WriteLine($"Зоопарк: {zoo.State} — Зайдете наступного разу.");
            return;
        }

        // -------------------- Выбор животного --------------------
        Console.WriteLine("\nС каким животным работать? (tiger/elephant)");
        string choice = Console.ReadLine()?.ToLower();
        string animalName = choice == "tiger" ? "Тигр" : "Слон";

        Console.WriteLine($"\nРаботаем с {animalName}...\n");

        // -------------------- Factory --------------------
        Console.WriteLine("--- Factory ---");
        var animal = AnimalFactory.CreateAnimal(choice);
        if (animal != null)
        {
            Console.Write($"{animalName} ");
            animal.Speak();
        }

        // -------------------- Factory Method --------------------
        Console.WriteLine("\n--- Factory Method ---");
        AnimalCreator creator = choice == "tiger" ? new TigerCreator() : new ElephantCreator();
        var fmAnimal = creator.CreateAnimal();
        Console.Write($"{animalName} ");
        fmAnimal.Speak();

        // -------------------- Abstract Factory --------------------
        Console.WriteLine("\n--- Abstract Factory ---");
        IZooFactory abstractFactory = choice == "tiger" ? new TigerFactory() : new ElephantFactory();
        var food = abstractFactory.CreateFood();
        var enclosure = abstractFactory.CreateEnclosure();
        Console.Write($"{animalName} ");
        food.Eat();
        Console.Write($"{animalName} ");
        enclosure.Place();

        // -------------------- Builder --------------------
        Console.WriteLine("\n--- Builder ---");
        var director = new Director();
        IAnimalBuilder builder = choice == "tiger" ? new TigerBuilder() : new ElephantBuilder();
        var builtAnimal = director.Build(builder);
        builtAnimal.Show();

        // -------------------- Prototype --------------------
        Console.WriteLine("\n--- Prototype ---");
        var originalAnimal = new AnimalPrototype { Name = animalName };
        var cloneAnimal = originalAnimal.Clone();
        cloneAnimal.Show();

        // -------------------- Закриття зоопарку --------------------
        zoo.Close();
        Console.WriteLine($"\nЗоопарк: {zoo.State} — виходьте!");
    }
}