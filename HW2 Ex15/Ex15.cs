// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Insert number : ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DayOff(number));

string DayOff(int num){

    if (num==6 || num ==7){
        return "YES!Day Off";
    }
    else if (num >0 && num < 6){
        return "NO! Woking day!";
    }
    else{
        return "Incorrect day of the week!";
    }
}
