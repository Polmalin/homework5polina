// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int [] InitArray ()
{
    int[] result = new int[12];
    Random rnd = new Random ();
    for (int i = 0; i < result.Length; i++)
    {
        result [i] = rnd.Next (-9,10);
    }
    return result;
}

void PrintArray (int [] array)
{
    Console.WriteLine(string.Join(',', array));
    Console.WriteLine();
}



int getSumOfUneven (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i=i+2)
    {
        sum=sum+array[i];
    }
    return sum;
}

int [] arr = InitArray();
PrintArray (arr);
int UnevenSum = getSumOfUneven (arr);
Console.WriteLine($"Сумма элементов на нечетных позициях = {UnevenSum}");