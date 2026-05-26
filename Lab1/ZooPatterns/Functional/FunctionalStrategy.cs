namespace ZooPatterns.Functional
{
    public class FunctionalStrategy
    {
        public void Execute()
        {
            Action tiger = () =>
                Console.WriteLine(" Тигр полює");

            Action elephant = () =>
                Console.WriteLine(" Слон гуляє");

            tiger();
            elephant();
        }
    }
}