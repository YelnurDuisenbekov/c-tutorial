void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000));
        }
}
void PrintArray(double[] numbers)
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
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

double min = 0;
double max = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

