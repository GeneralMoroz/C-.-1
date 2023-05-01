

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

int[] array =  new int[6]{4,6,7,8,9,88};
int R = 0;
int max  = 0;
int min = 0;
// for(int i = 0; i<array.Length;i++)
//  {
//    array[i] = new Random().Next(0,100);
 for(int i = 0; i<array.Length;i++)
{
if (array[i] > max)
        {
               max =  array[i];
        }

  else if (array[i] > min)
        {
               min =  array[i];
        }

}
    Console.WriteLine (max);
    Console.WriteLine (min);
//  }
 R = max-min;
 Console.WriteLine (String.Join(",",array));
 Console.Write("разница между максимальным и минимальным элементов массива = "+R);

