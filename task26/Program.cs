int ReadNumber(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine()); //тело метода
}

int NumberOfDigits(int n)
{
    int i = 0;
for (i = 0; n > 0; i++)
{
    n = n / 10;
}
return i;
}

int number = ReadNumber("Введите число:");  //вызов метода
int digits = NumberOfDigits(number); // вызов метода
Console.WriteLine(digits);