// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


Console.WriteLine("Введите количество элементов массива");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];
for (int i = 0; i < a; i++)
{
    randomArray[i] = new Random().NextDouble();
    Console.WriteLine(randomArray[i]);
}
double raz(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    for (int i = 1; i < randomArray.Length; i++)
    {
        if (max < randomArray[i])
        {
            max = randomArray[i];
        }
        if (min > randomArray[i])
        {
            min = randomArray[i];
        }
    }
    return max - min;
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {raz(randomArray)}");