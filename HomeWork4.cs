// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число");
// int num1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень числа");
// int num2= Convert.ToInt32(Console.ReadLine());
// double res=0;
// for (int i=0; i<=num2; i++)
// {
//     res =  Math.Pow(num1, i);
// }

// Console.WriteLine(res);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int SumDigit()
// {
//  int num1 = 0;
    
//     while (num>0)
//     {
        
//         num1=num1+num%10;
//         num/=10;
//     }
//     return num1;
// }
// int result = SumDigit();

// Console.WriteLine(result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] array = new int [8];
// void GetArray()
// {
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i]= new Random().Next(0,10);
//         Console.Write(array[i]+" ");
//     }
// }
// GetArray();