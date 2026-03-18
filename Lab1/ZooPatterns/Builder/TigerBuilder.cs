namespace ZooPatterns.Builder
{
    public class TigerBuilder : IAnimalBuilder
    {
        private Animal animal = new Animal();
        public void SetName() => animal.Name = "Тигр";
        public void SetFood() => animal.Food = "М'ясо";
        public void SetHabitat() => animal.Habitat = "Клітка";
        public Animal GetResult() => animal;
    }
}