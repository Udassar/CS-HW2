// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Проверка на трехзначность при вводе пользователем)
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100, 1000);
// int u = (num / 10) % 10 ; 

// Console.WriteLine($"Вторая цифра числа {num} - это {u}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine()!);

// if (num <= 99)
// {
//     Console.WriteLine("Not found");
// }
// else if (num > 99 && num <= 999)
// {
//     int num3 = num % 10;
//     Console.WriteLine($"Третья ццифра {num3}");
// }
// else if (num > 999 && num <= 9999)
// {
//     int num3 = num % 100 / 10;
//     Console.WriteLine($"Третья ццифра {num3}");
// }
// else if (num > 9999 && num <= 99999)
// {
//     int num3 = num % 1000 / 100;
//     Console.WriteLine($"Третья ццифра {num3}");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите номер дня недели");
// int num = Convert.ToInt32(Console.ReadLine()!);

// if (num == 6 || num == 7)
// {
//     Console.WriteLine("Это выходной");
// }
// else
// {
//     Console.WriteLine("Не выходной");
// }
