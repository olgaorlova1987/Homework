// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

const int Rows = 4;
const int Columns = 4;
int[,] GetRandomMatrix(int row, int columns)
{
int[,] matrix = new int[row, columns];   
for(int i = 0; i < matrix.GetLength(0); i++)   //i stroli     j stolbtsy
{
    for(int j = 0; j < matrix.GetLength(0); j++)
    {
        matrix[i, j] = Random.Shared.Next(1, 10);
    }
}
return matrix;
}
void PrintMatrix(int[,] matrix)
{
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(0); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}
int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);

Console.WriteLine();
int SumLine(int[,] myMatrix, int i)
{
int sum = myMatrix[i,0];
for (int j = 1; j < myMatrix.GetLength(1); j++)
{
sum += myMatrix[i,j];
}
return sum;
}

int minSum = 1;
int sum = SumLine(myMatrix, 0);
for (int i = 1; i < myMatrix.GetLength(0); i++)
{
if (sum > SumLine(myMatrix, i))
{
sum = SumLine(myMatrix, i);
minSum = i+1;
}
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");