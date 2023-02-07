/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] arr = GetRandomArray(8);
PrintArray(arr);

int[] GetRandomArray(int lenght)
{
    int [] result = new int[lenght];

    for(int i = 0; i < lenght; i++)
    {
        result[i] = new Random(). Next(1,99);
    }
    return result;
}

void PrintArray(int[] arr)
{
  foreach(int item in arr)
  {
    System.Console.Write(item + " ");
  }
} 
