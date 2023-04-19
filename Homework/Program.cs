// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// Console.Clear();
// Console.WriteLine("Enter number A");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number B");
// int B = Convert.ToInt32(Console.ReadLine());

// double res = Math.Pow(A, B);
// Console.WriteLine($"Число А в степени И равно {res}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (num > 0)
//     {
//      sum = sum + num % 10;
//      num = num/10;
//     Console.WriteLine($"otvet: {num%10}");
//     }
// Console.WriteLine($"otvet: {sum}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(0, 100);
}
for (int i = 0; i < array.Length; i++)
{
  Console.Write($" {array[i]}" );
}
