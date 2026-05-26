using System.Collections.Generic;

namespace ZooPatterns.Behavioral.Iterator //перебира коллекцію
{
    public class ZooCollection
    {
        private List<string> animals = new()
        {
            " Тигр",
            " Слон"
        };

        
        public IEnumerable<string> GetIterator()
        {
            return animals;
        }
    }
}