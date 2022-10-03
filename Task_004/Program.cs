/*
Решение в группах задач:
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 1011013  -> 112  -> 10


Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
string binary = String.Empty;
string GetBinary(int x)
{
    string one = String.Empty;
    while (x > 0)
    {
        one = x % 2 + one; // так реализован разворот массива
        x = x / 2;
    }
    return one;
}
binary = GetBinary(x);
Console.WriteLine(binary);

/*
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"В двоичной системе: {ConvertTo2(num)}");

string ConvertTo2(int num_local)
{
    string s = "";
    while (num_local > 0)
    {
        s = ((num_local % 2 == 0) ? "0" : "1") + s;
        num_local /= 2;
    }
    if (s == "") s = "0";
    return s;
}
*/