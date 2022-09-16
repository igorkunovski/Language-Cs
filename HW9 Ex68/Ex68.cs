// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// A(2, 1) = 5
// A(2, 2) = 7

// A(n+1)          m=0
// A(m-1,1)        (m>0,n=0) 
// A(m-1,A(m,n-1)) (m>0,n>0) 


Console.Write("Insert int number m:  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Insert int number n:  ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Akerman(m,n));

int Akerman (int m, int n){
    if(m==0) return n+1;
    else if(m>0 && n==0) return Akerman(m-1,1);
    else if (m>0 && n>0) return Akerman(m-1,Akerman(m, n-1));
    else return 0;
}
