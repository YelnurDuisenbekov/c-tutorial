void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
int VvodimoeChislo(string msg)
{
    Console.Write(msg);
    string number = Console.ReadLine()!;
    int VvodimoeChislo = Convert.ToInt32(number);
    return VvodimoeChislo;
}

int size = VvodimoeChislo("Введите размер массива ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"{count} чётных");

