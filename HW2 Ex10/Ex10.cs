// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Insert number : ");
string number = Console.ReadLine();


Console.WriteLine(SecondNumber(number));

string SecondNumber(string num)
{

    if (number.Length == 3)
    {
        return number.Substring(1,1);
    }
    else
    {
        return ("incorrect number! number must be 3 digits");
    }
}
