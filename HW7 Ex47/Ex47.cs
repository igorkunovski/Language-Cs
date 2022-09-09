// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Insert int number of rows m:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert int number of columns n:  ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[row,column];
matrix = FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);


double[,] FillArray(double[,] array){
    {
    double[,] arr = new double[array.GetLength(0), array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           arr[i,j] = Math.Round(new Random().NextDouble()*10, 1);
        }      
    }
    return arr;
    }
}

void PrintArray(double[,] table)
    {
    for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i,j] + "\t" );
                }
            Console.WriteLine();
        }
    }
    