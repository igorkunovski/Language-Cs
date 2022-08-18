// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


        Console.Write("Insert number 1 : ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insert number 2 : ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insert number 3 : ");
        int z = Convert.ToInt32(Console.ReadLine());

        
        if (x>=y && x>=z) {           
                Console.WriteLine("-> " +x);
        }
        else if (y>=x && y>=z)  { 
                Console.WriteLine("-> " +y);
            }
        
        else if (z>=x && z>=y)  { 
                Console.WriteLine("-> " +z);
            }
        else{
           
            Console.WriteLine("Numbers are equal");
        }
    

  