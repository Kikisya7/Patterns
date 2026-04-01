namespace ZooPatterns.Structural.Proxy
{
    public interface IAnimal
    {
        void Speak();
    }

    public class RealTiger : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine(" Тигр голосно ричить, захищаючи свою територію!");
        }
    }

    public class TigerProxy : IAnimal
    {
        private RealTiger tiger;

        public void Speak()
        {
            if (tiger == null)
            {
                Console.WriteLine(" Ви наближаєтесь до вольєру тигра...");
                tiger = new RealTiger();
            }

            Console.Write(" Охорона дозволяє подивитись: ");
            tiger.Speak();
        }
    }
}