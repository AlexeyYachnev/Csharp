// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// void CreateMatrix()
// {
// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(0,10);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1)-1; k++)
//             {
//                 if (matrix[i,k]<matrix[i,k+1])
//                 {
//                 int temporary = matrix[i,k+1];
//                 matrix[i,k+1]=matrix[i,k];
//                 matrix[i,k]=temporary;
//                 }
//             }
//         }
//     }
// PrintMatrix(matrix);

// void PrintMatrix(int [,] matrix)

// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+" ");
            
//         }
//         Console.WriteLine();
        
//     }
// }
// }
// CreateMatrix();




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой
// элементов: 1 строка

// int[,] matrix = new int[4,3];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(0,10);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }
// int SumRow1=0;
// int SumRow2=0;
// int SumRow3=0;
// int SumRow4=0;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {

//            if(i==0) {SumRow1+=matrix[i,j];}
//            else if(i==1){SumRow2+=matrix[i,j];}
//            else if(i==2){SumRow3+=matrix[i,j];}
//            else if(i==3){SumRow4+=matrix[i,j];}            
//     }
// }
// if ((SumRow1<SumRow2)&&(SumRow1<SumRow3)&&(SumRow1<SumRow4))
// {
//     Console.WriteLine("Минимальная сумма элементов содержится в первой строке и равна: "+SumRow1);
// }
// else if ((SumRow3<SumRow1)&&(SumRow3<SumRow2)&&(SumRow3<SumRow4))
// {
//     Console.WriteLine("Минимальная сумма элементов содержится в третьей строке и равна: "+SumRow3);
// }
// else if ((SumRow4<SumRow1)&&(SumRow4<SumRow2)&&(SumRow4<SumRow3))
// {
//     Console.WriteLine("Минимальная сумма элементов содержится в четвертой строке и равна: "+SumRow4);
// }
// else
// {
//     Console.WriteLine("Минимальная сумма элементов содержится во второй строке и равна: "+SumRow2);
// }
// Console.WriteLine("Первая: "+SumRow1+", Вторая: "+SumRow2+", Третья: "+SumRow3+", Четвертая: "+SumRow4+".");





// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void MatrixMultiply()
// {
//     int [,] matrix1 = new int[2,2];
//     int [,] matrix2 = new int[2,2];
//     int [,] result = new int[2,2];
// Console.WriteLine("Первая матрица:");
// for (int i = 0; i < matrix1.GetLength(0); i++)
//      {
//         for (int j = 0; j < matrix1.GetLength(1); j++)
//         {
//             matrix1[i,j]=new Random().Next(1,4);
//             Console.Write(matrix1[i,j]+" ");
//         }
//         Console.WriteLine();
//      }
//     Console.WriteLine();
// Console.WriteLine("Вторая матрица:");
// for (int i = 0; i < matrix2.GetLength(0); i++)
//      {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             matrix2[i,j]=new Random().Next(1,4);
//             Console.Write(matrix2[i,j]+" ");
//         }
//         Console.WriteLine();       
//      }
//      Console.WriteLine();
//      for (int i = 0; i < result.GetLength(0); i++)
//      {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int k = 0; k < result.GetLength(1); k++)
//             {
//                 result[i,j]+=matrix1[i,k]*matrix2[k,j];
//             }
//         }
//      }
//      Console.WriteLine("Результат:");
//      for (int i = 0; i < result.GetLength(0); i++)
//      {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Console.Write(result[i,j]+" ");
//         }
//         Console.WriteLine();
//      }
// }
// MatrixMultiply();





// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// void Matrix3D()
//     {
//         int n = 2;
//         int[,,] matrix3D = new int[n, n, n];
//         var usedNumbers = new HashSet<int>();
//         for (int i = 0; i < matrix3D.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix3D.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrix3D.GetLength(2); k++)
//                 {
//                     int number;
//                     do
//                     {number = new Random().Next(1,10);
//                     }while (usedNumbers.Contains(number));
//                         matrix3D[i, j, k] = number;
//                         usedNumbers.Add(number);
//                 }
//             }
//         }
//         for (int i = 0; i < matrix3D.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix3D.GetLength(1); j++)
//             {
//                 for (int k = 0; k < matrix3D.GetLength(2); k++)
//                 {
//                     Console.Write($"{matrix3D[i, j, k]} [{i}, {j}, {k}] ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
//     Matrix3D();


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void MatrixSpiral()
//     {
//         int n = 4;
//         int[,] matrixSriral = new int[n,n];
//         int num = 1;
//         int rowStart = 0, rowEnd = n - 1, columnStart = 0, columnEnd = n - 1;
//         while (num <= n * n)
//         {
//             for (int i = columnStart; i <= columnEnd; i++)
//             {
//                 matrixSriral[rowStart, i] = num++;
//             }
//             rowStart++;

//             for (int i = rowStart; i <= rowEnd; i++)
//             {
//                 matrixSriral[i, columnEnd] = num++;
//             }
//             columnEnd--;

//             for (int i = columnEnd; i >= columnStart; i--)
//             {
//                 matrixSriral[rowEnd, i] = num++;
//             }
//             rowEnd--;

//             for (int i = rowEnd; i >= rowStart; i--)
//             {
//                 matrixSriral[i, columnStart] = num++;
//             }
//             columnStart++;
//         }

//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write(matrixSriral[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }
//     MatrixSpiral();