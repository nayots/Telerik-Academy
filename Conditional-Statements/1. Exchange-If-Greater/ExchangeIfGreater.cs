﻿using System;
/*
1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values
if the first one is greater than the second one. 
As a result print the values a and b, separated by a space.
*/
class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter the values for a and b each on a new line:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c;

        if (a > b)
        {
            c = b;
            b = a;
            a = c;
        }

        Console.WriteLine("{0} {1}",a ,b);
    }
}
