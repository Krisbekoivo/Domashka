/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

double[,] CreateRandom2dArray()
{
Console.Write("Input a number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value ");
int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0;j < columns; j++)
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(),2);
    return array;
}
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray()
{
    int[,] array = new int[5, 7];
    for (int i = 0; i < 5; i++)
        for (int j = 0; j < 7; j++)
            array[i, j] = new Random().Next(1, 50);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindPosit(int[,] array)
{
    Console.Write("Input a index of row ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a index of column ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a <= array.GetLength(0) && b <= array.GetLength(1))
        Console.WriteLine($"{array[a, b]}");
    else Console.Write("Not found");

}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FindPosit(myArray);

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 50);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindSrednArifm(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            result += array[i, j];
        result = Math.Round(result / array.GetLength(0), 1);
        Console.Write(result + "; ");
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FindSrednArifm(myArray);

