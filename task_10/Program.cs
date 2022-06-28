// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number);

string result = Convert.ToString(number);

Console.WriteLine(result[1]);