﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

for (int i = 1; i <= number; i++) {
    if ((i % 2) == 0)  
    {
        Console.Write(i + ", ");
    }
}

Console.WriteLine("");