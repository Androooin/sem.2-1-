/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.

 a = 5; b = 7 -> max = 7
 a = 2 b = 10 -> max = 10
 a = -9 b = -3 -> max = -3
 */
int Number1()
{
    Console.WriteLine("Write first number");
    int a = Convert.ToInt16(Console.ReadLine());
    return a;
}
int Number2()
{
    Console.WriteLine("Write second number");
    int a = Convert.ToInt16(Console.ReadLine());
    return a;
}

void Сomparison(int num1, int num2)
{
    if (num1 > num2)
    {
        Console.WriteLine($"Max number is {num1}");
    }
    else
    {
        Console.WriteLine($"Max number is {num2}");
    }
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}

int number1 = Number1();
int number2 = Number2();

Сomparison(number1, number2);

Lutsenko();

