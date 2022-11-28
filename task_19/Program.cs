/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/ 

Console.Clear();
Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;
int result = 0;
 
 while (m > 0) 
{
     result *= 10;
     result += m % 10;
     m /= 10;
}
   if ( n == result )
     {
        Console.Write("Да");
     }
     else 
     Console.Write("Нет");

