// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] GetArray()
{ int [] array = new int[8];
    for (int i=0; i< array.Length;i++)
    {
        array[i] = new Random().Next(-10,11);
    }
    return array;
}

void PrintArray(int []array)
{
  Console.Write("[");
  for (int i=0; i <array.Length;i++)
    {
        Console.Write(array[i]+",");
    }
    Console.Write("]");
}

PrintArray(GetArray());