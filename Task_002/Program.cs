/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.	
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int z = Convert.ToInt32(Console.ReadLine());


if (x + y > z && x + z > y && z + y > x) Console.WriteLine("Да, может существовать треугольник");
else Console.WriteLine("Нет, треугольник существовать не может");

/*
Console.WriteLine("\nВведите сторону a: ");
int side_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nВведите сторону b: ");
int side_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nВведите сторону c: ");
int side_c = Convert.ToInt32(Console.ReadLine());

int max = 0;

max = (side_a >= side_b) ? side_a : 0;
max = (max <= side_c) ? side_c : 0;
string output = (max < (side_a + side_b)) ? "Треугольник существует" : "Треугольник не существует";

Console.WriteLine(output);
*/