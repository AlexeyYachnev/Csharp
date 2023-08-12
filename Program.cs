// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num/10000==num%10) && ((num/1000)%10==(num/10)%10))
// {
//     Console.WriteLine("Палиндром");
// }    
   
// else
// {
//     Console.WriteLine("Не пятизначное или не палиндром");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите координату X1");
// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y1");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Координата Z1 выбрана случайно в диапазоне от 1 до 99");
// int Z1 = new Random().Next(1,100);
// Console.WriteLine($"Она равна " +Z1);

// Console.WriteLine("Введите координату X2");
// int X2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату Y2");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Координата Z2 выбрана случайно в диапазоне от 1 до 99");
// int Z2 = new Random().Next(1,100);
// Console.WriteLine($"Она равна " +Z2);

// double num= Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));

// Console.WriteLine($"Окей, координаты певой точки это ("+X1+", "+Y1+", "+Z1+")" );
// Console.WriteLine($"Координаты второй точки это ("+X2+", "+Y2+", "+Z2+")" );
// Console.WriteLine($"Расстояние между ними равно "+num );


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число чтобы возвести последовательность чисел до этого числа в куб");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i=1; i<=num; i++)
// {
//     Console.WriteLine(Math.Pow(i,3));
// }