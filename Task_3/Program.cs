/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

Console.Clear();
double[] startArray = GetArray(10);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Разница = {GetDifference(startArray)}");

double[] GetArray(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() + new Random().Next(-100, 100); 
        res[i] = Math.Round(res[i],2, MidpointRounding.ToEven);
    }
    return res;
}

double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    Console.WriteLine($" максимальное  {max}, минимальное {min}");
    return max - min;
}