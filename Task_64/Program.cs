class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        PrintNumbersFromNTo1(n);

        Console.ReadKey();
    }

    static void PrintNumbersFromNTo1(int n)
    {
        if (n == 0) // базовый случай
        {
            return;
        }
        else // рекурсивный случай
        {
            Console.Write(n + " ");
            PrintNumbersFromNTo1(n - 1);
        }
    }
}