// Задача 15: Напишите программу, которая принимает на
//  вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, которая обозначает день недели (От 1 до 7) ");
     int Days_of_the_week = Convert.ToInt32(Console.ReadLine());
     
     switch (Days_of_the_week)
     {

       case 1:
       case 2:
       case 3:
       case 4:
       case 5:
             Console.WriteLine("Это не выходной день");
            break;
       case 6:
       case 7:
             Console.WriteLine("Выходной");
            break;
       default:
     Console.WriteLine("Это не день недели");
     break;
     }