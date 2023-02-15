Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 1;
while(temp<=N)
if(temp % 2==0)
{
    Console.Write($"{temp} ");
    temp++;
}

else
{
    temp++;
}