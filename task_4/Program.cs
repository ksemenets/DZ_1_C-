/*Напишите программу, которая принимает на вход 
три числа и выдает максимальное из этих чисел.
*/
Console.WriteLine("Привет! Я могу сравнивать ТРИ числа, прикинь.");

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max > number2)
{
    max = number1;
} 
else 
{
    max = number2;
}    
if (max > number3)
{
    Console.WriteLine("Максимальное число из трех: ");
    Console.WriteLine (max);
}
else
{
    Console.WriteLine("Максимальное число из трех: ");
    Console.WriteLine (number3);
    Console.WriteLine("Круто, да!?");
}
