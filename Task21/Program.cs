/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
sqrt (x_2-x_1)^2+(y_2-y_1)^2+(z_2-z_1)^2*/

Console.WriteLine("Введите значение x точки А: ");
int Ax = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение y точки A: ");
int Ay = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение z точки А: ");
int Az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение x точки B: ");
int Bx = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение y точки B: ");
int By = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение z точки B: ");
int Bz = int.Parse(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
Console.WriteLine(Math.Round(res, 2));

