namespace ZooPatterns.Structural.Bridge //розділ абрстракції та реалізації
{
    public interface ISound
    {
        void MakeSound();
    }

    public class RoarBehavior : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine(" Тварина видає гучний рик...");
        }
    }

    public abstract class Animal
    {
        protected ISound behavior;

        public Animal(ISound b) => behavior = b;

        public abstract void Speak();
    }

    public class Tiger : Animal
    {
        public Tiger(ISound b) : base(b) { }

        public override void Speak()
        {
            Console.Write(" Поведінка тварини: ");
            behavior.MakeSound();
        }
    }
}