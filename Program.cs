// Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter a number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number C: ");
int C = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (A > B)
{
    max = A;
}
else
{
   max = B;
}
if (B > C)
{
    max = B;
}
else
{
    max = C;
}
if (A > C)
{
    max = A;
}
else
{
    max = C;
}
Console.WriteLine(max);