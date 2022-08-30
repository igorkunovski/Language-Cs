// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

try{
Console.Write("Insert massive length : ");
int n = Convert.ToInt32(Console.ReadLine());

PrintArray(FillArray(n));
}
catch (System.FormatException) {
    Console.WriteLine("Must be int number");
}
catch(System.OverflowException){
    Console.WriteLine("Must be positive number, please check!");
}

int[] FillArray(int number)
{
    int[] array = new int[number];
    
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(1, 99);
    }
    return array;
}

void PrintArray(int[] array)
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
    