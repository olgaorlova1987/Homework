﻿// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 9
// m = 2, n = 3 -> A(m,n) = 29

int m=3;
int n=2;

Akkerman(m,n);

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return (AkkermanFunction (m - 1, AkkermanFunction (m, n - 1)));
    }
}
void Akkerman(int m, int n)
{
    Console.WriteLine ($"Функция Аккермана: {AkkermanFunction(m, n)}");
}
