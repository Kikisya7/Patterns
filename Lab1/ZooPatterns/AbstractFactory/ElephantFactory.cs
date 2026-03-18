namespace ZooPatterns.AbstractFactory
{
    public class ElephantFactory : IZooFactory
    {
        public IFood CreateFood() => new Grass();
        public IEnclosure CreateEnclosure() => new Field();
    }
}