Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
int i;
for (i = 1; i <= x; i++)
{
    double a = Math.Pow(i,3);
    Console.WriteLine(a);
}