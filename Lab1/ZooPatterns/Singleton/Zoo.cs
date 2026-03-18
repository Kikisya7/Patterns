namespace ZooPatterns.Singleton
{
    public class Zoo
    {
        private static Zoo instance;
        public string State { get; private set; }

        private Zoo() { State = "Закритий"; }

        public static Zoo GetInstance()
        {
            if (instance == null) instance = new Zoo();
            return instance;
        }

        public void Open() { State = "Відкритий"; }
        public void Close() { State = "Закритий"; }
    }
}