using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        bool work = true;

        while (work)
        {
            Console.WriteLine("\nВиберіть завдання (1-13): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nЗадача 1: відфільтрувати непарні числа зі списку цілих чисел");
                    Console.WriteLine("Введіть числа:");
                    var list1 = ReadIntList();
                    var res1 = Task1.FilterOdd(list1);
                    Console.WriteLine("Результат: " + string.Join(", ", res1));
                    break;

                case 2:
                    Console.WriteLine("\nЗадача 2: знайти середнє зі списку дійсних значень");
                    Console.WriteLine("Введіть числа:");
                    var list2 = ReadDoubleList();
                    Console.WriteLine("Результат: " + Task2.AverageValue(list2));
                    break;

                case 3:
                    Console.WriteLine("\nЗадача 3: сортування рядків за алфавітом");
                    Console.WriteLine("Введіть рядки:");
                    var list3 = ReadStringList();
                    Console.WriteLine("Результат: " + string.Join(", ", Task3.SortAlphabet(list3)));
                    break;

                case 4:
                    Console.WriteLine("\nЗадача 4: сума парних чисел");
                    Console.WriteLine("Введіть числа:");
                    var list4 = ReadIntList();
                    Console.WriteLine("Результат: " + Task4.SumEven(list4));
                    break;

                case 5:
                    Console.WriteLine("\nЗадача 5: факторіал числа");
                    Console.WriteLine("Введіть число:");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + Task5.Factorial(n));
                    break;

                case 6:
                    Console.WriteLine("\nЗадача 6: сума та добуток елементів");
                    Console.WriteLine("Введіть числа:");
                    var list6 = ReadIntList();
                    Console.WriteLine("Сума: " + Task6.Sum(list6));
                    Console.WriteLine("Множення: " + Task6.Multiply(list6));
                    break;

                case 7:
                    Console.WriteLine("\nЗадача 7: квадрати чисел");
                    Console.WriteLine("Введіть числа:");
                    var list7 = ReadIntList();
                    Console.WriteLine("Результат: " + string.Join(", ", Task7.Squares(list7)));
                    break;

                case 8:
                    Console.WriteLine("\nЗадача 8: сортування рядків за довжиною");
                    Console.WriteLine("Введіть рядки:");
                    var list8 = ReadStringList();
                    Console.WriteLine("Результат: " + string.Join(", ", Task8.SortByLength(list8)));
                    break;

                case 9:
                    Console.WriteLine("\nЗадача 9: підрахунок кількості слів");
                    Console.WriteLine("Введіть речення:");
                    string text = Console.ReadLine();
                    Console.WriteLine("Результат: " + Task9.CountWords(text));
                    break;

                case 10:
                    Console.WriteLine("\nЗадача 10: перший непорожній рядок");
                    Console.WriteLine("Введіть рядки:");
                    var list10 = ReadStringList();
                    Console.WriteLine("Результат: " + Task10.FirstNonEmpty(list10));
                    break;

                case 11:
                    Console.WriteLine("\nЗадача 11: перевірка великих літер");
                    Console.WriteLine("Введіть рядки:");
                    var list11 = ReadStringList();
                    Console.WriteLine("Результат: " + Task11.AllStartWithUpper(list11));
                    break;

                case 12:
                    Console.WriteLine("\nЗадача 12: друге за величиною число");
                    Console.WriteLine("Введіть числа:");
                    var list12 = ReadIntList();
                    Console.WriteLine("Результат: " + Task12.SecondLargest(list12));
                    break;

                case 13:
                    Console.WriteLine("\nЗадача 13: найбільше парне число");
                    Console.WriteLine("Введіть числа:");
                    var list13 = ReadIntList();
                    Console.WriteLine("Результат: " + Task13.MaxEven(list13));
                    break;

                default:
                    Console.WriteLine("Невірний вибір");
                    break;
            }

            // 🔁 продолжение
            Console.WriteLine("\nПродовжити роботу?");
            Console.WriteLine("1 - Так");
            Console.WriteLine("0 - Ні");

            int cont = int.Parse(Console.ReadLine());
            if (cont == 0)
                work = false;
        }

        Console.WriteLine("Програму завершено.");
    }

    // ===== Ввід =====
    static List<int> ReadIntList() =>
        Console.ReadLine().Split(' ').Select(int.Parse).ToList();

    static List<double> ReadDoubleList() =>
        Console.ReadLine().Split(' ').Select(double.Parse).ToList();

    static List<string> ReadStringList() =>
        Console.ReadLine().Split(' ').ToList();
}