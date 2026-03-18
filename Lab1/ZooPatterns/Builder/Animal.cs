namespace ZooPatterns.Builder
{
    public class Animal
    {
        public string Name;
        public string Food;
        public string Habitat;
        public void Show() => Console.WriteLine($"Тварина: {Name}, Їжа: {Food}, Місце: {Habitat}");
    }
}