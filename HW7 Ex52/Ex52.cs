// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Insert int number of rows m:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert int number of columns n:  ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, column];
matrix = FillArrayInt(matrix);

PrintArray(matrix);

Console.WriteLine("Every column arithmetic SUMs are : " + string.Join("; ", ColumnArithmetic(matrix)));

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

double[] ColumnArithmetic(int[,] array)
{   
    double[] result = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j] += array[i, j];
        }
    }
    for (int k = 0; k < result.Length; k++)
    {
        result[k] = Math.Round(result[k] / array.GetLength(0), 2);
    }
    return result;
}
