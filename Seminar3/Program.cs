// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
return result;
}
Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The distance between the points: " + Math.Round(FindDistance(x1,y1,z1,x2,y2,z2),2));

*/
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube(int n)
{
int count = 1;
Console.WriteLine("Сubes of numbers are ");
while (count< n+1)
{
    Console.Write((Math.Pow(count,3)) + " ");
    count++;
}
}
Console.Write("Input a number ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);

*/
// Задача 19 Напишите программу, которая принимает на вход любое число и проверит, является ли оно палиндромом.


int Palindrom (int number)
{   int result = 0;
while (number > 0)    
    { 
        result = (result * 10) + (number % 10);
        number =number /10;
    }
    return result;
}

Console.Write("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());

if ((Palindrom(number1)) == number1)  Console.Write("Является палиндромом");
else Console.Write("Не является палиндромом");








