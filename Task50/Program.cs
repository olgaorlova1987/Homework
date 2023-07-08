// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

const int ROWS = 3;
const int COLUMNS = 4;

int[,] GetRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);

Console.WriteLine("Введите номер строки: ");
int numberRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int numberColumns = Convert.ToInt32(Console.ReadLine());

if (numberRows < 1 || numberColumns < 1)
{
    Console.WriteLine("Номер строки не может быть отрицательным");
}
else if (numberRows <= ROWS + 1 && numberColumns <= COLUMNS + 1)
{
    Console.WriteLine($"Значение элемента равно {myMatrix[numberRows - 1, numberColumns - 1]}");
}

else 
{
    Console.WriteLine("Такого элемента нет");
}

