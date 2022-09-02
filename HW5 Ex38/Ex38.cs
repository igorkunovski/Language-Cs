// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// Вещественные числа : float, double

try{
    Console.Write("Insert massive length : ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[] randArr = FillArray(n);
    PrintArray(randArr);

    Console.WriteLine("Difference between MIN and MAX: " + Diff(randArr));
}
catch (System.FormatException) {
    Console.WriteLine("Must be int number");
}
catch(System.OverflowException){
    Console.WriteLine("Must be positive number, please check!");
}

double[] FillArray(int number)
{
    double[] array = new double[number];
    
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().NextDouble()*99;
    }
    return array;
}
double Diff(double[] array){
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if(array[i] > max){
            max = array[i];
        }
    }
    Console.WriteLine("MIN = " + min + ", MAX = " + max);
    return max - min;
}

void PrintArray(double[] array)
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
