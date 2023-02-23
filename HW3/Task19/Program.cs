Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
int firstnum = x/10000;
int secondnum = x/1000%10;
int thirdnum = x/100%10;
int fouthnum = x/10%10;
int fifthnum = x%10;
// Console.WriteLine(firstnum);
// Console.WriteLine(secondnum);
// Console.WriteLine(thirdnum);
// Console.WriteLine(fouthnum);
// Console.WriteLine(fifthnum);
if (x<100000 && x>9999)
{
    if (firstnum==fifthnum && secondnum==fouthnum)
{
Console.WriteLine("Da");
}
else 
{
Console.WriteLine("Net");
}
}
else 
{
Console.WriteLine("Vvedite 5 znachnoe chislo");
}