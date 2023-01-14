// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int GetMathPow(int a, int b)
{   int a1 = 1;
    int count = 1;
    while (count <= b)
    {
        a1 = a * a1;
        count+=1;
    }
    return a1;
}

Console.Write ("Input a number A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Input a number B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = GetMathPow(num1,num2);
Console.WriteLine(result);


Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int GetSum(int numb)
{int sum = 0;
     
    while (numb > 0)
    {
        sum = sum + numb % 10;
        numb = numb /10;
    }
    return sum;
}

Console.Write("Input a number ");
int n = Convert.ToInt32(Console.ReadLine());

int result = GetSum(n);
Console.WriteLine(result);

Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.*/


int[] CreateArray(int m)
{
    int[] array = new int [m];
    Console.WriteLine("Введите элементы массива ");
    for(int i = 0; i < m; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
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
Console.Write("Введите число элементов массива ");
int s = Convert.ToInt32(Console.ReadLine());


int[] newArray =CreateArray(s);
ShowArray(newArray);