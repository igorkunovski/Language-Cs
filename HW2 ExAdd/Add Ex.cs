﻿// задача необязательная.
// "В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали 
// для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в 
// консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек."
// 1 программист, 2-4 программиста, 5-20 программистов.

Console.Write("Insert number : ");
int number = Convert.ToInt32(Console.ReadLine());

string Programmers(int num)
{
    if (num < 0) {
        return "Incorrect number. Must be positive";
    }
    if (num == 1 || num % 10 == 1 && num > 20 ){
        return num + " programmiST";
    }
    else if (num % 10 > 1 && num % 10 < 5 && num < 5 || num % 10 > 1 && num % 10 < 5 && num > 21){
        return num + " programiSTA";
    }
    else {
        return num + " programmiSTOV";
    }
}
// ДЛЯ проверки
for (int i = 0; i <= number; i++)   
{
    Console.WriteLine(Programmers(i));
}
