Console.Write("Введите число:");
string N = Console.ReadLine();
int length = N.Length;

if (length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    char thirdsymbol = N[2];
    Console.WriteLine(thirdsymbol);
}