namespace ZooPatterns.Structural.Facade
{
    public class Tiger
    {
        public void Speak()
        {
            Console.WriteLine(" Тигр відпочиває у тіні...");
        }
    }

    public class Elephant
    {
        public void Speak()
        {
            Console.WriteLine(" Слон повільно прогулюється...");
        }
    }

    public class ZooFacade
    {
        private Tiger tiger = new();
        private Elephant elephant = new();

        public void ShowAll()
        {
            Console.WriteLine(" Екскурсія зоопарком починається...");
            tiger.Speak();
            elephant.Speak();
            Console.WriteLine("Екскурсія завершена!");
        }
    }
}