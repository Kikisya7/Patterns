using ZooPatterns.Factory;

namespace ZooPatterns.FactoryMethod
{
    public class TigerCreator : AnimalCreator
    {
        public override IAnimal CreateAnimal() => new Tiger();
    }
}