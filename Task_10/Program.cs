// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

 Console.WriteLine("Введите трехзначное число ");
 int num = Convert.ToInt32(Console.ReadLine());

 int res = FindSekond(num);

 Console.WriteLine($" {num} -> {res}");

 int FindSekond(int num)

 {
 int a = num/10;
 int res = a %10;
 return a % 10;
 }

