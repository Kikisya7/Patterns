namespace ZooPatterns.Behavioral.Command
{
    public class ElephantCommand : ICommand
    {
        private readonly string action;

        public ElephantCommand(string action)
        {
            this.action = action;
        }

        public void Execute()
        {
            Console.WriteLine($"Слон виконує дію: {action}");
        }
    }
}