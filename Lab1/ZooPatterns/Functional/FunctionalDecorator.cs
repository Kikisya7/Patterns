namespace ZooPatterns.Functional
{
    public class FunctionalDecorator
    {
        public void Execute()
        {
            Action tiger = () =>
                Console.WriteLine(" Тигр ричить");

            Action loudTiger = () =>
            {
                Console.WriteLine(" Дуже голосно!");
                tiger();
            };

            loudTiger();
        }
    }
}