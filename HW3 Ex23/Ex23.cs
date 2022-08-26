// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

try{
    ConvToCube();
}
catch
{
    Console.WriteLine("Must be int number ");
}

void ConvToCube(){

Console.WriteLine("Enter int number! ");
int n = Convert.ToInt32(Console.ReadLine());

if(n==0) Console.Write("0");

if(n<0){
    for(int i = 1; i>=n; i--)
    {
    Console.Write(Math.Pow(i,3) + ", ");
    }
}

for(int i = 1; i<=n; i++)
    {
    Console.Write(Math.Pow(i,3) + ", ");
    }
}
