//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

using static System.Console;

WriteLine("Введите координату x точки А");
int.TryParse(ReadLine(), out int xa);
WriteLine("Введите координату y точки А");
int.TryParse(ReadLine(), out int ya);
WriteLine("Введите координату zx точки А");
int.TryParse(ReadLine(), out int za);

WriteLine("Введите координату x точки В");
int.TryParse(ReadLine(), out int xb);
WriteLine("Введите координату y точки В");
int.TryParse(ReadLine(), out int yb);
WriteLine("Введите координату zx точки В");
int.TryParse(ReadLine(), out int zb);

double length_z = Math.Sqrt(Math.Pow((xa-xb), 2) + Math.Pow((ya-yb), 2));
double length = Math.Sqrt(Math.Pow(length_z, 2) + Math.Pow((za-zb), 2));

WriteLine($"{length:f2}");