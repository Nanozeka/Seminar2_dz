// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7 ");
 int num = Convert.ToInt32(Console.ReadLine());

if  (num > 0 && num < 6 )
 Console.WriteLine($" {num} -> Нет ");

if  (num > 5 && num < 8 )
 Console.WriteLine($" {num} -> Да ");

if  (num > 7 )
Console.WriteLine($"{num} -> Такого числа не существует");

if  (num < 1 )
Console.WriteLine($"{num} -> Такого числа не существует");



