// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

const int Rows1 = 2;
const int Columns1 = 2;
int[,] GetRandomMatrix(int row1, int columns1)
{
int[,] matrix1 = new int[row1, columns1];   
for(int i = 0; i < matrix1.GetLength(0); i++)   //i stroli     j stolbtsy
{
    for(int j = 0; j < matrix1.GetLength(0); j++)
    {
        matrix1[i, j] = Random.Shared.Next(1, 10);
    }
}
return matrix1;
}
void PrintMatrix(int[,] matrix1)
{
for(int i = 0; i < matrix1.GetLength(0); i++)
{
    for(int j = 0; j < matrix1.GetLength(0); j++)
    {
        Console.Write($"{matrix1[i, j]} ");
    }
    Console.WriteLine();
}
}
int[,] myMatrix1 = GetRandomMatrix(Rows1, Columns1);
Console.WriteLine($"Первая матрица:");
PrintMatrix(myMatrix1);

const int Rows2 = 2;
const int Columns2 = 2;
int[,] GetRandomMatrix1(int row2, int columns2)
{
int[,] matrix2 = new int[row2, columns2];   
for(int i = 0; i < matrix2.GetLength(0); i++)   //i stroli     j stolbtsy
{
    for(int j = 0; j < matrix2.GetLength(0); j++)
    {
        matrix2[i, j] = Random.Shared.Next(1, 10);
    }
}
return matrix2;
}
void PrintMatrix2(int[,] matrix2)
{
for(int i = 0; i < matrix2.GetLength(0); i++)
{
    for(int j = 0; j < matrix2.GetLength(0); j++)
    {
        Console.Write($"{matrix2[i, j]} ");
    }
    Console.WriteLine();
}
}
int[,] myMatrix2 = GetRandomMatrix1(Rows2, Columns2);
Console.WriteLine($"Вторая матрица:");
PrintMatrix2(myMatrix2);

int[,] ChangeMatrix(int[,] matrix1, int[,] matrix2)
{
    int row = matrix1.GetLength(0);
    int columns = matrix1.GetLength(1);
    int[,] matrix3 = new int[row, columns];
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(0); j++)
        {
            matrix3[i, j] = 0;
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, k] = matrix1[i, k] * matrix2[i,k];
            }
        }
    }   
    return matrix3;
}

int[,] myMatrix3 = ChangeMatrix(myMatrix1, myMatrix2);
PrintMatrix(myMatrix3);