// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Insert int number of rows x:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert int number of columns y:  ");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert int number of height z:  ");
int height = Convert.ToInt32(Console.ReadLine());

int[] usedNumbers = new int[100];
int counter = 0;

int[,,] cube = new int[row, column, height];

int[,,] filledArr = FillThreeDimIntArray(cube);
PrintThreeDimArray(filledArr);
// PrintOneDimArray(usedNumbers);

int[,,] FillThreeDimIntArray(int[,,] array)
{
    int[,,] arr = new int[array.GetLength(0), array.GetLength(1), array.GetLength(2)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                arr[i, j, k] = findNumber(usedNumbers);
            }
        }
    }
    return arr;
}

void PrintThreeDimArray(int[,,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int k = 0; k < table.GetLength(2); k++)
            {
                Console.Write(table[i, j, k] + " (" + i + ", " + j + ", " + k + ") " + "\t");
            }
            Console.WriteLine();
        }
    }
}

int findNumber(int[] arr)
{
    int result = new Random().Next(10, 100);

    if (!ifInArray(usedNumbers, result) && counter < usedNumbers.Length)
    {
        usedNumbers[counter] = result;
        counter++;
        return result;
    }
    else
    {
        return findNumber(usedNumbers);
    }
}

bool ifInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

void PrintOneDimArray(int[] array)
{
    string arrNum = string.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            arrNum += array[i] + ", ";
        }
        else
        {
            arrNum += array[i];
        }
    }
    Console.WriteLine("[" + arrNum + "]");
}