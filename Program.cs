// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// PrintNambers(N);

// void PrintNambers (int N) // передаем значение N

// {
//     if(N<1)
//     {
//         return;
//     }
//      Console.Write(N + " ");
//     PrintNambers(N-1);
   
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int SumNumbers (int sum)
{
 
while (M < N)
{
    M++;
    sum = sum +M;
}

    return  sum;
   
}
Console.WriteLine(SumNumbers(sum));