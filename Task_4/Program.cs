/* Задача 4: Напишите программу, которая принимает на вход три числа,
   и выдаёт максимальное из этих чисел. */

double a , b, c;

Console.WriteLine("Enter free nombers one by one:");
a =Convert.ToDouble(Console.ReadLine());
b =Convert.ToDouble(Console.ReadLine());
c =Convert.ToDouble(Console.ReadLine());

if ((a > b) & (a > c))
{
    Console.WriteLine( + a );
}
if ((b > a) & (b > c))
{
    Console.WriteLine( + b );
}
if ((c > b) & (c > a))
{
    Console.WriteLine("Наибольшее число = " + c);
}
