// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

    int Summa()
    {
        Console.Write("Insert positive int number : ");
        string numbers = Console.ReadLine();

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {            
            sum +=  int.Parse(numbers[i].ToString());
        }
        return sum;
    }

    try{
        Console.WriteLine("Total summa of all numbers is: " + Summa());
        }
        catch {
            Console.WriteLine("Incorrect int number!");
        }
        