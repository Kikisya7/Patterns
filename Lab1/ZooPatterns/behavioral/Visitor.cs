namespace ZooPatterns.Behavioral.Visitor
{
    public interface IVisitor
    {
        void VisitTiger(Tiger tiger);
        void VisitElephant(Elephant elephant);
    }

    public class Tiger
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitTiger(this);
        }
    }

    public class Elephant
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitElephant(this);
        }
    }

    public class VetVisitor : IVisitor
    {
        public void VisitTiger(Tiger tiger)
        {
            Console.WriteLine("Лікар оглянув тигра");
        }

        public void VisitElephant(Elephant elephant)
        {
            Console.WriteLine("Лікар оглянув слона");
        }
    }
}