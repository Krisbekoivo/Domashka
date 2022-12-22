// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int CutNumber (int number)
{
    int result = (number / 10) % 10;
    return result;
}

Console.Write("Введите трехзначное число:" );
int newNumber = Convert.ToInt32(Console.ReadLine());

if (newNumber < 100)
{
    Console.Write("Это не трехзначное число");
}
else
{
    int num1 = CutNumber(newNumber);
    Console.WriteLine("New version of number is" + num1);
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
 bool InfoNumber (int number)
 {
if (number == 6 || number == 7) return true;
else 
return false;
 }
 Console.Write ("Input a number: " );
 int num1 = Convert.ToInt32(Console.ReadLine());

 if (InfoNumber(num1))
 {
    Console.WriteLine("Yes");
 }
 else
 {
    Console.WriteLine("No");
 }
 */

 // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int CutNumber (int number)
{   int result;
while (number > 999)
{number = number / 10;}    
    result = number % 10;
     return result;
}

  Console.Write("Введите число " );
int newNumber = Convert.ToInt32(Console.ReadLine());


if (newNumber < 99)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    int b = CutNumber(newNumber);
    Console.WriteLine("Третья цифра заданного числа" + b);
}
*/


    


