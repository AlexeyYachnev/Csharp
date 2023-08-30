// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// Console.WriteLine("m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("n");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double[m,n];

// for (int i = 0; i < matrix.GetLength(0) ; i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]=Math.Round(new Random().Next(0,10)+new Random().NextDouble(),1);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Запросите координаты объекта x и y через пробел");
// string? s = Console.ReadLine();
// int x = s[0]-49; // не знаю почему тут 49 но это работает с учетом того, что марицу
// int y = s[2]-49; // здесь намеренно считаю от (1,1) т.к. программы пишутся для простых людей
// int pos = 0;     // которые начинают считать с 1.
// void res()
// {
//     Console.WriteLine("Парень из толпы это: "+pos);
// }

// int[,] matrix = new int[5,5];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j]= new Random().Next(0,10);
//         Console.Write(matrix[i,j]+" ");
//     }
//     Console.WriteLine();
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i==y && j==x)
//         {
//             pos+=matrix[i,j];
//             res();
//         }
//     }
// }
// if (y>matrix.GetLength(0)-1 || x>matrix.GetLength(1)-1)
//         {
//             Console.WriteLine("Названные координаты не входят в диапазон");
//         }

//  Console.WriteLine($" "+x+" "+y+" "+s); // следил что записывает



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// double sumrow1 = 0;
// double sumrow2 = 0;
// double sumrow3 = 0;
// double sumrow4 = 0;

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
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (j==0)
//         {
//             sumrow1+=matrix[i,j];
//         }
//         else if (j==1)
//         {
//             sumrow2+=matrix[i,j];
//         }
//         else if (j==2)
//         {
//             sumrow3+=matrix[i,j];
//         }
//         else if (j==3)
//         {
//             sumrow4+=matrix[i,j];
//         }     
//     }
// }
// Console.Write(Math.Round(sumrow1/matrix.GetLength(0),1));
// Console.Write(" ");
// Console.Write(Math.Round(sumrow2/matrix.GetLength(0),1));
// Console.Write(" ");
// Console.Write(Math.Round(sumrow3/matrix.GetLength(0),1));
// Console.Write(" ");
// Console.Write(Math.Round(sumrow4/matrix.GetLength(0),1));

//программа работает, однако, мне кажется, что она может быть короче. После просмотра
//лекций "Как не нужно писать код" теперь кажется что тут вообще все плохо. Необходимо больше работать.
//Спасибо, что проверяете мои работы.