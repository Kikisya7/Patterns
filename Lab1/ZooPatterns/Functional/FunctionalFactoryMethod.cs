namespace ZooPatterns.Functional
{
    public class FunctionalFactoryMethod
    {
        public void Execute()
        {
            Func<string, Action> animalFactory = type =>
                type switch
                {
                    "tiger" => () => Console.WriteLine("Тигр створений і ричить"),
                    "elephant" => () => Console.WriteLine("Слон створений і гуляє"),
                    _ => () => Console.WriteLine("Невідома тварина")
                };

            var tiger = animalFactory("tiger");
            var elephant = animalFactory("elephant");

            tiger();
            elephant();
        }
    }
}