/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координату Х точки А: ");
int XAcor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату У точки А: ");
int YAcor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: ");
int ZAcor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B: ");
int XBcor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int YBcor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
int ZBcor = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt((XAcor - XBcor) * (XAcor - XBcor) + (YAcor - YBcor) * (YAcor - YBcor) + (ZAcor - ZBcor) * (ZAcor - ZBcor));
Console.WriteLine("Расстояние между точками А и Б равно " + Math.Round(result, 2));

