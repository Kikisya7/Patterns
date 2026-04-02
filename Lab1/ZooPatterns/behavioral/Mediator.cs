namespace ZooPatterns.Behavioral.Mediator
{
    public class ZooMediator
    {
        public void Notify(string message)
        {
            Console.WriteLine($" Система повідомляє: {message}");
        }
    }

    public class Animal
    {
        private ZooMediator mediator;

        public Animal(ZooMediator m) => mediator = m;

        public void Act(string action)
        {
            mediator.Notify(action);
        }
    }
}