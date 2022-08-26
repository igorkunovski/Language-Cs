// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// result = SQRT ((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2))

double Res () 
     {
       Console.WriteLine("Enter int coordinates of point A (X,Y,Z) ");
        int Ax=Convert.ToInt32(Console.ReadLine());
        int Ay=Convert.ToInt32(Console.ReadLine());
        int Az=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter int coordinates of point B (X,Y,Z) ");
        int Bx=Convert.ToInt32(Console.ReadLine());
        int By=Convert.ToInt32(Console.ReadLine());
        int Bz=Convert.ToInt32(Console.ReadLine());
        
        return  (Math.Sqrt(Math.Pow((Ax-Bx),2) + Math.Pow((Ay-By),2) + Math.Pow((Az-Bz),2)));     
     }
try
{
     Console.WriteLine(Res());          
}
catch
{
    Console.WriteLine("Not a numbers. Please check");
}  
