// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите длину массива = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    {
        Console.Write($"Число массива [{i + 1}] = ");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    if (a[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"[{string.Join(", ", a)}]");
Console.WriteLine($"{count}");