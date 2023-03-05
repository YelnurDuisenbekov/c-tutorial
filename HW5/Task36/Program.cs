void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
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

int size = VvodimoeChislo("Введите число ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sum = 0;
for (int z = 0; z < numbers.Length; z+=2)
{
    sum = sum + numbers[z];
}
    Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");

