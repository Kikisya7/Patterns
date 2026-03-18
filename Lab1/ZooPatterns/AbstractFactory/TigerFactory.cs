namespace ZooPatterns.AbstractFactory
{
    public class TigerFactory : IZooFactory
    {
        public IFood CreateFood() => new Meat();
        public IEnclosure CreateEnclosure() => new Cage();
    }
}