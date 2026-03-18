namespace ZooPatterns.Prototype
{
    public class AnimalPrototype
    {
        public string Name;
        public AnimalPrototype Clone() => (AnimalPrototype)this.MemberwiseClone();
        public void Show() => Console.WriteLine($"Клон: {Name}");
    }
}