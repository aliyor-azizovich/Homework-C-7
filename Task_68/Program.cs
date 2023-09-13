class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main()
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);

        Console.WriteLine("Результат функции Аккермана для m={0} и n={1} равен {2}", m, n, result);
    }
}


// Функция Аккермана определяется следующим образом:
// - A(m, n) = n + 1, если m = 0
// - A(m, n) = A(m - 1, 1), если m > 0 и n = 0
// - A(m, n) = A(m - 1, A(m, n - 1)), если m > 0 и n > 0

//    !!!!!!!!!!!!!!!!!!!!!!!!!!
// ВАЖНО!!!
// Функция Аккермана растет очень быстро, и уже при небольших значениях m и n может вызвать переполнение стека
//  из-за большой глубины рекурсии. 
// Это может привести к ошибке "StackOverflowException".