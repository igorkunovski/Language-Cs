// Задача 6: Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Insert number : ");
int x = Convert.ToInt32(Console.ReadLine());

if(x%2 == 0){
    Console.Write("Yes");
}
else{
  Console.Write("No");  
}
