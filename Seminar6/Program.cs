/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



int FindCount(int m)
{int l = 0;
int count =0;
    for (int i = 1; i <= m; i++) 
    {
        Console.Write("Введите число ");
        l = Convert.ToInt32(Console.ReadLine());
        if (l > 0) count=count + 1;
    } 
    return count;
}


Console.Write("Введите количество чисел ");
int m = Convert.ToInt32(Console.ReadLine());

int result = FindCount(m);
Console.Write(result);


Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


void FindPoint(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1)/(k1 - k2),2);
    double y = Math.Round(k1 *x + b1,2);
    Console.Write($"Координаты пересечения ({x}; {y})");
}

Console.Write("Введите b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

FindPoint(b1,k1,b2,k2);