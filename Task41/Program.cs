// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество элементов массива");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];
for (int i = 0; i < a; i++)
{
    randomArray[i] = new Random().NextDouble();
    Console.WriteLine(randomArray[i]);
}
int kol(double[] randomArray)
{
    int sum = 0;
    int j = 0;
    while (j < randomArray.Length)
    {
        sum = sum + 1;
        j = j + 1;
    }
    return sum; 
}
Console.WriteLine($"Количество чисел больше 0: {kol(randomArray)}");