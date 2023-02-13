//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double [] arr = InitArray();
PrintArray(arr);
double result =  getDifOfMinMax(arr);
Console.WriteLine ($"Разница между максимальным и минимальным элементом массива = {result}");

double [] InitArray()
{
    double [] result = new double[12];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.NextDouble();
    }
    return result;
}
void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double getDifOfMinMax(double[] array)
{
    double max = array [0];
    double min = array [0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array [i] > max)
        {
            max=array [i];
        }
        else if (array [i] < min)
        {
            min=array [i];
        }
    }
    return (max-min);
    
}