namespace ZooPatterns.Structural.Composite
{
    public interface IAnimal
    {
        void Speak();
    }

    public class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Тигр спостерігає за людьми...");
        }
    }

    public class Elephant : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine(" Слон махає хоботом...");
        }
    }

    public class AnimalGroup : IAnimal
    {
        private List<IAnimal> animals = new();

        public void Add(IAnimal a) => animals.Add(a);

        public void Speak()
        {
            Console.WriteLine(" Ви заходите у велику зону з тваринами:");
            foreach (var a in animals)
                a.Speak();
        }
    }
}