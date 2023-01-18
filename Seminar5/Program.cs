/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
int [] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i=0; i < size; i++)
    array [i] = new Random().Next(99, 1000);
     return array;
}

int GetCountOfEven (int[] array)
{int count = 0;
        for (int i=0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
        return count;
}

void ShowArray(int[]array)
{   Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
                if (i == (array.Length - 1))
        {
            Console.Write(array[i] +" ");}
        else
        {Console.Write(array[i] + ", ");

        }
    Console.WriteLine("]");
}

Console.Write("Введите длину массива ");
int m = Convert.ToInt32(Console.ReadLine());

int []  newArray = CreateRandomArray(m);
ShowArray(newArray);
int n = GetCountOfEven(newArray);
Console.Write ("Количество четных чисел в массиве равно " + n);

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 

int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i=0; i < size; i++)
    array [i] = new Random().Next(minValue, maxValue + 1);
     return array;
}
void ShowArray(int[]array)

{   Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
                if (i == (array.Length - 1))
        {
            Console.Write(array[i] +" ");}
        else
        {Console.Write(array[i] + ", ");

        }
    Console.WriteLine("]");
    }

int GetSumOfOddPos (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2) sum = sum + array[i];
    return sum;
}


Console.Write("Введите число элементов массива ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);
int n = GetSumOfOddPos(newArray);

Console.Write("Сумма элементов в массиве на нечетных позициях равна " + n);

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i=0; i < size; i++)
    array [i] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(),2);
     return array;
}
void ShowArray(double[] array)
{   Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
                if (i == (array.Length - 1))
        {
            Console.Write(array[i] +" ");}
        else
        {Console.Write(array[i] + ", ");

        }
    Console.WriteLine("]");
}

double GetDiff(double[] array)
{
double maxi = array[0];
double mini = array[0];
double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {     
        if (array[i] > maxi) maxi = array[i];
        if (array[i] < mini) mini = array[i];
    }   
    diff = maxi - mini;     
return diff;
}

Console.Write("Введите число элементов массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);
double result = GetDiff(newArray);

Console.Write("Разница равна " + result);


