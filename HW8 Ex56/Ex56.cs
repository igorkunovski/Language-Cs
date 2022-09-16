// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Insert int number of rows m:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert int number of columns n:  ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, column];
matrix = FillArrayInt(matrix);
PrintTwoDimArray(matrix);
int[] summsArr = ArrayOfRowSums(matrix);

Console.WriteLine(ArraySmallestIntIndex(summsArr) + 1 + " Raw is the smallest in SUM" );
Console.WriteLine();

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


void PrintOneDimArray(int[] array)
{
    string arrNum = string.Empty; 

for (int i = 0; i < array.Length; i++)
{
    if (i<array.Length -1)
    {
        arrNum += array[i] + ", ";
    }
    else{
        arrNum += array[i];
    }
}
Console.WriteLine("[" + arrNum + "]");
}


void PrintTwoDimArray(int[,] table)
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

int[] ArrayOfRowSums(int[,] array)
{   
    int tempSum = 0;
    int[] rowSums = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {  
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }
        rowSums[i] = tempSum;
        tempSum = 0;  
    }
    PrintOneDimArray(rowSums);
    return rowSums;
}


int ArraySmallestIntIndex(int[]arr){
    int minIndex = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[minIndex])
        {
            minIndex = i;
        }
    }   
    return minIndex;
}
