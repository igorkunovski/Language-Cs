// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Insert number : ");
string number = Console.ReadLine();


Console.WriteLine(SecondNumber(number));

string SecondNumber(string num)
{

    if (number.Length >= 3)
    {
        return number.Substring(2, 1);
    }
    else
    {
        return (number + " not 3 digit");
    }
}
