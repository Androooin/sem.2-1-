/*
Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
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
int Number3()
{
    Console.WriteLine("Write third number");
    int a = Convert.ToInt16(Console.ReadLine());
    return a;
}

void MaxNumber(int num1, int num2, int num3)
{
    if (num1 > num2 && num1 > num3) Console.WriteLine($"Max number is {num1}");
    else if (num1 > num2 && num1 < num3) Console.WriteLine($"Max number is {num3}");
    else if (num1 < num2 && num2 > num3) Console.WriteLine($"Max number is {num2}");
    else Console.WriteLine($"Max number is {num3}");
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");

}



int number1 = Number1();
int number2 = Number2();
int number3 = Number3();

MaxNumber(number1, number2, number3);

Lutsenko();
