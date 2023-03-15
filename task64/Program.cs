// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void RoadTon(int N, int M = 1)
{
  if(N == M+1)
  {
    return;
  }
  RoadTon(N+1,M);
  Console.Write($"{N} ");
}

System.Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(1);
RoadTon(number2, number1);