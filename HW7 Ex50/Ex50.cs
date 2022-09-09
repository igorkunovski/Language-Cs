// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Insert int number of rows m:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert int number of columns n:  ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row,column];
matrix = FillArrayInt(matrix);

PrintArray(matrix);

Console.WriteLine(IfNumInArray(matrix));

int[,] FillArrayInt(int[,] array){
    {
    int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           arr[i,j] = new Random().Next(1,100);
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
                    Console.Write(table[i,j] + "\t" );
                }
            Console.WriteLine();
        }
    }

string IfNumInArray (int[,] table)
{
    Console.WriteLine("Please write number to find in array:  ");
    int search = Convert.ToInt32(Console.ReadLine()); 

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i,j]==search) return ("Number " + table[i,j] + " at position [" + i + "," + " " +j+"]");
        }
    }
    return "This number not in this array";
}
