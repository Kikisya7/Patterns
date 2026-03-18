namespace ZooPatterns.AbstractFactory
{
    public interface IZooFactory
    {
        IFood CreateFood();
        IEnclosure CreateEnclosure();
    }
}