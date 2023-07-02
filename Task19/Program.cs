// Задача 19
// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да!");

Console.WriteLine("Введите пятизначное число и мы проверим палиндром это или нет");
int number = Convert.ToInt32(Console.ReadLine());

if(number >100000)
{
    Console.WriteLine("Число введено неверно, больше 5 знаков");
}
if (number <10000)
{
    Console.WriteLine("Число введено неверно, меньше 5 знаков");
}
int number1= number%10000;
int number2 = (number - (number1*10000))%1000;
int number3 = (number - (number1*10000) - (number2*1000)) %100;
int number4 = (number - (number1*10000) - (number2*1000)- (number3* 100)) %10;
int number5 = (number - (number1*10000) - (number2*1000)- (number3* 100)- (number4* 10));

int newnumber1 = number5;
int newnumber2 = number4;
int newnumber3 = number3;
int newnumber4 = number2;
int newnumber5 = number1;

string newnumber = "newnumber1,newnumber2,newnumber3,newnumber4,newnumber5";
string number1 = "number1, number2, number3, number4, number5";


if (string newnumber == string newnumber)
{
    Console.WriteLine("Это число палиндром");
}

else
{
    Console.WriteLine ("Это число не палиндром");
}