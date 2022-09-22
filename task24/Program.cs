// Console.WriteLine("Введите число N (N>0):");
// int n = Convert.ToInt32(Console.ReadLine());

int ReadNumber(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine()); //тело метода
}


int n = ReadNumber("Введите число:");  //вызов метода

int SumNumbersToA(int a)
{
    if(a >= 1)
    {
        int sum = 0;
        for (int i = 1; i <= a; i++)
        {
            sum+= i;
        }
        return sum; // вернем накопившуюся сумму
    }
else 
{
    Console.WriteLine("введено некорректное число");
    return -1; // неправильная сумма
}
}

int summa = SumNumbersToA(n);
Console.WriteLine(summa);



