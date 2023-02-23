//zadacha kvadrat
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
int i;
for (i = 1; i < x; i++)
{
    double a = Math.Pow(i,2);
    Console.WriteLine(a);
}


// zadacha 21
// Console.Write("Введите x1: ");
// int x1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите y1: ");
// int y1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите x2: ");
// int x2 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите y2: ");
// int y2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)),3));

//zadacha 18
// Console.Write("Введите x: ");
// int x = int.Parse(Console.ReadLine()!);
// if (x == 1)
// {
//     Console.WriteLine("x=(0;+inf.), y=(0;+inf.)");
// }
// else if (x == 2)
// {
//     Console.WriteLine("x=(-inf;0), y=(0;+inf.)");
// }
// else if (x == 3)
// {
//     Console.WriteLine("x=(-inf;0), y=(-inf;0)");
// }
// else if (x == 4)
// {
//     Console.WriteLine("x=(0;+inf.), y=(-inf;0)");
// }
// else
// {
//     Console.WriteLine("only 1 < x < 4");
// }


// Кординаты
// Console.Write("Введите x: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите y: ");
// int y = int.Parse(Console.ReadLine()!);

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1");
// }
// if (x < 0 && y > 0)
// {
//     Console.WriteLine("2");
// }
// if (x < 0 && y < 0)
// {
//     Console.WriteLine("3");
// }
// if (x > 0 && y < 0)
// {
//     Console.WriteLine("4");
// }
