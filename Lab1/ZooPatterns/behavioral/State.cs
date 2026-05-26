namespace ZooPatterns.Behavioral.State
{
    public interface IState
    {
        void Handle();
    }

    public class OpenState : IState //Поведінка від стану
    {
        public void Handle()
        {
            Console.WriteLine(" Зоопарк відкритий");
        }
    }

    public class ClosedState : IState
    {
        public void Handle()
        {
            Console.WriteLine(" Зоопарк закритий");
        }
    }

    public class ZooContext
    {
        private IState state;

        public void SetState(IState s) => state = s;

        public void Show()
        {
            state.Handle();
        }
    }
}