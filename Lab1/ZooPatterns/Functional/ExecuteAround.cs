namespace ZooPatterns.Functional
{
    public class ExecuteAround
    {
        public void Run(Action action)
        {
            Console.WriteLine(" Відкриття ресурсу");

            action();

            Console.WriteLine(" Закриття ресурсу");
        }
    }
}