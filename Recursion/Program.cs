// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M и N.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void ShowNumbers (int M, int N)
{
    if ( M == N)
    {
        Console.Write(M);
        return;
    }
    Console.Write(M + " ");
    ShowNumbers(M+1, N);
} 
ShowNumbers(M+1, N-1);

// Задайте произвольный массив. Выведете его элементы, начиная с конца. 

// Напишите программу, которая перевернет одномерный массив (первый элемент станет последним и тд.)

// int [] CreateArray (int size)
// {
//     int [] array = new int [size];
//     for (int i=0; i< array.Length; i++)
//     {
//         array[i] = new Random().Next(0,10);
//     }
//     return array;
// }

// void InvertedArray (int [] arr, int count)
// {
//     if (count == arr.Length)
//     {
//         return;
//     }
//     Console.Write(arr[arr.Length-1-count]);
//     InvertedArray(arr, count+1);
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] res = CreateArray(N);
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// Console.WriteLine("Result: ");
// InvertedArray (res, 0);

// Напишите программу вычисления функции Аккермана
//с помощью рекурсии. Даны два неотрицательных числа m и n
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int CalculationFunctionOfAkkerman (int n, int m)
// {
//     if (n == 0)
//     {
//        return m+1; 
//     } 
//     else if (m == 0)
//     {
//         return CalculationFunctionOfAkkerman(n-1,1);
//     }
//     else
//     {
//         return CalculationFunctionOfAkkerman(n-1, CalculationFunctionOfAkkerman(n,m-1));
//     }
// }

// Console.Write($"Вычисление функции Аккермана: {CalculationFunctionOfAkkerman(n,m)} ");