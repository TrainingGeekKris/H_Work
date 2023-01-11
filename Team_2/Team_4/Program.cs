// Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число ");
int number1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ");
int number2=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ");
int number3=Convert.ToInt32(Console.ReadLine());
int numbermax=0;
if (number1>numbermax)
{
    numbermax=number1;  
}
if (number2>numbermax)
{
    numbermax=number2;
}
if (number3>numbermax)
{
    numbermax=number3;
}
Console.WriteLine ("Максимальное из трех чисел:");
Console.WriteLine (numbermax);
