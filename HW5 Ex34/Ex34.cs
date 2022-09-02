// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

try{
    Console.Write("Insert massive length : ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] randArr = FillArray(n);
    PrintArray(randArr);
    Console.WriteLine("Positive numbers in array: " + Positive_numbers(randArr));
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
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int Positive_numbers(int[] arr){
    int pos_count = 0;

    foreach (int num in arr)
    {
        if (num%2 == 0)
        {
            pos_count++;
        }
    }
    return pos_count;
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