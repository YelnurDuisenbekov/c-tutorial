int[] array = { 2,3,4,6,2,4,7,3,32,4346,7,5,0};

void PrintArray(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArrayMin(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPos = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPos])
            {
                minPos = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

PrintArray(array);
SortArrayMin(array);
PrintArray(array);