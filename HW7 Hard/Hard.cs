// Задача HARD SORT Задайте двумерный массив из целых чисел. 
// Отсортировать элементы по возрастанию слева направо и снизу вверх.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.WriteLine("Insert int number of rows m:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert int number of columns n:  ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row, column];
matrix = FillArrayInt(matrix);

PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Sorted 2-dim array:");

// Console.WriteLine(string.Join("; ", TwoDimArrayToOneDim(matrix)));
int[] oneDimSorted = SortOneDimArray(TwoDimArrayToOneDim(matrix));
// Console.WriteLine(string.Join("; ", oneDimSorted));

PrintArray(OneDimArrayToTwoDim(oneDimSorted));

int[,] FillArrayInt(int[,] array)
{
    {
        int[,] arr = new int[array.GetLength(0), array.GetLength(1)];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(1, 100);
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

int[] TwoDimArrayToOneDim(int[,] table)
{
    int[] oneDimArr = new int[table.GetLength(0) * table.GetLength(1)];

    int counter = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            oneDimArr[counter] = table[i, j];
            counter++;
        }
    }
    return oneDimArr;
}

int[,] OneDimArrayToTwoDim(int[] oneDimArr)
{
    int[,] twoDimArr = new int[row, column];

    int counter = 0;
    for (int i = 0; i < twoDimArr.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimArr.GetLength(1); j++)
        {
            twoDimArr[i, j] = oneDimArr[counter];
            counter++;
        }
    }
    return twoDimArr;
}

int[] SortOneDimArray(int[] array)
{

    int temp = 0;

    for (int i = 0; i < array.Length - 1; i++)
    {
        int min_pos = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min_pos])
            {
                min_pos = j;
            }
        }
        temp = array[i];
        array[i] = array[min_pos];
        array[min_pos] = temp;

    }
    return array;
}
