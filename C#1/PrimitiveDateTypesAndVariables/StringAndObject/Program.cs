﻿using System;

namespace StringAndObject
{
    class Program
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object concatenation = hello + " " + world + "!";
            string typeCast = (string)concatenation;

            Console.WriteLine(typeCast);
        }
    }
}
