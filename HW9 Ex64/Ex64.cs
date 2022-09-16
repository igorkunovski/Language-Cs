// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Insert int number of START m:  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert int number of FINNISH n:  ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < m)
{
    Console.WriteLine("START must be smaller than FINNISH");
}
else
{
    Console.WriteLine(Numbers(m, n));

    string Numbers(int start, int finnish)
    {
        string result = string.Empty;
        if (start == n) return Convert.ToString(n);
        return result += Convert.ToString(start) + ", " + Numbers(start + 1, finnish);
    }
}
