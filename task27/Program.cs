int Promt(string? message)
{
    Console.Write(message);
    string? number = Console.ReadLine();
    int result = int.Parse(number);
    return result;
}

int Sum(int digit)
{
    int result = 0;
    while (digit > 0)
    {
        result += digit % 10;
        digit = digit / 10;
    }
    return result;
}

int digit = Promt ("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {digit} = {Sum(digit)}");