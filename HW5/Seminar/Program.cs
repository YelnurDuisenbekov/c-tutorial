int[] FillArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
        for (int i =0; i<size; i++)
    {
        array[i]=new Random().Next(minVal,maxVal+1);
    }
    return array;
}
void PrintArray(int [] array)
{
    for (int i =0; i<array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}

int[] GetPos(int[] array)
{
    int [] count = new int [array.Length/2];
for (int i=0; i<array.Length/2; i++)
{
    count[i]=array[i]*array[array.Length-i-1];
}
return count;
}



int[] array= FillArray(5, 0, 5);
PrintArray(array);
Console.WriteLine();
int[] res = GetPos(array);
PrintArray(res);

// // int number = VvodimoeChislo("Введите число ");
// int count =0;
// for (int i=0; i<array.Length;i++)
// {
//     if (array[i]>10 && array[i]<100)
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);








// // int sumP =0;
// // int sumN=0;
// // foreach(int el in array)
// int count =0;
// for (int i=0; i<array.Length;i++ )
// {
//     if (array[i]==number)
//     {
//         count++;
//     }
// }
// if (count>0)
//     {
//         Console.WriteLine("Da");
//     }
//     else
//     {
//         Console.WriteLine("Net");
//     }
// Console.WriteLine();
// // Console.WriteLine($"Сумма негативных чисел {-sumN} ");
// // Console.WriteLine($"Сумма позитивных чисел {sumP} ");
