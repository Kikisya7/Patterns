namespace ZooPatterns.Builder
{
    public interface IAnimalBuilder
    {
        void SetName();
        void SetFood();
        void SetHabitat();
        Animal GetResult();
    }
}