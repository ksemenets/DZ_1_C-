﻿/*Напишите программу, которая на вход принимает число и выдает, является ли число четным 
*/
Console.WriteLine("Привет! Я могу определить четное ли число, прикинь.");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Введенное число - четное");
} 
else 
{
    Console.WriteLine("Введенное число - не четное");
}    