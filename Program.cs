// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



// int[,] matrix = new int[6,8]; 

// void NewMass(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             array[i,j] = new Random().Next(0,10); 
//         } 
//     } 
// } 

// void StMass(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             if (j == 0) 
//             { 
//                 System.Console.Write("["); 
//             } 
//             System.Console.Write(array[i,j]); 
//             if (j == array.GetLength(1) - 1) 
//             { 
//                 System.Console.Write("]"); 
//             } 
//             else 
//             { 
//                 System.Console.Write("; "); 
//             } 
//         } 
//         System.Console.WriteLine(); 
//     } 
// } 
// void SortArray(int[,] array) 
// { 
//   for (int i = 0; i < array.GetLength(0); i++) 
//   { 
//     for (int j = 0; j < array.GetLength(1); j++) 
//     { 
//       for (int k = 0; k < array.GetLength(1)-1;k++) 
//       { 
//         if (array[i, k] < array[i, k + 1]) 
//         { 
//           int temp = array[i, k + 1]; 
//           array[i, k + 1] = array[i, k]; 
//           array[i, k] = temp; 
//         } 
//       } 
//     } 
//   } 
// } 
// NewMass(matrix); 
// StMass(matrix); 
// SortArray(matrix); 
// System.Console.WriteLine(); 
// StMass(matrix);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] matrix = new int[6,8]; 

// void NewMass(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             array[i,j] = new Random().Next(0,10); 
//         } 
//     } 
// } 

// void StMass(int[,] array) 
// { 
//     for (int i = 0; i < array.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < array.GetLength(1); j++) 
//         { 
//             if (j == 0) 
//             { 
//                 System.Console.Write("["); 
//             } 
//             System.Console.Write(array[i,j]); 
//             if (j == array.GetLength(1) - 1) 
//             { 
//                 System.Console.Write("]"); 
//             } 
//             else 
//             { 
//                 System.Console.Write("; "); 
//             } 
//         } 
//         System.Console.WriteLine(); 
//     } 
// } 
// void SortArray(int[,] array) 
// { 
//   for (int i = 0; i < array.GetLength(0); i++) 
//   { 
//     for (int j = 0; j < array.GetLength(1); j++) 
//     { 
//       for (int k = 0; k < array.GetLength(1)-1;k++) 
//       { 
//         if (array[i, k] < array[i, k + 1]) 
//         { 
//           int temp = array[i, k + 1]; 
//           array[i, k + 1] = array[i, k]; 
//           array[i, k] = temp; 
//         } 
//       } 
//     } 
//   } 
// } 
// NewMass(matrix); 
// StMass(matrix); 
// SortArray(matrix); 
// System.Console.WriteLine(); 
// StMass(matrix);





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// System.Console.Write("Введите первую размерность массива: ");
// int rows = Convert.ToInt32(System.Console.ReadLine());
// System.Console.Write("Введите вторую размерность массива: ");
// int colums = Convert.ToInt32(System.Console.ReadLine());
// string[,] matrix = new string[rows, colums];
// void InputArray(string[,] array)
// {
//    int num = 1;
//    bool end = false;
//    int i = 0;
//    int j = 0;
//    int maxi = 0;
//    int maxj = 0;
//    int rowsStopDown = array.GetLength(0) - 1;
//    int columsStopRight = array.GetLength(1) - 1;
//    int rowsStopUp = 0;
//    int columsStopLeft = 0;
//     while (!end)
//     {
//         if (j > columsStopRight)
//         {
//             end = true;
//             break;
//         }
//         for (; j <= columsStopRight; j++)
//         {
//             if (num < 10)
//             {
//                 array[i, j] = "0" + num.ToString();
//                 maxi = i;
//                 maxj = j;
//             }
//             else
//             {
//                 array[i, j] = num.ToString();
//                 maxi = i;
//                 maxj = j;
//             }
//             num++;
//         }
//         i = maxi + 1;
//         rowsStopUp = i;
//         j = maxj;
//         if(rows == 1)
//         {
//             break;
//         }
//         for (; i <= rowsStopDown; i++)
//         {
//             if (num < 10)
//             {
//                 array[i, j] = "0" + num.ToString();
//                 maxi = i;
//                 maxj = j;
//             }
//             else
//             {
//                 array[i, j] = num.ToString();
//                 maxi = i;
//                 maxj = j;
//             }
//             num++;
//         }
//         i = maxi;
//         j = maxj - 1;
//         columsStopRight = j;
//         for (; j >= columsStopLeft; j--)
//         {
//             if (num < 10)
//             {
//                 array[i, j] = "0" + num.ToString();
//                 maxi = i;
//                 maxj = j;
//             }
//             else
//             {
//                 array[i, j] = num.ToString();
//                 maxi = i;
//                 maxj = j;
//             }
//             num++;
//         }
//         i = maxi - 1;
//         rowsStopDown = i;
//         j = maxj;
//         for (; i >= rowsStopUp; i--)
//         {
//             if (num < 10)
//             {
//                 array[i, j] = "0" + num.ToString();
//                 maxi = i;
//                 maxj = j;
//             }
//             else
//             {
//                 array[i, j] = num.ToString();
//                 maxi = i;
//                 maxj = j;
//             }
//             num++;
//         }
//         i = maxi;
//         columsStopLeft = maxi;
//         j = maxj + 1;
//     }
// }
// void PrintArray(string[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == 0)
//             {
//                 System.Console.Write("[");
//             }
//             System.Console.Write(array[i, j]);
//             if (j == array.GetLength(1) - 1)
//             {
//                 System.Console.Write("]");
//             }
//             else
//             {
//                 System.Console.Write("; ");
//             }
//         }
//         System.Console.WriteLine();
//     }
// }
// InputArray(matrix);
// PrintArray(matrix);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



// Console.Write("Введите первую размерность первого массива: ");
// int rowsOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую размерность первого массива: ");
// int columsOne = Convert.ToInt32(Console.ReadLine());
// int[,] matrixOne = new int[rowsOne, columsOne];
// Console.Write("Введите первую размерность второго массива: ");
// int rowsTwo = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую размерность второго массива: ");
// int columsTwo = Convert.ToInt32(Console.ReadLine());
// int[,] matrixTwo = new int[rowsTwo, columsTwo];
// if (rowsOne == columsTwo)
// {
//     int[,] matrixThree = new int[rowsOne, columsTwo];
//      void InputArray(int[,] array)
//      {
//          for(int i = 0; i < array.GetLength(0); i++)
//          {
//              for(int j = 0; j < array.GetLength(1); j++)
//              {
//                  array[i, j] = new Random().Next(10, 100);
//              }
//          }
//     }
//     void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (j == 0)
//                 {
//                     System.Console.Write("[");
//                 }
//                 System.Console.Write(array[i, j]);
//                 if (j == array.GetLength(1) - 1)
//                 {
//                     System.Console.Write("]");
//                 }
//                 else
//                 {
//                     System.Console.Write("; ");
//                 }
//             }
//             System.Console.WriteLine();
//         }
//     }
//     void MultiplyMatrix(int[,] firstMatrix, int[,] secomdMartrix, int[,] resultMatrix)
//     {
//         for (int i = 0; i < resultMatrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < resultMatrix.GetLength(1); j++)
//             {
//                 int sum = 0;
//                 for (int k = 0; k < firstMatrix.GetLength(1); k++)
//                 {
//                     sum += firstMatrix[i, k] * secomdMartrix[k, j];
//                 }
//                 resultMatrix[i, j] = sum;
//             }
//         }
//     }
//         InputArray(matrixOne);
//         InputArray(matrixTwo);
//         PrintArray(matrixOne);
//         System.Console.WriteLine();
//         PrintArray(matrixTwo);
//         System.Console.WriteLine();
//         MultiplyMatrix(matrixOne, matrixTwo, matrixThree);
//         PrintArray(matrixThree);
// }
// else
// {
//     System.Console.WriteLine
//     ("Ошибка! Нельзя найти произведение двух заданных матриц, так как количество строк первой матрицы не равно количеству строк второй!");
// }


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// Console.WriteLine("Первую размерность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторую размерность массива");
// int coloms = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("третью размерность массива");
// int depth = Convert.ToInt32(Console.ReadLine());
// int c=0;

// int[,,] matrix= new int[rows,coloms,depth];
// void CreateArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j <  matrix.GetLength(1); j++)
//         {
//           for(int k = 0; k <  matrix.GetLength(2); k++)
//             {
//               c=new Random().Next(10,100);
              
//               foreach (int item in matrix)
//               {
//                 if(item!=c ) 
//                 {
                
//                 matrix[i,j,k]=c; 
//                 }           
//               }
                           
//             } 

//         }
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j <  matrix.GetLength(1); j++)
//             {
//             for(int k = 0; k <  matrix.GetLength(2); k++)
//              {
//                 Console.Write(matrix[i,j,k]+ $"[ {i} {j} {k}]");
//              }
//             Console.WriteLine();
//             }
//         }
// }


// CreateArray();
// PrintArray();
// Console.WriteLine();
