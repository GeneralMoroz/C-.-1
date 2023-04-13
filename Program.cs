// Задача 1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.WriteLine("Введите число");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2=Convert.ToInt32(Console.ReadLine());

// if (number1 > number2)
// {

//     Console.WriteLine(number1);
// }
// else if (number1 == number2)
// {
//     Console.WriteLine("Числа равны");
// }
// else 
// {
// Console.WriteLine(number2);
// }

// Задача 2.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите число");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int number3=Convert.ToInt32(Console.ReadLine());
// int max = number1;

// if (max < number2)
// {
//     max = number2;
// }
// else 
// {
//     max = number1;
//     }

// if(max < number3)

// {
//     max =number3;
// }
// else
// {
//     max = max;
// }
// Console.WriteLine("Максимальное число равно:");
// Console.Write(max);

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.WriteLine("Введите число");
// int number=Convert.ToInt32(Console.ReadLine());
// int result = number%2;
// if ( result == 0)
// {
//  Console.WriteLine("Число является четным");   
// } 
// else
// {
//     Console.WriteLine("Число является нечетным");   
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int n=Convert.ToInt32(Console.ReadLine());
int nn=1;
int result = nn%2;
while (n > nn)
{
    if ( result == 0)
{
Console.WriteLine(nn);  
}
else
{
 nn = nn + 1;
} 
}
//не понял как делать
