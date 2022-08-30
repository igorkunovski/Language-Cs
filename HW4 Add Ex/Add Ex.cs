// необязательная задача Написать программу сортировки 
// массива от большего к меньшему. Массив задается 
// размерностью N с клавиатуры, далее заполняется случайными целыми числами.

try{
Console.Write("Insert massive length : ");
int n = Convert.ToInt32(Console.ReadLine());

int[] randArr = FillArray(n);
PrintArray(randArr);

int[] sortedArr = arraySort(randArr);
PrintArray(sortedArr);
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

int[] arraySort(int [] array)
{
int temp = 0;

for (int i = 0; i < array.Length-1; i++)
{
    int max_pos = i;

   for (int j = i+1; j < array.Length; j++)
    {
        if (array[j] > array[max_pos])
            {
                max_pos = j;               
            }
    } 
    temp = array[i];           
    array[i] = array[max_pos];
    array[max_pos] = temp;
   
}
return array;
}
