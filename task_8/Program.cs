/*Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N
*/
Console.WriteLine("Привет! Я могу вывести все четные числа от 1 до N, прикинь.");

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
int n = 0;
if (number % 2 == 0)
{
    n = number;
}
else
{
    n = number - 1;
}
while (i <= n)
{
    Console.WriteLine(i);
    i = i + 2; 

} 