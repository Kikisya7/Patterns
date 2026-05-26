namespace ZooPatterns.Behavioral.TemplateMethod
{
    public abstract class Animal
    {
        public void LiveDay()
        {
            Eat();
            Move();
        }

        protected abstract void Eat();
        protected abstract void Move();
    }

    public class Tiger : Animal //шаблон алгоритму
    {
        protected override void Eat()
        {
            Console.WriteLine(" Тигр їсть м'ясо");
        }

        protected override void Move()
        {
            Console.WriteLine(" Тигр ходить по вольєру");
        }
    }

    public class Elephant : Animal
    {
        protected override void Eat()
        {
            Console.WriteLine(" Слон їсть траву");
        }

        protected override void Move()
        {
            Console.WriteLine(" Слон повільно рухається");
        }
    }
}