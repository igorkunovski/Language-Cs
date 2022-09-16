// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Insert int number of rows m:  ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert int number of columns n:  ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rows, column];
int counter = 0;
int row = 0;
int col = 0;
bool left = true;
bool right = true;
bool down = true;
bool up = true;

FillMatrix(row, col);
PrintTwoDimArray(matrix);
Console.WriteLine();

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

void FillMatrix(int row, int col)
{
    matrix[row, col] = ++counter;

    if (right && col + 1 < column && matrix[row, col + 1] == 0)
    {
        down = true;
        FillMatrix(row, col + 1);
    }
    right = false;

    if (down && row + 1 < rows && matrix[row + 1, col] == 0)
    {
        left = true;
        FillMatrix(row + 1, col);
    }
    down = false;

    if (left && col - 1 >= 0 && matrix[row, col - 1] == 0)
    {
        up = true;
        FillMatrix(row, col - 1);
    }
    left = false;

    if (up && row - 1 >= 0 && matrix[row - 1, col] == 0)
    {

        FillMatrix(row - 1, col);
    }
    right = true;

    if (right && col + 1 < column && matrix[row, col + 1] == 0)
    {
        down = true;
        FillMatrix(row, col + 1);
    }
}
