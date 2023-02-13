// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Console.ReadLine();
}

string N = GetNumber("Введите, пожалуйста, число: ");

if (int.TryParse(N, out int number))
{
    int length = N.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum = Convert.ToInt32(Convert.ToString(N[0 + i])) + sum;
    }
    System.Console.WriteLine("Сумма цифр введённого числа = " + sum);
}
else
{
    System.Console.WriteLine("Введено не число");
}