/*
Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

Console.Clear();
int[] array = FillArray(5, 1, 10);

Console.WriteLine("Входной массив:" + "[ " + String.Join(",", array) + " ]");

Console.WriteLine("1 Способ: Перевёрнутый массив: " + "[ " + String.Join(",", ReverseArray(array)) + " ]");
Console.WriteLine("2 Способ: Перевёрнутый массив: " + "[ " + String.Join(",", array.Reverse())+ " ]");


int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

int[] ReverseArray(int[] inputArray)
{
    int[] reverseArray = new int[inputArray.Length];

    for (int i = inputArray.Length - 1; i >= 0; i--)
    {
        reverseArray[inputArray.Length - 1 - i] = inputArray[i];
    }

    return reverseArray;
}
