// Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ThirdDigit(int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    return num % 10;
}
if (number < 0) number -= number;

if (number > 99)
{
    int result = ThirdDigit(number);
    Console.WriteLine(result);
}

else
{
    Console.WriteLine("Третья цифра отсутствует.");
}