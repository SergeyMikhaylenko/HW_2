//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int NamberA = Convert.ToInt32(Console.ReadLine());
string NamberB = Convert.ToString(NamberA);
if (NamberB.Length > 2){
  Console.WriteLine("третья цифра от вашего числа " + NamberB[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}