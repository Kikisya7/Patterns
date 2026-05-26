namespace ZooPatterns.Behavioral.Strategy
{
    public interface IStrategy
    {
        void Act();
    }

    public class TigerStrategy : IStrategy //вибір поведінки
    {
        public void Act()
        {
            Console.WriteLine("Тигр полює");
        }
    }

    public class ElephantStrategy : IStrategy
    {
        public void Act()
        {
            Console.WriteLine(" Слон гуляє спокійно");
        }
    }

    public class Animal
    {
        private IStrategy strategy;

        public void SetStrategy(IStrategy s) => strategy = s;

        public void Act()
        {
            strategy.Act();
        }
    }
}