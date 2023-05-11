/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные 
числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


int Number()
{
    Console.WriteLine("Write number");
    int a = Convert.ToInt16(Console.ReadLine());
    return a;
}

void Result(int num1)
{
    for (int i = 2; i <= num1 - 2; i = i + 2)
    {
        Console.Write($"{i}, ");
    }
    if (num1 % 2 == 0) Console.WriteLine($"{num1}");
    else
    {
        int res = num1 - 1;
        Console.WriteLine($"{res}");
    }
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}




int number = Number();

Result(number);

Lutsenko();
