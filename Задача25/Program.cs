//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите в какую степень возвести");
int b = int.Parse(Console.ReadLine());

var answer = Math.Pow(a, b);
System.Console.WriteLine("ответ = " + answer);