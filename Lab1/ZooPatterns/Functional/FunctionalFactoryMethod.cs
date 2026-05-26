namespace ZooPatterns.Functional
{
    public class FunctionalFactoryMethod
    {
        public void Execute()
        {
            Func<string, string> animalFactory = type =>
            {
                return type switch
                {
                    "tiger" => " Створено тигра",
                    "elephant" => " Створено слона",
                    _ => " Невідома тварина"
                };
            };

            Console.WriteLine(animalFactory("tiger"));
            Console.WriteLine(animalFactory("elephant"));
        }
    }
}