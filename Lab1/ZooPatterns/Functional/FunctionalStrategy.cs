namespace ZooPatterns.Functional
{
    public class FunctionalStrategy
    {
        public void Execute()
        {
            RunAnimalBehavior(() => Console.WriteLine("Тигр полює"));
            RunAnimalBehavior(() => Console.WriteLine("Слон гуляє"));
        }

        private void RunAnimalBehavior(Action behavior)
        {
            behavior();
        }
    }
}