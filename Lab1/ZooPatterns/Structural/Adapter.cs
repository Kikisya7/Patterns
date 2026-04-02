namespace ZooPatterns.Structural.Adapter //якщо не підходить класс
{
    public interface IAnimal
    {
        void Speak();
    }

    public class WeirdTiger
    {
        public void RealSpeak()
        {
            Console.WriteLine(" (незвичайний звук тигра)");
        }
    }

    public class TigerAdapter : IAnimal
    {
        private WeirdTiger adaptee = new();

        public void Speak()
                 {
            Console.WriteLine(" Незвичайна тварина поводиться як тигр:");
            adaptee.RealSpeak();
        }
    }
}