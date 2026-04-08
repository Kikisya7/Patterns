using System.Linq;

public class Task5
{
    public static int Factorial(int n)
    {
        return Enumerable.Range(1, n).Aggregate((a, b) => a * b);
    }
}