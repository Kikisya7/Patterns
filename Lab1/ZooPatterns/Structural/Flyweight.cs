namespace ZooPatterns.Structural.Flyweight
{
    public class Tiger
    {
        private string color;

        public Tiger(string color)
        {
            this.color = color;
        }

        public void Speak()
        {
            Console.WriteLine($" {color} тигр граційно лежить і спостерігає за відвідувачами...");
        }
    }

    public class TigerFactory
    {
        private Dictionary<string, Tiger> tigers = new();

        public Tiger GetTiger(string color)
        {
            if (!tigers.ContainsKey(color))
                tigers[color] = new Tiger(color);

            return tigers[color];
        }
    }
}