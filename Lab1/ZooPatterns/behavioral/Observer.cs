namespace ZooPatterns.Behavioral.Observer
{
    public class Zoo //підписка на дії
    {
        public event Action Notify;

        public void Open()
        {
            Console.WriteLine(" Зоопарк відкрився!");
            Notify?.Invoke();
        }
    }

    public class Visitor
    {
        public void Update()
        {
            Console.WriteLine(" Відвідувач прийшов у зоопарк");
        }
    }
}