// Задача 25: Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Degree (){
    
    Console.WriteLine("Enter int number! ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter degree int number! ");
    int degree = Convert.ToInt32(Console.ReadLine());

    return Math.Pow(number, degree);
}

try{
    Console.WriteLine(Degree());
}
catch {
    Console.WriteLine("Incorrect number!");
}