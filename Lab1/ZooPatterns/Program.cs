using System;
using ZooPatterns.Singleton;
using ZooPatterns.Factory;
using ZooPatterns.FactoryMethod;
using ZooPatterns.AbstractFactory;
using ZooPatterns.Builder;
using ZooPatterns.Prototype;

// Structural
using ZooPatterns.Structural.Adapter;
using ZooPatterns.Structural.Bridge;
using ZooPatterns.Structural.Composite;
using ZooPatterns.Structural.Decorator;
using ZooPatterns.Structural.Facade;
using ZooPatterns.Structural.Proxy;


using FlyweightFactory = ZooPatterns.Structural.Flyweight.TigerFactory;

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

        // -------------------- Вибір тварини --------------------
        Console.WriteLine("\nЗ якою твариною працювати? (tiger/elephant)");
        string choice = Console.ReadLine()?.ToLower();
        string animalName = choice == "tiger" ? "Тигр" : "Слон";

        Console.WriteLine($"\nПрацюємо з {animalName}...\n");

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
        IZooFactory abstractFactory = choice == "tiger"
            ? new ZooPatterns.AbstractFactory.TigerFactory()
            : new ZooPatterns.AbstractFactory.ElephantFactory();

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

        // ==================== STRUCTURAL ====================
        Console.WriteLine("\n==================== STRUCTURAL PATTERNS ====================");

        // Adapter
        Console.WriteLine("\n--- Adapter ---");
        ZooPatterns.Structural.Adapter.IAnimal adapter = new TigerAdapter();
        adapter.Speak();

        // Bridge
        Console.WriteLine("\n--- Bridge ---");
        var bridgeAnimal = new ZooPatterns.Structural.Bridge.Tiger(new RoarBehavior());
        bridgeAnimal.Speak();

        // Composite
        Console.WriteLine("\n--- Composite ---");
        var group = new AnimalGroup();
        group.Add(new ZooPatterns.Structural.Composite.Tiger());
        group.Add(new ZooPatterns.Structural.Composite.Elephant());
        group.Speak();

        // Decorator
        Console.WriteLine("\n--- Decorator ---");
        ZooPatterns.Structural.Decorator.IAnimal decorated =
            new LoudTiger(new ZooPatterns.Structural.Decorator.Tiger());
        decorated.Speak();

        // Facade
        Console.WriteLine("\n--- Facade ---");
        var facade = new ZooFacade();
        facade.ShowAll();

        // Flyweight
        Console.WriteLine("\n--- Flyweight ---");
        var factoryFly = new FlyweightFactory();
        var t1 = factoryFly.GetTiger("білий");
        var t2 = factoryFly.GetTiger("білий");
        t1.Speak();
        t2.Speak();

        // Proxy
        Console.WriteLine("\n--- Proxy ---");
        ZooPatterns.Structural.Proxy.IAnimal proxy = new TigerProxy();
        proxy.Speak();

        // -------------------- Закриття --------------------
        zoo.Close();
        Console.WriteLine($"\nЗоопарк: {zoo.State} — До зустрічі!");
    }
}