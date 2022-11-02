void Zadacha64()
{
    // Задайте значения M и N. Напишите рекурсивный метод, 
    // который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

    int m = InputInt("Введите M:");
    int n = InputInt("Введите N:");
    Console.Write ($"числа кратные 3-ём от {m} до {n} : ");
    FindDivThree(m, n);

    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }

    int FindDivThree(int m, int n)
    {
        if (m == n)
        {
            return m;
        }
        if (m % 3 == 0) 
        {
            Console.Write($"{m}, ");
        } 
        return FindDivThree(m+1, n);
    }
}


void Zadacha66()
{
    // Задайте значения M и N. Напишите программу, которая найдёт 
    // сумму натуральных элементов в промежутке от M до N.

    int m = InputInt("Введите M:");
    int n = InputInt("Введите N:");
    Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }

    int CountNaturalSum(int m, int n)
    {
        if (m == n)
            return n;
        return n + CountNaturalSum(m, n - 1);
    }
}


void Zadacha68()
{
    // Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    // Даны два неотрицательных числа m и n.

    Console.WriteLine("Введите два положительных числа: m и n.");
    int m = InputInt("Введите m: ");
    int n = InputInt("Введите n: ");
    Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }

    int Akkerman(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return Akkerman(m - 1, 1);
        else
            return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Zadacha64();
// Zadacha66();
// Zadacha68();