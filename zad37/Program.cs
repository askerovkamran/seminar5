// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

Console.WriteLine("Размер массива: "); 
int n; 
n = Convert.ToInt32(Console.ReadLine()); 
int[] ar = new int[n]; 
var rand = new Random(); 
    for(int i = 0; i < ar.Length; i++) 
    ar[i] = rand.Next(-50, 50); 
    Console.Write("Значения элементов массива: "); 
    foreach(var item in ar) 
    Console.Write("{0} ", item); 
    Console.WriteLine(); 
    for(int i = 0; i < ar.Length / 2; i++) 
Console.WriteLine("элемент {0} * элемент {1}, {2} * {3}  = {4}", i, ar.Length - i - 1, ar[i], ar[ar.Length - i - 1], ar[i] * ar[ar.Length - i - 1]); 
      return; 