/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number a min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number a max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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
void ArrangeElemRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }

    }
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ArrangeElemRows(myArray);
Show2dArray(myArray);

Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number a min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number a max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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

void FindMinSumRow(int[,] array)
{
    int indexMinRow = 0;
    int minRow = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }


    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumMinRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sumMinRow += array[i, j];
        Console.WriteLine($"Сумма {i + 1} строки = {sumMinRow} ");

        if (minRow > sumMinRow)
        {
            minRow = sumMinRow;
            indexMinRow = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов равна {indexMinRow + 1}");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FindMinSumRow(myArray);

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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
Console.Write("Input a number of rows first matrix ");
int r1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns first matrix ");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of rows second matrix ");
int r2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns second matrix ");
int c2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number a min possible value ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] m3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                m3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return m3;
}


int[,] m1 = CreateRandom2dArray(r1, c1, min, max);
Show2dArray(m1);
int[,] m2 = CreateRandom2dArray(r2, c2, min, max);
Show2dArray(m2);
Show2dArray(MatrixMultiplication(m1,m2));

Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
*/
Console.Write("Input a number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of pages ");
int pages = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[rows, columns, pages];

void CreateRandom3dArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
        }
    }
    Console.WriteLine();
}

CreateRandom3dArray(array);
Show3dArray(array);

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:*/