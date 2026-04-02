namespace ZooPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler next;

        public void SetNext(Handler n) => next = n;

        public virtual void Handle(string request)
        {
            if (next != null)
                next.Handle(request);
        }
    }

    public class Guard : Handler
    {
        public override void Handle(string request)
        {
            if (request == "вхід")
                Console.WriteLine(" Охоронець пропустив відвідувача");
            else
                base.Handle(request);
        }
    }

    public class Vet : Handler
    {
        public override void Handle(string request)
        {
            if (request == "лікування")
                Console.WriteLine(" Ветеринар лікує тварину");
            else
                base.Handle(request);
        }
    }

    public class Manager : Handler
    {
        public override void Handle(string request)
        {
            Console.WriteLine(" Менеджер вирішив складну проблему");
        }
    }
}