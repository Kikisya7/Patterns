using ZooPatterns.Factory;

namespace ZooPatterns.FactoryMethod
{
    public abstract class AnimalCreator
    {
        public abstract IAnimal CreateAnimal();
    }
}