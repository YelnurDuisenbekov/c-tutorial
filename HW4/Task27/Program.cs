  int VvodimoeChislo(string msg)
{
    Console.Write(msg);
    string number = Console.ReadLine()!;
    int VvodimoeChislo=Convert.ToInt32(number);
    return VvodimoeChislo;
}
  int SumNumber(int number) //12345
  {
    int Length = Convert.ToString(number).Length; //5
    int a = 0;
    int sum = 0;

    for (int i = 0; i < Length; i++)
    {
      a = number - number % 10; //12340             /1230           /120            /10             
      sum = sum + (number - a); //0+12345-12340=5   /5+1234-1230=9  /9+123-120=12   /12+12-10=14
      number = number / 10; //1234                  /123            /12             /1
    }
   return sum;
  }
    int number = VvodimoeChislo("Введите число ");
    Console.WriteLine($"Сумма = { SumNumber(number)}");