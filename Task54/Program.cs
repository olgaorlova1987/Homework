// Задача 54: Задайте двумерный массив. Напишите программу, которая
//  упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

const int ROWS = 3;
const int COLUMNS = 4;

int[,] randomArray = new int[ROWS, COLUMNS];

Random rand = new Random();
    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            randomArray[i, j] = rand.Next();
        }
    }

void PrintMatrix(int[,] randomArray)
{
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            Console.Write($"{randomArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("\n Исходный массив: ");
PrintMatrix(randomArray);

void uporyadok(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
for (int k = 0; k < array.GetLength(1)-1; k++)
{
if (array[i, k] < array[i, k + 1])
{
int temp = array[i, k + 1];
array[i, k + 1] = array[i, k];
array[i, k] = temp;
}
}
}
}
}
uporyadok(randomArray);
Console.WriteLine("\nОтсортированный массив: ");
PrintMatrix(randomArray);