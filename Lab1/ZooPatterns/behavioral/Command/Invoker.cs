using System.Collections.Generic;

namespace ZooPatterns.Behavioral.Command //дія- це об'єкт
{
    public class Invoker
    {
        private readonly List<ICommand> commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
            commands.Clear(); 
        }
    }
}