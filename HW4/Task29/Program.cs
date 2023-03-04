void FillArray(int [] array)
{
    int lenght = array.Length;
    for (int i =0; i<lenght; i++)
    {
array[i]=new Random().Next(0,2);
    }
}
void PrintArray(int [] array)
{
    int lenght = array.Length;
    for (int i =0; i<lenght; i++)
    {
        Console.Write($" {array[i]}");
    }
}
int[] array = new int [10];
FillArray(array);
PrintArray(array);

