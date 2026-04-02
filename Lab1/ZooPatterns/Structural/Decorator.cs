namespace ZooPatterns.Structural.Decorator //+нова поведінка
{
    public interface IAnimal
    {
        void Speak();
    }

    public class Tiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Тигр повільно ходить по вольєру і тихо ричить...");
        }
    }

    public abstract class AnimalDecorator : IAnimal
    {
        protected IAnimal animal;
        public AnimalDecorator(IAnimal a) => animal = a;

        public virtual void Speak() => animal.Speak();
    }

    public class LoudTiger : AnimalDecorator
    {
        public LoudTiger(IAnimal a) : base(a) { }

        public override void Speak()
        {
            Console.Write("Тигр сьогодні особливо активний! ");
            base.Speak();
        }
    }
}