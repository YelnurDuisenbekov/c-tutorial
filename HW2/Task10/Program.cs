Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number>1000 || number<100)
{
    Console.Write("Надо ввести только 3ех значное: ");
}
else
{
int a = number/100;
int b = (number - a*100)/10;
Console.WriteLine(b);
}