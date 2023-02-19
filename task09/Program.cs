int number = new Random().Next(100,1000);
Console.WriteLine($"Ваше случайное число: {number}");
int digit2 = number/10;
int digit2_1 = digit2%10;
Console.WriteLine($"Ваше получившееся число: {digit2_1}");