using System.Collections.Generic;

namespace ZooPatterns.Behavioral.Iterator
{
    public class ZooCollection
    {
        private List<string> animals = new()
        {
            " Тигр",
            " Слон"
        };

        // ВАЖНО: IEnumerable, а не IEnumerator
        public IEnumerable<string> GetIterator()
        {
            return animals;
        }
    }
}