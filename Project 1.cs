﻿using System;
public class Test
{
    public static void Main()
    {// your code here
     while (true)
        { 
            string text = Console.ReadLine();
            byte number = Convert.ToByte(text);
            if (number == 42)
            {
                break;
            }
            Console.WriteLine(number);
    }
}}