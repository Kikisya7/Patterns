namespace ZooPatterns.Builder
{
    public class Director
    {
        public Animal Build(IAnimalBuilder builder)
        {
            builder.SetName();
            builder.SetFood();
            builder.SetHabitat();
            return builder.GetResult();
        }
    }
}