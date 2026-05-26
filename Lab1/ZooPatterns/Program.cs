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

// Behavioral
using ZooPatterns.Behavioral.Command;
using ZooPatterns.Behavioral.ChainOfResponsibility;
using ZooPatterns.Behavioral.Iterator;
using ZooPatterns.Behavioral.Mediator;
using ZooPatterns.Behavioral.Memento;
using ZooPatterns.Behavioral.Observer;
using ZooPatterns.Behavioral.State;
using ZooPatterns.Behavioral.Strategy;
using ZooPatterns.Behavioral.TemplateMethod;
using ZooPatterns.Behavioral.Visitor;

//lab5
using ZooPatterns.Functional;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // -------------------- Singleton --------------------

        var zoo = ZooPatterns.Singleton.Zoo.GetInstance();

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

        string animalName = choice == "tiger"
            ? "Тигр"
            : "Слон";

        Console.WriteLine($"\nПрацюємо з {animalName}...\n");

        // -------------------- Factory --------------------

        Console.WriteLine("--- Factory ---");

        var animal =
            ZooPatterns.Factory.AnimalFactory.CreateAnimal(choice);

        if (animal != null)
        {
            Console.Write($"{animalName} ");
            animal.Speak();
        }

        // -------------------- Factory Method --------------------

        Console.WriteLine("\n--- Factory Method ---");

        ZooPatterns.FactoryMethod.AnimalCreator creator =
            choice == "tiger"
            ? new TigerCreator()
            : new ElephantCreator();

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

        IAnimalBuilder builder = choice == "tiger"
            ? new TigerBuilder()
            : new ElephantBuilder();

        var builtAnimal = director.Build(builder);

        builtAnimal.Show();

        // -------------------- Prototype --------------------

        Console.WriteLine("\n--- Prototype ---");

        var originalAnimal = new AnimalPrototype
        {
            Name = animalName
        };

        var cloneAnimal = originalAnimal.Clone();

        cloneAnimal.Show();

        // ==================== STRUCTURAL ====================

        Console.WriteLine("\n==================== STRUCTURAL PATTERNS ====================");

        // Adapter

        Console.WriteLine("\n--- Adapter ---");

        ZooPatterns.Structural.Adapter.IAnimal adapter =
            new TigerAdapter();

        adapter.Speak();

        // Bridge

        Console.WriteLine("\n--- Bridge ---");

        var bridgeAnimal =
            new ZooPatterns.Structural.Bridge.Tiger(
                new RoarBehavior());

        bridgeAnimal.Speak();

        // Composite

        Console.WriteLine("\n--- Composite ---");

        var group =
            new ZooPatterns.Structural.Composite.AnimalGroup();

        group.Add(new ZooPatterns.Structural.Composite.Tiger());

        group.Add(new ZooPatterns.Structural.Composite.Elephant());

        group.Speak();

        // Decorator

        Console.WriteLine("\n--- Decorator ---");

        ZooPatterns.Structural.Decorator.IAnimal decorated =
            new ZooPatterns.Structural.Decorator.LoudTiger(
                new ZooPatterns.Structural.Decorator.Tiger());

        decorated.Speak();

        // Facade

        Console.WriteLine("\n--- Facade ---");

        var facade =
            new ZooPatterns.Structural.Facade.ZooFacade();

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

        ZooPatterns.Structural.Proxy.IAnimal proxy =
            new ZooPatterns.Structural.Proxy.TigerProxy();

        proxy.Speak();

        // ==================== COMMAND ====================

        Console.WriteLine("\n==================== COMMAND PATTERN ====================");

        var invoker = new Invoker();

        invoker.AddCommand(new TigerCommand("Ричить"));

        invoker.AddCommand(new TigerCommand("Грається з м’ячем"));

        invoker.AddCommand(new ElephantCommand("Трубить"));

        invoker.AddCommand(new ElephantCommand("Ходить по території"));

        invoker.ExecuteCommands();

        // ==================== BEHAVIORAL ====================

        Console.WriteLine("\n==================== BEHAVIORAL PATTERNS ====================");

        // Chain Of Responsibility

        Console.WriteLine("\n--- Chain Of Responsibility ---");

        var guard = new Guard();

        var vet = new Vet();

        var manager = new Manager();

        guard.SetNext(vet);

        vet.SetNext(manager);

        guard.Handle("лікування");

        // Iterator

        Console.WriteLine("\n--- Iterator ---");

        var animals = new ZooCollection();

        foreach (var a in animals.GetIterator())
        {
            Console.WriteLine(a);
        }

        // Mediator

        Console.WriteLine("\n--- Mediator ---");

        var mediator = new ZooMediator();

        var mediatorAnimal =
            new ZooPatterns.Behavioral.Mediator.Animal(mediator);

        mediatorAnimal.Act("Тигр хоче їсти");

        // Memento

        Console.WriteLine("\n--- Memento ---");

        var zooMemory =
            new ZooPatterns.Behavioral.Memento.Zoo();

        zooMemory.State = "Відкритий";

        var save = zooMemory.Save();

        zooMemory.State = "Закритий";

        zooMemory.Restore(save);

        // Observer

        Console.WriteLine("\n--- Observer ---");

        var observerZoo =
            new ZooPatterns.Behavioral.Observer.Zoo();

        var visitor =
            new ZooPatterns.Behavioral.Observer.Visitor();

        observerZoo.Notify += visitor.Update;

        observerZoo.Open();

        // State

        Console.WriteLine("\n--- State ---");

        var context = new ZooContext();

        context.SetState(new OpenState());

        context.Show();

        // Strategy

        Console.WriteLine("\n--- Strategy ---");

        var strategyAnimal =
            new ZooPatterns.Behavioral.Strategy.Animal();

        strategyAnimal.SetStrategy(new TigerStrategy());

        strategyAnimal.Act();

        // Template Method

        Console.WriteLine("\n--- Template Method ---");

        ZooPatterns.Behavioral.TemplateMethod.Animal templateAnimal =
            new ZooPatterns.Behavioral.TemplateMethod.Tiger();

        templateAnimal.LiveDay();

        // Visitor

        Console.WriteLine("\n--- Visitor ---");

        var vetVisitor = new VetVisitor();

        var tigerVisitor =
            new ZooPatterns.Behavioral.Visitor.Tiger();

        var elephantVisitor =
            new ZooPatterns.Behavioral.Visitor.Elephant();

        tigerVisitor.Accept(vetVisitor);

        elephantVisitor.Accept(vetVisitor);
        // ==================== Functional ====================

        Console.WriteLine("\n==================== FUNCTIONAL PATTERNS ====================");

        // Functional Strategy
        Console.WriteLine("\n--- Functional Strategy ---");

        var functionalStrategy = new FunctionalStrategy();

        functionalStrategy.Execute();

        // Functional Factory Method
        Console.WriteLine("\n--- Functional Factory Method ---");

        var functionalFactory = new FunctionalFactoryMethod();

        functionalFactory.Execute();

        // Functional Decorator
        Console.WriteLine("\n--- Functional Decorator ---");

        var functionalDecorator = new FunctionalDecorator();

        functionalDecorator.Execute();

        // Execute Around
        Console.WriteLine("\n--- Execute Around ---");

        var executeAround = new ExecuteAround();

        executeAround.Run(() =>
        {
            Console.WriteLine(" Тигр їсть");
        });

        // -------------------- Закриття зоопарку --------------------

        zoo.Close();

        Console.WriteLine($"\nЗоопарк: {zoo.State} — До зустрічі!");
    }
}