// Задача 19 HARD - необязательная
// Напишите программу, которая принимает на вход любое 
// число и проверяет, является ли оно палиндромом.
// 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99, 101, 111, 121, 131, 141, 151, 161, 171, 181, 191, 202,... 

try{
    Console.Write("Insert number to check : ");
    string number = Console.ReadLine();
    int check = Convert.ToInt32(number);

    Console.WriteLine(Is_Palindrom(number));
}
catch (System.FormatException){
    Console.WriteLine("Not a number!");
}

string Is_Palindrom(string n){
for (int i = 0; i < n.Length / 2; i++)
{
    if(n[i]== n[n.Length - 1 -i])
    {
        continue;
    } 
    else
    {   
        return "NO! The number is not a Palindrom!";
    }
}
return "YES! The number is a Palindrom!";
}
