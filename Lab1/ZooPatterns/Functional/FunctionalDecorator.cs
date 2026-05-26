namespace ZooPatterns.Functional
{
    public class FunctionalDecorator
    {
        public void Execute()
        {
            Action tiger = () => Console.WriteLine("Тигр ричить");
            Action elephant = () => Console.WriteLine("Слон гуляє");

            Action loudDecorator(Action action) => () =>
            {
                Console.WriteLine("Дуже голосно!");
                action();
            };

            var loudTiger = loudDecorator(tiger);
            var loudElephant = loudDecorator(elephant);

            loudTiger();
            loudElephant();
        }
    }
}