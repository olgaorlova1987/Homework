// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

for (int i = 0; i < a; i++)
{
    randomArray[i] = new Random().Next(-100, 100);
    Console.WriteLine(randomArray[i] + "");
}
int kol(int[] randomArray)
{
    int sum = 0;
    int j = 0;
    while (j < randomArray.Length)
    {
        sum = sum + randomArray[j];
        j = j + 2;
    }
    return sum;
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {kol(randomArray)}");