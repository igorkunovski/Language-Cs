// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, 
// причем чтобы каждый гарантированно переместился на другое место 
// (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

Console.WriteLine("Insert int number of rows m:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert int number of columns n:  ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[row,column];

matrix = FillArray(matrix);
Console.WriteLine();
MixArray(matrix);

int[,] FillArray(int[,] array){

    {
    int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write((arr[i,j] = new Random().Next(1, 99)) + " " );
        } 

        Console.WriteLine();      
    }
    return arr;
    }
}

void MixArray(int[,] array)
{ 
    int counter = 0;
    int[,] newArr = new int[array.GetLength(0),array.GetLength(1)];

    while (counter < (array.GetLength(0) * array.GetLength(1)) / 2)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        { 
            for (int j = 0; j<array.GetLength(1); j++)
            {                
                
            // CODE TO SHIFT NUMBERS

            newArr[i,j] = array[i,j];  
            }  
        }
    counter++;
    
    }
    
    for (int i = 0; i < newArr.GetLength(0); i++)
        {
            for (int j = 0; j< newArr.GetLength(1); j++){
                Console.Write(newArr[i,j] + " ");
            }
        Console.WriteLine();
    }
}