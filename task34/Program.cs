﻿/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2

1. Создаем массив, заполненный случайными положительными. Значения элементов лежат в отрезке (99, 1000)
2. Создаем переменную, которая будет аккумулировать результат
3. Создаем цикл, в котором при помощи остатка от деления на 2 будем искать четные числа, 
а также аккумулировать их общее число через сумму
5. Выводим результат на экран
*/

Console.Clear();
int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int [] array = GetArray(10, 100, 999);
Console.WriteLine();

int evenNumbers = 0;

for(int i =0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        evenNumbers++;
    }
}

Console.WriteLine($"Количество четных чисел в массиве равно {evenNumbers}");