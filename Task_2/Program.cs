/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
   какое число большее, а какое меньшее. */

{

Console.WriteLine( " A " );

int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (" B ");

int B = Convert.ToInt32(Console.ReadLine());

if (A > B)

{
Console.WriteLine("min =" + B + " max =" + A);
}

else

{
Console.WriteLine("min =" + A + " max =" + B);
}

}
