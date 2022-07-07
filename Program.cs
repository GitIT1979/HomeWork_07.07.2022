// 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 10.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int[,] GetIntArray()
// {
//     int[,] result = new int[3, 10];
//     for (int i = 0; i < 3; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//             result[i, j] = new Random().Next();
//         }
//     }
//     return result;
// }


// double[,] GetDoubleArray()
// {
//     double[,] result = new double[3, 10];
//     for (int i = 0; i < 3; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//             result[i, j] = new Random().NextDouble();
//         }
//     }
//     return result;
// }

// double[,] GetArray(int [,] array, double[,] array2)
//     {
//         double[,] result = new double[3, 10];
//         int[,] array1 = new int[3, 10];
//         for (int i = 0; i < 3; i++)
//         {
//             for (int j = 0; j < 10; j++)
//             {
//             // создание элемента псевдо-Bool массива
//             array1[i, j] = new Random().Next(0, 2);
//             // проверка на false и true для включение в массив отрицательных чисел 
//             if (array1[i,j] == 1) 
//             // создание всех возможных для Int32 C# вещественных чисел 
//             result[i,j] =  array[i,j] + array2[i,j];
//             else result[i,j] =  -1 * array[i,j] - array2[i,j];
//             }
//         }
//         return result;
//     }

// void PrintArray (double[,] array)   
//  {
//     for (int i = 0; i < 3; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//         Console.Write($"{array[i, j]} ");
//         }    
//     Console.WriteLine();
//     }
// }   

// Console.Clear();   

// int[,] myArray1 = GetIntArray();
// double [,] myArray2 = GetDoubleArray();
// double [,] myArray = GetArray(myArray1,myArray2);
// PrintArray(myArray);

// 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 10 7 2
// 5 9 2 3
// 8 10 2 10

// 1, 7 -> такого числа в массиве нет

// int[,] GetArray()
// {
//     int[,] result = new int[10, 10];
//     for (int i = 0; i < 10; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//             result[i, j] = new Random().Next(0, 41);
//         }
//     }
//     return result;
// }

// void FindValue(int[,] array, int m, int n)
// {
//     if (m > 10 || n > 10)
//     Console.Write(m + ", " + n + " -> The position is out of the massive! ");
//     else  
//     Console.Write("The value of the position is " + array[m - 1, n - 1] + ".");
// }

// void PrintArray (int[,] array)   
//  {
//     Console.WriteLine();
//     for (int i = 0; i < 10; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//         Console.Write($"{array[i, j]} ");
//         }    
//     Console.WriteLine();
//     }
// } 

// Console.WriteLine("Input the position of the row in the massive: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input the position of the column in the massive: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = GetArray();
// PrintArray(myArray);
// Console.WriteLine();
// FindValue(myArray, row, column);

// 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 10 7 2
// 5 9 2 3
// 8 10 2 10

// Среднее арифметическое каждого столбца: 10,6; 5,6; 3,6; 3.

// int[,] GetArray()
// {
//     int[,] result = new int[10, 10];
//     for (int i = 0; i < 10; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//             result[i, j] = new Random().Next(0, 41);
//         }
//     }
//     return result;
// }

// void PrintIntArray (int[,] array)   
//  {
//     Console.WriteLine();
//     for (int i = 0; i < 10; i++)
//     {
//         for (int j = 0; j < 10; j++)
//         {
//         Console.Write($"{array[i, j]} ");
//         }    
//     Console.WriteLine();
//     }
// } 

// void PrintDoubleArray (double[] array)   
// {
//     Console.WriteLine();
//      Console.Write("Arithmetic mean of each column: ");
//     for (int i = 0; i < 10; i++)    
//     {
//         Console.Write($"{array[i]}; ");
//     }
// }

// double[] FindMiddle(int[,] array)
// {
//     double[] result = new double[10];
//     for (int i = 0; i < 10; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < 10; j++)
//         {
//             sum = sum + array[j, i];
//             result[i] = sum; 
//         }
//     }
//     for (int k = 0; k < 10; k++)
//     {
//     result[k] = result [k] / 10;
//     }
//     return result;
// }

// int[,] myArray = GetArray();
// PrintIntArray(myArray);
// double[] finalArray = FindMiddle(myArray);
// PrintDoubleArray(finalArray);
// Console.WriteLine();