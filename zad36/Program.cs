// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.


int[] array = GetArray(9 , 0, 999);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine("Сумма элементов стоящих на нечетных = {SumElement(array)}");

// Метод

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
int SumElement(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
if (i % 2 == 1) sum += array[i];
    }return sum;
}
