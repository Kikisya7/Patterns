using ZooPatterns.Factory;

namespace ZooPatterns.FactoryMethod
{
    public class ElephantCreator : AnimalCreator
    {
        public override IAnimal CreateAnimal() => new Elephant();
    }
}