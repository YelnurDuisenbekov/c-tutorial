int VvodimoeChislo(string msg)
{
    Console.Write(msg);
    string number = Console.ReadLine()!;
    int VvodimoeChislo=Convert.ToInt32(number);
    return VvodimoeChislo;
}
int VozvedenieNaChslo(int number1, int number2)
{
    int sum=1;
    for (int i =0; i<number2; i++)
    {
        sum=sum*number1;
    }
    return sum;
}
int number1 = VvodimoeChislo("Введите число ");
int number2 = VvodimoeChislo("Введите число возведения ");
Console.WriteLine($"Возведение = { VozvedenieNaChslo(number1,number2)}");
