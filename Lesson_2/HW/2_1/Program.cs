﻿// 1. Напишите программу, которая принимает на вход трёхзначное число
//    и на выходе показывает вторую цифру этого числа.

string NumSec(int num)
{   
    if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
        return $"{num / 10 % 10}";
    return "The number is not three-digit!";
}

int val = int.Parse(Console.ReadLine()!);
string result = NumSec(val);
Console.WriteLine(result);
