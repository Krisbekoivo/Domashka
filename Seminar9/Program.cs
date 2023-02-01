/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.

void ShowNumbers (int n)
{
    Console.Write(n + " ");
    if (n>1) ShowNumbers(n-1);
}
Console.WriteLine("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSum(int m, int n)
{
    if (m == n) return m;
    else if (m < n) return n + GetSum(m, n - 1);
    else return n + GetSum(m, n + 1);
}
Console.WriteLine("Input a number m");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number n");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSum(m1, n1));

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int FunctionAkkermana (int m, int n)
{
if (m == 0) return n+1;
else if (n == 0) return FunctionAkkermana(m-1, 1);
else if ((m > 0) && (n > 0)) return FunctionAkkermana(m-1,FunctionAkkermana(m,n-1));
return FunctionAkkermana(m,n);
}

Console.WriteLine("Input a number m");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number n");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FunctionAkkermana(m1, n1));