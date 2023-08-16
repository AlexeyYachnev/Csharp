// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int [7];

// int count = 0;


// for ( int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i]+" ");

//     if (array[i]%2==0)
//     {
//         count=count+1;
//     }
// }
// Console.WriteLine($"Количество четных = {count},");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int [] array = new int [5];

// int sumOddNumbers = 0;

// for ( int i=0; i<array.Length; i++)
// {
//     array[i] = new Random().Next(0, 10);
//     Console.Write(array[i]+" ");
// }
// for(int i=0; i<array.Length;)
//     {
//         sumOddNumbers=sumOddNumbers+array[i];
//         i=i+2;
//     }
// Console.WriteLine($"Сумма нечетных элементов = {sumOddNumbers}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



// double [] array = new double [5];


// for (int i = 0; i < array.Length; i++)
// {

//     array[i] = Math.Round (new Random().NextDouble()+new Random().Next(0,10),2);
//     Console.Write(array[i]+" ");
    
// }
// double maxNumber=array[0];
// double minNumber=array[0];
// int h=1;

// while (h<array.Length)
// {
//     if (array[h]<minNumber)
//     {
//         minNumber=array[h];
//     }
//     if(array[h]>maxNumber)
//     {
//         maxNumber=array[h];
//     }
//     h++;
// }
// Console.WriteLine(" ");
// Console.WriteLine($"Результат = "+(Math.Round(maxNumber-minNumber,2)));
