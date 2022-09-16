// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18(2*3 + 4*3)    20(2*4 + 4*3)
// 15(3*3 + 2*3)    18(3*4 + 2*3)



Console.Write("Insert int number of rows for matrix 1:  ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert int number of columns for matrix 1:  ");
int column1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert int number of rows for matrix 2:  ");
int row2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert int number of columns for matrix 2:  ");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[row1, column1];
matrix1 = FillArrayInt(matrix1);
Console.WriteLine("MATRIX 1");
PrintTwoDimArray(matrix1);

Console.WriteLine();

int[,] matrix2 = new int[row2, column2];
matrix2 = FillArrayInt(matrix2);
Console.WriteLine("MATRIX 2");
PrintTwoDimArray(matrix2);

Console.WriteLine();
Console.WriteLine("Result");

if (ifMultiplicabable(column1, row2))
{
    int[,] resultMatrix = ResultMatrix(matrix1, matrix2);
    PrintTwoDimArray(resultMatrix);
}
else
{
    Console.WriteLine("Matrix are not multilicable!");
}


bool ifMultiplicabable(int columnsMatrix1, int RowsMatrix2)
{
    return columnsMatrix1 == RowsMatrix2;
}

int[,] ResultMatrix(int[,] matr1, int[,] matr2)
{
    int[,] resultArr = new int[matr1.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                resultArr[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultArr;
}

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
