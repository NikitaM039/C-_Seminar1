string[] array;
Console.WriteLine("Введите массив строк через пробел");
string? row = Console.ReadLine();
array = row.Split(' ');
string[] array2 = new string[array.Length];

void SecondArrayWithIF(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
}
SecondArrayWithIF(array, array2);
System.Console.WriteLine("Новый массив:");
PrintArray(array2);