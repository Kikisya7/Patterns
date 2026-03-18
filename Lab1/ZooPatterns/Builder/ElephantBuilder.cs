namespace ZooPatterns.Builder
{
    public class ElephantBuilder : IAnimalBuilder
    {
        private Animal animal = new Animal();

        public void SetName() => animal.Name = "Слон";
        public void SetFood() => animal.Food = "Трава";
        public void SetHabitat() => animal.Habitat = "Поле";
        public Animal GetResult() => animal;
    }
}