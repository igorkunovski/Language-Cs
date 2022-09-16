// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Insert int number of START m:  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert int number of FINNISH n:  ");
int n = Convert.ToInt32(Console.ReadLine());

if (m == n) {
    Console.WriteLine(0);
}
else if (m>n) 
{
    int temp = m;
    m = n;
    n=temp;
    Console.WriteLine(NumbersSum(m,n));
}
else
{
    Console.WriteLine(NumbersSum(m,n));
}

int NumbersSum(int start, int finnish)
{
    int result = 0;
    if (start == n) return n;
    return result += start  + NumbersSum(start + 1, finnish);
}
