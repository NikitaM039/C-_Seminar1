// Задача 55:Задайте двумерный массив. Напишите программу, которая заменяет строки
// на столбцы.

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(2, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeMatrixRowColumn(int[,] matrixIn)
{
    int[,] newMatrix = new int[matrixIn.GetLength(1), matrixIn.GetLength(0)];

    for (int i = 0; i < matrixIn.GetLength(1); i++)
    {
        for (int j = 0; j < matrixIn.GetLength(0); j++)
        {
            newMatrix[i, j] = matrixIn[j, i];
        }
    }
    return newMatrix;
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
int[,] useMatrix = ChangeMatrixRowColumn(matrix);
System.Console.WriteLine();
PrintMatrix(useMatrix);


// или 

// int[,] ArrayWithRandom(int row, int column)
// {
//     int[,] arr = new int[row, column];

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
//         }

//     }
//     return arr;
// }

// int[] FrequencyDictionary(int[,] matrix)
// {
//     int[] temp = new int[10];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             temp[matrix[i, j]]++;
//         }
//     }
//     return temp;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите кол-во строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = ArrayWithRandom(row, column);
// PrintMatrix(matrix);
// Console.WriteLine();
// int[] indexArray = FrequencyDictionary(matrix);
// for (int i = 0; i < indexArray.Length; i++)
// {
//     if (indexArray[i] != 0) // != - неравно // == - равно
//     {
//         Console.WriteLine($"Число {i} встретилось {indexArray[i]} раз");
//     }
// }