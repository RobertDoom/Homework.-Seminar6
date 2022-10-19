// Задача №41. Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("Введите количество чисел: ");
int number = int.Parse(Console.ReadLine()!);
int[] array = CreateArray(number);
FillArray(array, number);
Console.WriteLine($"Количество чисел больше 0: {NumberPositive(array)}");

int[] CreateArray(int num)
{
    int[] arr = new int[num];
    return arr;
}

int[] FillArray(int[] array, int number, int i = 0)
{
    if (i < number)
    {
        array[i] = int.Parse(Console.ReadLine()!);
        i++;
        FillArray(array, number, i);
    }
    return array;
}

int NumberPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}