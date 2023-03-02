// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.

// [3 7 22 2 78] -> 76

int[] FillArrayWithRandomNumbers(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
int minnumber = 0;
int maxnumber = 0;

    for (int i = 0; i < array.Length - 1; i++)
    {

        for (int j = i+1; i < array.Length; j++)
        {
        if (array[j] < array[minnumber]) minnumber = j;
        }
        // for (int k = i + 1; i < array.Length; k++)
        // {
        //     if (array[k] < array[maxnumber]) maxnumber = k;
        // }
        
    }

Console.WriteLine($"Min = {minnumber}, Max = {maxnumber}");

