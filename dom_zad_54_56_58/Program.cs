void Zadacha54()
{   
    // Задайте двумерный массив. Напишите программу, 
    // которая упорядочит по убыванию элементы каждой строки двумерного массива.


    Console.WriteLine("введите кол-во строк");
    int linesVol = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите кол-во столбцов");
    int columnsVol = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[linesVol, columnsVol];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1]) 
                {
                    int temp = 0;
                    temp = numbers[i, k];
                    numbers[i, k] = numbers[i, k + 1];
                    numbers[i, k + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    PrintArray(numbers);
}
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


void Zadacha56()
{   
    // Задайте прямоугольный двумерный массив. Напишите программу, 
    // которая будет находить строку с наименьшей суммой элементов. 


    Console.WriteLine("введите размер двумерного массива");
    int massVol = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[massVol, massVol];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    int minsum = Int32.MaxValue;
    int indexLine = 0;

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];        
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }

    Console.WriteLine("строка с наименьшей суммой елементов: " + (indexLine));
    Console.WriteLine("сумма елементов = " + (minsum));
}


void Zadacha58()
{
    // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


    int InputInt(string output)
    {
        Console.Write(output);
        return int.Parse(Console.ReadLine());
    }

    int size = InputInt("размерность матриц: ");
    int[,] matrixA = new int[size, size];
    int[,] matrixB = new int[size, size];
    FillArrayRandomNumbers(matrixA);
    FillArrayRandomNumbers(matrixB);
    int[,] matrixC = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }

    Console.WriteLine("Матрица А");
    PrintArray(matrixA);
    Console.WriteLine();

    Console.WriteLine("Матрица В");
    PrintArray(matrixB);
    Console.WriteLine();

    Console.WriteLine("Произведение");
    PrintArray(matrixC);
    

}
// Zadacha54();
// Zadacha56();
// Zadacha58();