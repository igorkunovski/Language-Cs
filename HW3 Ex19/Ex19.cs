// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Insert 5-digit number  : ");
string numberStr = Console.ReadLine();

try{
   Console.Write(IsPalindrom(numberStr));
}
catch{
    Console.WriteLine("Must be numbers");
}

string IsPalindrom(string numbers){

int numberInt = Convert.ToInt32(numberStr); /* Testing if all are numbers, catching with try catch block*/

if (numberStr.Length == 5){
    if(numberStr[0] == numberStr[numberStr.Length-1] && (numberStr[1] == numberStr[numberStr.Length-2])){
        return "Yes";
    }
    else return "No";
} 
else return "Must be 5 digits number";
}
