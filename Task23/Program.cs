//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N

using static System.Console;
//Clear();

WriteLine("Введите число N");
int.TryParse(ReadLine(), out int N);
int i = 1;
//Write(N*N*N);
//Write($"{MathF.Pow(N, 3)} ");
while (i <= N)
{
    Write($"{MathF.Pow(i, 3)} ");
    i++;
}