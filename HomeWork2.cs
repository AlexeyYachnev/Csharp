// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1=num%100;
// int num2=num1/10;

// Console.WriteLine($"Ваша любимая цифра это "+num2);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите трехзначное и более число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num<100)
// {
//     Console.WriteLine($""+num+ " - это не трехзначное число");
// }
// else
// {
//     int num1=num%10;
//     Console.WriteLine($"Последняя цифра вот "+num1);
// }

//||

// Console.WriteLine("Введите трехзначное и более число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num<100)
// {
//     Console.WriteLine($""+num+ " - это не трехзначное число");
// }
// else if (num>999)
// {
//     int num1=num%1000;
//     int num2=num1/100;
//         Console.WriteLine($"Третья цифра вот "+num2);
// }   
// else
// {
//  int num1=num/100;
//     Console.WriteLine($"Первая цифра вот "+num1);
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// Console.WriteLine("Проверим день недели");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num>7) || (num<1))
// {
//     Console.WriteLine("Цифра не соответствует дню недели");
// }
// else if (num<6)
// {
//     Console.WriteLine("Будний день!");
// }
// else
// {
//     Console.WriteLine("Можно отдохнуть...");
// }
