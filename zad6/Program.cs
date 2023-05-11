/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

int Number()
{
    Console.WriteLine("Write number");
    int a = Convert.ToInt16(Console.ReadLine());
    return a;
}

void Even(int num1)
{
    if (num1 % 2 == 0) Console.WriteLine ("The number is even");
    else  Console.WriteLine ("The number isn`t even");
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}



int number = Number();

Even(number);

Lutsenko();