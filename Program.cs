

//         Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] array =  new int[5];
// int num = 0;

// for(int i = 0; i<array.Length;i++)
// {
//     array[i] = new Random().Next(100,1000);
//         if (array[i]%2 == 0)
//         {
//                 num++;
              
//         }
// }
// Console.WriteLine (String.Join(",",array));
// Console.Write("Количество четных чисел = " +num);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
// int[] array =  new int[6];
// int num = 0;
//  for(int i = 0; i<array.Length;i++)
//  {
//    array[i] = new Random().Next(0,100);
//    if (i%2 !=0 )
//    {
//         num=num+array[i];
//    }
//  }
//  Console.WriteLine (String.Join(",",array));
// Console.Write("Сумма элементов стоящих на нечетных позициях = "+ num);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int[] array =  new int[6]{4,6,7,8,9,88};
// int R = 0;
// int max  = array[0];
// int min = array[0];
// // for(int i = 0; i<array.Length;i++)
// //  {
// //    array[i] = new Random().Next(0,100);
//  for(int i = 0; i<array.Length;i++)
// {
// if (array[i] > max)
//         {
//                max =  array[i];
//         }

//   else if (array[i] > min)
//         {
//                min =  array[i];
//         }

// }
//     Console.WriteLine (max);
//     Console.WriteLine (min);
// //  }
//  R = max-min;
//  Console.WriteLine (String.Join(",",array));
//  Console.Write("разница между максимальным и минимальным элементов массива = "+R);

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// // 1, -7, 567, 89, 223-> 3
//  int A = Convert.ToInt32(Console.ReadLine().Split().Select(int.Parse).ToArray());
// int[] array =  new int[6];
// Console.WriteLine (A);

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int[] array =  new int[]{num,num1};
// int r =0;
// Console.WriteLine (String.Join(",",array));
// for(int i = 0; i<array.Length;i++)
// {
//     if(array[i] > 0)
//     {
//         r++;
//     }
// }
// Console.WriteLine(r);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




