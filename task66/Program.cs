// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}

System.Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма элементов от {number1} до {number2} = {CountNaturalSum(number1, number2)}");


