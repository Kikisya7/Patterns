namespace ZooPatterns.Behavioral.Command
{
    public class TigerCommand : ICommand
    {
        private readonly string action;

        public TigerCommand(string action)
        {
            this.action = action;
        }

        public void Execute()
        {
            Console.WriteLine($"Тигр виконує дію: {action}");
        }
    }
}