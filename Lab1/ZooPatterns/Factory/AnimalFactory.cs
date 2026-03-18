namespace ZooPatterns.Factory
{
    public class AnimalFactory
    {
        public static IAnimal CreateAnimal(string type)
        {
            if (type == "tiger") return new Tiger();
            if (type == "elephant") return new Elephant();
            return null;
        }
    }
}