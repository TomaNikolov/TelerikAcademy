﻿//Problem 1. Say Hello

//    Write a method that asks the user for his name and prints “Hello, <name>”
//    Write a program to test this method.



using System;

class SayHello
{
    static void Main()
    {
        AskForName();
    }

    private static void AskForName()
    {
        Console.Write("Please enter you name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
}

