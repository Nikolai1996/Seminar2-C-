// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    int first = num / 10;
    int second = first % 10;
    int result = second;
    return result;
}

int res = SecondDigit(threeNumber);
Console.WriteLine(res);
