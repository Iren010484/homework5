/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

int[] GetBinArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

Console.Clear();
int num = ReadInt("Введите количество элементов массива");
int[] array = GetBinArray(num);
int sumelem = 0;

for (int i=1; i < num ; i += 2)
{
    sumelem = sumelem + (array[i]);
}
Console.Write($"   [");
for (int i = 0; i < num ; i++)
{
    Console.Write($"{array[i]}, ");
}

Console.Write($"]   ");
Console.WriteLine($"Сумма элементов на нечетных местах равна {sumelem}");
