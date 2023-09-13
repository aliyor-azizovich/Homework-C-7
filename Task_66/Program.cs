class Program
{
    static int Sum(int m, int n)
    {
        if (m > n) // базовый случай: если m больше n, то возвращаем 0
        {
            return 0;
        }
        else // рекурсивный случай: складываем текущее значение m с суммой оставшихся элементов
        {
            return m + Sum(m + 1, n);
        }
    }

    static void Main()
    {
        Console.Write("Введите начальное значение промежутка: ");
        int m = int.Parse(Console.ReadLine()); // вводим начальное значение промежутка

        Console.Write("Введите конечное значение промежутка: ");
        int n = int.Parse(Console.ReadLine()); // вводим конечное значение промежутка

        int sum = Sum(m, n); // вызываем функцию для нахождения суммы

        Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна {2}", m, n, sum);
    }
}