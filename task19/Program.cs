// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string? Promt(string? message)
{
    Console.Write(message);
    string? result = Convert.ToString(Console.ReadLine());
    return result;
}

string? number = Promt ("Введите пятизначное число: ");
// if (number<10000 || number>=100000)
// {
//     Console.WriteLine("Вы ввели не пятизначное число");
//     return;
// }

Console.WriteLine($"Введенное число {number}");
if (number[0] == number[4] && number[1] == number [3])
{
    Console.WriteLine("Это палендром");
} 
else
{
    Console.WriteLine("Это не палендром");
}