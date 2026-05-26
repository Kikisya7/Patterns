namespace ZooPatterns.Behavioral.Memento
{
    public class Memento //сохранение состояния
    {
        public string State;

        public Memento(string state)
        {
            State = state;
        }
    }

    public class Zoo
    {
        public string State;

        public Memento Save()
        {
            Console.WriteLine(" Збереження стану...");
            return new Memento(State);
        }

        public void Restore(Memento m)
        {
            State = m.State;
            Console.WriteLine($" Відновлено стан: {State}");
        }
    }
}