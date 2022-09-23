int ReadNumber(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine()); //тело метода
}


int SumNumbersToA(int a)
{
    if(a >= 1)
    {
        int sum = 1;
        for (int i = 1; i <= a; i++)
        {
            sum = sum * i;
        }
        return sum; // вернем накопившуюся сумму
    }
else 
{
    Console.WriteLine("введено некорректное число");
    return -1; // неправильная сумма
}
}
int n = ReadNumber("Введите число:");  //вызов метода
int summa = SumNumbersToA(n); // вызов метода
Console.WriteLine(summa);





