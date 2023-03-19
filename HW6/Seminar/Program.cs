int[] array = new int[] { 164, 3, 3,315,315, 3, 3 };
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(array); 

// int[] GetArray (int size, int minVal, int maxVal)
// {
//     int [] res = new int [size];
//     for (int i=0; i<size; i++)
// {
//     res [i] = new Random().Next(minVal,maxVal);
// }
// return res;
// }
// void PrintArray(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine();
// }
// int VvodimoeChislo(string msg)
// {
//     Console.Write(msg);
//     string number = Console.ReadLine()!;
//     int VvodimoeChislo = Convert.ToInt32(number);
//     return VvodimoeChislo;
// }
// int[] ReverseArray2(int[] array)
// {
//     int [] res =new int [array.Length];
//     for (int i=0; i<array.Length; i++)
//     {
//         int s = array.Length;
//         res[i]=array[s-1-i];
//     }
//     return res;
// }
int [] CloneArray(int [] array)
{
    int size = array.Length;
    int [] cloneArray = new int [size];
    for (int i=0; i<size; i++)
    {
        cloneArray[i]=array[i];
    }
    return cloneArray;
}
// int size = VvodimoeChislo("Введите размер массива ");
// int minval = VvodimoeChislo("Введите мин значение ");
// int maxval = VvodimoeChislo("Введите макс значение ");
// int[] array = GetArray(size, minval, maxval);
// PrintArray(array); 
// int [] cloneArray = CloneArray(array);
// Console.Write("Клон массива:");
// Console.WriteLine(" ");
// PrintArray(cloneArray); // Console.WriteLine(string.Join(" ", reverseArray));







// Задача 44
// int VvodimoeChislo(string msg)
// {
//     Console.Write(msg);
//     string number = Console.ReadLine()!;
//     int VvodimoeChislo = Convert.ToInt32(number);
//     return VvodimoeChislo;
// }
// void FillArrayFibonachi(int[] numbers)
// {
//     for (int i = 3; i < numbers.Length; i++)
//     {
//         numbers[0]=0;
//         numbers[1]=1;
//         numbers[2]=1;
//         numbers[i] = numbers[i-1]+ numbers[i-2];
//     }
// }
// void PrintArray(int [] array)
// {
//     for (int i =0; i<array.Length; i++)
//     {
//         Console.Write($" {array[i]} ");
//     }
// }

// int size = VvodimoeChislo("Введите размер массива ");
// int[] numbers = new int[size];
// FillArrayFibonachi(numbers);
// PrintArray(numbers);

// Зачада 42
// int VvodimoeChislo(string msg)
// {
//     Console.Write(msg);
//     string number = Console.ReadLine()!;
//     int VvodimoeChislo = Convert.ToInt32(number);
//     return VvodimoeChislo;
// }
// int number = VvodimoeChislo("Введите чсило ");
// void DvoichniKod(int number)
// {
//     int a= 0;
//     string b ="";
//     for (int i = 0; number > 0; i++)
//     {
//         a = number % 2;
//         b= a+b;
//         number = number / 2;
//     }
//     Console.Write(b);
// }
// DvoichniKod(number);


// Задача 40
// int VvodimoeChislo(string msg)
// {
//     Console.Write(msg);
//     string number = Console.ReadLine()!;
//     int VvodimoeChislo = Convert.ToInt32(number);
//     return VvodimoeChislo;
// }
// int storona1 = VvodimoeChislo("Введите размер первой стороны ");
// int storona2 = VvodimoeChislo("Введите размер второй сторон ");
// int storona3 = VvodimoeChislo("Введите размер третьей сторон ");
// void ProverkaRealnosti (int storona1, int storona2, int storona3)
// {
// if (storona1<(storona2+storona3) && storona2<(storona1+storona3) && storona3<(storona2+storona1))
// {
//     Console.Write("Реальный Треугольник");
// }
// else 
// {
//     Console.Write("Не Реальный Треугольник");
// }
// }
// ProverkaRealnosti(storona1,storona2,storona3);




// void FillArrayRandomNumbers(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(1, 10);
//     }
// }
// int[] GetArray (int size, int minVal, int maxVal)
// {
//     int [] res = new int [size];
//     for (int i=0; i<size; i++)
// {
//     res [i] = new Random().Next(minVal,maxVal);
// }
// return res;
// }
// void PrintArray(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine();
// }
// int VvodimoeChislo(string msg)
// {
//     Console.Write(msg);
//     string number = Console.ReadLine()!;
//     int VvodimoeChislo = Convert.ToInt32(number);
//     return VvodimoeChislo;
// }
// void ReverseArray1(int[] array)
// {
//     for(int i=0; i<array.Length/2; i++)
//     {
//         int s = array.Length;
//         int k = array[i];
//         array[i]=array[s-1-i];
//         array[s-1-i]=k;
//     }
// }
// int[] ReverseArray2(int[] array)
// {
//     int [] res =new int [array.Length];
//     for (int i=0; i<array.Length; i++)
//     {
//         int s = array.Length;
//         res[i]=array[s-1-i];
//     }
//     return res;
// }
// int size = VvodimoeChislo("Введите размер массива ");
// int minval = VvodimoeChislo("Введите мин значение ");
// int maxval = VvodimoeChislo("Введите макс значение ");
// int[] array = GetArray(size, minval, maxval);
// PrintArray(array); 
// // ReverseArray1(array);
// int [] reverseArray = ReverseArray2(array);
// Console.Write("Развернутый массив:");
// Console.WriteLine(" ");
// PrintArray(reverseArray); // Console.WriteLine(string.Join(" ", reverseArray));
