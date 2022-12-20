/*Напишите программу, которая на вход принимает 
два числа и выдает, какое число большее, а какое меньшее.
*/
Console.WriteLine("Привет! Я могу сравнивать два числа, прикинь.");

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{ 
    Console.WriteLine("Числа равны");
}

if (number1 > number2 && number1 != number2)
{
    Console.WriteLine("Первое число больше второго");
} 

if (number2 > number1 && number1 != number2)
{
    Console.WriteLine("Второе число больше первого");
} 
