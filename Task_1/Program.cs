/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

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
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

bool ParityCheck(int number)
{
if (number % 2 == 0)
    {
        return true;
    }
    return false;
}

Console.Clear();
int num = ReadInt("Введите количество элементов массива");
int[] array = GetBinArray(num);
int counter = 0;

for (int i=0; i < num ; i++)
{
    if (ParityCheck(array[i])) counter++;
}
Console.Write($"   [");
for (int i = 0; i < num ; i++)
{
    Console.Write($"{array[i]}, ");
}

Console.Write($"]   ");
Console.WriteLine($"Количество четных элементов равно {counter}");