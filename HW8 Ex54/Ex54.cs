// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Insert int number of rows m:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert int number of columns n:  ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, column];
matrix = FillArrayInt(matrix);

PrintArray(matrix);
Console.WriteLine("Matrix with sorted Rows");
PrintArray(arrayWithSortedRows(matrix));

int[,] FillArrayInt(int[,] array)
{
    {
        int[,] arr = new int[array.GetLength(0), array.GetLength(1)];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(1, 10);
            }
        }
        return arr;
    }
}

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] arrayWithSortedRows(int[,] array)
{
    int temp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosColumn = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] < array[i, minPosColumn])
                {
                    minPosColumn = k;
                }
            }
            temp = array[i, j];
            array[i, j] = array[i, minPosColumn];
            array[i, minPosColumn] = temp;
        }
    }
    return array;
}
