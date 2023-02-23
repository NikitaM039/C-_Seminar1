int[] arr = new int[8];
Random rnd = new Random();
System.Console.Write("Введите минимальное число массива: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное число массива: ");
int B = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(A, B+1);
}
Console.WriteLine('[' + string.Join(", ", arr) + ']');