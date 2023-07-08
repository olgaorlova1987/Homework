﻿// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

const int ROWS = 3;
const int COLUMNS = 4;

double[,] randomArray = new double[ROWS, COLUMNS];

Random rand = new Random();
    for (int i = 0; i < ROWS; i++)
    {
        for (int j = 0; j < COLUMNS; j++)
        {
            randomArray[i, j] = rand.NextDouble();
        }
    }

void PrintMatrix(double[,] randomArray)
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

PrintMatrix(randomArray);
