// Задача 8: Напишите программу, которая на вход 
// принимает число (N), а на выходе показывает все 
// чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Insert number : ");
int n = Convert.ToInt32(Console.ReadLine());

if(n==0){
    Console.Write(n);
}

else if(n>0){

    for(int i =1; i<=n; i++){
        if(i%2 ==0){
            Console.Write(i +" ");
        }
    }
}
else{
    for(int i =-1; i>=n; i--){
        if(i%2 ==0){
            Console.Write(i +" ");
        }
    }
}
