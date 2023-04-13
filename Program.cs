//1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2=Convert.ToInt32(Console.ReadLine());
int max = 0;
if (number1 > number2)
{
   // max = number1
    Console.WriteLine(number1);
}
else if (number1 == number2)
{
    Console.WriteLine("Числа равны");
}
else 
{
Console.WriteLine(number2);
}