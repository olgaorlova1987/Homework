// Задача 25: Напишите функцию, которая принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
double a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень");
double b = Convert.ToInt32(Console.ReadLine());
double newnumber= Convert.ToInt32(Console.ReadLine());

for (int i=1, i++)
{
    if (i<b)
    {
        newnumber = a*a;
    }
    else
    {
        break;
    }
}
   
Console.WriteLine($"Число в степени :{newnumber}");


 

