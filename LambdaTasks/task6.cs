using System.Collections.Generic;
using System.Linq;

public class Task6
{
    public static int Sum(List<int> list)
    {
        return list.Aggregate((a, b) => a + b);
    }

    public static int Multiply(List<int> list)
    {
        return list.Aggregate((a, b) => a * b);
    }
}