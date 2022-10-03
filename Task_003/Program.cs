/*
Задача 45: Напишите программу, 
которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];

int[] GetRandomArray (int size, int min, int max) {
    int[] random = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        random[i] = new Random().Next(min, max);
    }
    return random;
}
array = GetRandomArray(size, 1, 10);
Console.WriteLine("[" + String.Join(",", array) + "]");
int[] GetCloneArray(int[] array)
{
    int[] clone = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    { 
        clone[i] = array[i];
    }
    return clone;
}
int[] cloneArray = new int[array.Length];
cloneArray = GetCloneArray(array);
Console.WriteLine("[" + String.Join(",", cloneArray) + "]");
/*
Console.WriteLine("\nВведите размер массива: ");
int arr_size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[arr_size];
int[] arr_copy = new int[arr_size];

Random rnd = new Random();
for (int i = 0; i < arr_size; i++)
{
    arr[i] = rnd.Next(1, 99);
}

for (int i = 0; i < arr_size; i++)
{
    arr_copy[i] = arr[i];
}

Console.WriteLine(" " + String.Join(", ", arr_copy));
*/