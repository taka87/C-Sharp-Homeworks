﻿using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        //int result = 0;
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }

        //Console.WriteLine(result);
    }
}