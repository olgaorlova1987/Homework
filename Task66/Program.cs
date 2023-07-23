// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM=1;
int numberN =15;
void Perechislenie(int LastNumber, int FirstNumber)
{
    if(LastNumber<=FirstNumber-1) return;
    Perechislenie(LastNumber -1, FirstNumber);
    Console.Write(LastNumber +"  ");

}
    
Perechislenie(numberN, numberM);
Console.WriteLine();

SumFromMToN(numberM, numberN);
void SumFromMToN(int numberM, int numberN)
{
    Console.WriteLine ($"Сумма всех натуральных элементов от M до N:  {SumMN(numberM - 1, numberN)}");
}
int SumMN(int numberM, int numberN)
{
    int res = numberM;
    if (numberM == numberN)
        return 0;
    else
    {
        numberM++;
        res = numberM + SumMN(numberM, numberN);
        return res;
    }
}