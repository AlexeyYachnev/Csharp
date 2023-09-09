// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void FromNtoOne()
//     {
//         Console.Write("Введите число N: ");
//         int N = int.Parse(Console.ReadLine());

//         Console.WriteLine("Числа от N до 1");
//         PrintNumbers(N);
//     }

// void PrintNumbers(int n)
//     {
//         if (n == 1)
//         {
//             Console.Write(n+" ");
//         }
//         else
//         {
//             Console.Write(n+"  ");
//             PrintNumbers(n - 1);
//         }
//     }
// FromNtoOne();





// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void FromMtoN()
//     {
//         Console.Write("Введите число M: ");
//         int M = int.Parse(Console.ReadLine());

//         Console.Write("Введите число N: ");
//         int N = int.Parse(Console.ReadLine());

//         if (M > N)
//         {
//             Console.WriteLine("M должно быть меньше или равно N.");
//         }
//         else
//         {
//             int sum = SumNumbers(M, N);
//             Console.WriteLine($"Сумма чисел от {M} до {N} равна: {sum}");
//         }
//     }

//     int SumNumbers(int start, int end)
//     {
//         if (start > end)
//         {
//             return 0;
//         }
//         return start + SumNumbers(start + 1, end);
//     }
//     FromMtoN();




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//  void Ackerman()
//     {
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());

//         int result = AckermannFunction(m, n);

//         Console.WriteLine($"Значением функции Аккермана для m = {m} и n = {n} будет: {result}");
//     }

//     static int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return AckermannFunction(m - 1, 1);
//         }
//         else
//         {
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//         }
//     }
//     Ackerman();
