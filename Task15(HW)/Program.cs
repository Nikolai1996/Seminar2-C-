// Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, соответствующую дню недели: ");
int number = Convert.ToInt32(Console.ReadLine());

void CheckingDay(int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("-> да");
    }
    else if (num < 1 || num > 7)
    {
        Console.WriteLine("Такого дня недели не существует");
    }
    else Console.WriteLine(" -> нет");
}

CheckingDay(number);
