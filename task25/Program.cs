// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int A = GetNumber("Введите число A");
int B = GetNumber("Введите число B");

int res = 1;
if (B == 0) res = 0;
else
{
    for (int count = 1; count <= B; count++)
    {
        res *= A;
    }
}
System.Console.WriteLine($"{A} в степени {B} = {res}");