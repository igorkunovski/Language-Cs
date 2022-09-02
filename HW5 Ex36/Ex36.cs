// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

try{
    Console.Write("Insert massive length : ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] randArr = FillArray(n);
    PrintArray(randArr);

    Console.WriteLine("Odd positions summ is: " + Sum_odd_pos(randArr));
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
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int Sum_odd_pos(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {   
        sum+=arr[i]; 
    }
    return sum;
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
