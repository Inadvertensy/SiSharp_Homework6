// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void TwolinesCrossing(){
    
Console.WriteLine($"Enter b1:\t");
double b1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Enter k1:\t");
double k1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Enter b2:\t");
double b2=Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Enter k2:\t");
double k2=Convert.ToDouble(Console.ReadLine());

double pX=(b2-b1)/(k1-k2);
double pY=k1*((b2-b1)/(k1-k2))+b1;

Console.WriteLine($"Coordinates of two line crossing are ({pX:f3};{pY:f3})");
}
TwolinesCrossing();