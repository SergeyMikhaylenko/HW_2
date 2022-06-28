//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
string NumberB = Convert.ToString(NumberA);
if (NumberB.Length > 2){
  Console.WriteLine("третья цифра от вашего числа " + NumberB[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}