Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);
if (number>7 || number<1)
{
    Console.Write("Надо ввести от 1 до 7 ");
}
else
{
    if (number==6 || number==7)
    {
        Console.Write("Выходной ");
    }
    else
    {
    Console.Write("He Выходной ");
    }
}