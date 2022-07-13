// Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter a number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number C: ");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;

if (B > max)
{
    max = B;
}
if (C > max)
{
    max = C;
}
Console.WriteLine(max);