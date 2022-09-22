/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

1. Создаем массив вещественных чисел double.
2. С помощью Math.Round убираем знаки после запятой.
3. Создаем промежуточные переменные для максимального и минимального элементов массива.
4. Отмечаем, что максимальным и минимальным элементами массива являются элементы с индексом ноль.
5. Сравниваем все элементы массива, таким образом находим максимальный и минимальный элементы.
6. Выводим на экран разность максимума и минимума.
*/

Console.Clear();
double [] GetArray(int size, int minValue, int maxValue)
{
    double [] res = new double [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        double number;
        Random rnd = new Random();
        number = rnd.NextDouble();
        res[i] = res[i] * number;
        res[i] = Math.Round(res[i], 0);
        Console.Write($"{res[i]} ");
    }
    return res;
}

double [] array = GetArray(10, 0, 100);
Console.WriteLine();

double maxNumber = array[0];
double minNumber = array[0];

for(int i = 1; i < array.Length; i++)
{
    if(array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
    else if(array[i] < minNumber)
    {
        minNumber = array[i];
    }
}

Console.WriteLine($"Разность между максимальным {maxNumber} и минимальным {minNumber} элементами массива равна {maxNumber - minNumber}");