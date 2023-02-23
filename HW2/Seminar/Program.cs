
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n%5==0 && n%3==0)
{
    Console.WriteLine("FizzBizz");
}
else 
{
if (n%3==0)
{
    Console.WriteLine("Fizz");
}
if (n%5==0)
{
    Console.WriteLine("Bizz");
}
}


// Задача 5 квадрат друг друга
// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine()!);
// if (number2*number2==number1 || number1*number1==number2)
// {
//     Console.WriteLine("квадрат");
// }
// else
// {
//     Console.WriteLine("не квадрат");
// }


//Задача 4 кратно ли на 7 и 23
// Console.Write("Введите число: ");
// int number1 = int.Parse(Console.ReadLine()!);
// if (number1%7==0 && number1%23==0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine("не кратно");
// }


// Задача 3 2 ввод, проверка кратности
// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int number2 = int.Parse(Console.ReadLine()!);
// if (number2%number1==0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine("не кратно");
//     int a = number2%number1;
//     Console.WriteLine(a);
// }

// Задача 2 3ех значное и минус второе
// int number = new Random().Next(100,1000);
// Console.WriteLine(number);
// int a = number/100;
// int b = (number - a*100)/10;
// int c = number%10;
// int d = a*10+c;
// Console.WriteLine(d);


// Задача 1 наибольая цифра среди 10-99
//                  включительно, не включительно
// int number = new Random().Next(10,100);
// Console.WriteLine(number);
// int a = number/10;
// int b = number%10;
// if (a>b)
// {
//     Console.WriteLine(a);
// }
// else 
// {
//     Console.WriteLine(b);
// }