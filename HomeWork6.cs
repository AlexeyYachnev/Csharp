// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// bool signalQuit = false;
// while (signalQuit==false)
// {

//     if (num>0)
//     {
//     count++;
//     Console.WriteLine("Введите число чтобы продолжить или напишите 0 чтобы завершть и получить результат");
//     num = Convert.ToInt32(Console.ReadLine());
    
//     }
//     if (num<0)
//     {
//         Console.WriteLine("Введите число чтобы продолжить или напишите 0 чтобы завершть и получить результат");
//         num = Convert.ToInt32(Console.ReadLine());
//     }
//     else
//     {
//         signalQuit=true;
//         Console.WriteLine($"Результат = "+count);
//     }
// }




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// const int COEF = 0;
// const int CONST = 1;
// const int X_COORD = 0;
// const int Y_COORD = 1;
// const int LINE1 = 1;
// const int LINE2 = 2;

// double[] lineData1 = InputLineData(LINE1);
// double[] lineData2 = InputLineData(LINE2);

// if (ValidateLines(lineData1, lineData2))
// {
//     double[] coord = FindCoords(lineData1, lineData2);
//     Console.Write($"Точка есть y={lineData1[COEF]}*x+{lineData1[CONST]} и y= {lineData2[COEF]}*x+{lineData2[CONST]}");
//     Console.WriteLine($"имеет {coord[X_COORD]}, {coord[Y_COORD]}");
// }
// double Prompt (string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     double result = Convert.ToDouble(value);
//     return result;
// }
// double[] InputLineData(int numberOfLine)
// {
//     double[] lineData = new double[2];
//     lineData[COEF] = Prompt($"Коэф для {numberOfLine}");
//     lineData[CONST] = Prompt($"Коэф для {numberOfLine}");
//     return lineData;

// }

// double[] FindCoords(double[] lineData1, double[] lineData2)
// {
//     double[] coord = new double[2];
//     coord[X_COORD] = (lineData1[CONST] - lineData2[CONST])/(lineData2[COEF] - lineData2[COEF]);
//     coord[Y_COORD] = lineData1[CONST] * coord[X_COORD] + lineData1[CONST];
//     return coord;
// }
// bool ValidateLines(double[] lineData1, double[] lineData2)
// {
//     if (lineData1[COEF]==lineData2[COEF])
//     {
//         if (lineData1[CONST]==lineData2[CONST])
//         {
//             Console.WriteLine("Совпадают");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine("Параллельны");
//             return false;
//         }

//     }
//     return true;
// }
// Да, скопировал второе, пока думаю как решить