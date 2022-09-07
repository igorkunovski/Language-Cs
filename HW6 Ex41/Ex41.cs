// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

try{
    Console.WriteLine(Numbers());
}
catch (System.FormatException)
{
Console.WriteLine("Please check number!");
}

string Numbers(){

string numbers = string.Empty;
string num = string.Empty;
int counter = 0;

do
{
    Console.Write("Insert int number:  ");
    num = Console.ReadLine();
    if(num != string.Empty)
    {
        int check = Convert.ToInt32(num);
        if(check > 0)
        {
            counter++;       
            numbers= numbers + num + ", ";
            continue;
        }
        else
        {
            numbers= numbers + num + ", ";
            continue;
        }
    }
    else
    {
        return numbers + " Positive numbers --> " + counter;
    } 
} while (true);

}
