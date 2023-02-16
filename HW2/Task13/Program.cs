Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
string b = Convert.ToString(a);
if (b.Length > 2){
  Console.WriteLine("Третья цифра " + b[2]);
}
else {
  Console.WriteLine("Нет третьей цифры");
}



// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// number/=10;
// int a = number%10;
// if (number>7 || number<1)
// {
//     Console.Write("Надо ввести от 1 до 7 ");
// }
// else
// {
//     if (number==6 || number==7)
//     {
//         Console.Write("Выходной ");
//     }
//     else
//     {
//     Console.Write("He Выходной ");
//     }
// }