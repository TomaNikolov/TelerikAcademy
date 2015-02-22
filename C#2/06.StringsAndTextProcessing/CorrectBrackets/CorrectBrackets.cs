
//Problem 3. Correct brackets

//    Write a program to check if in a given expression the brackets are put correctly.
//    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CorrectBrackets
{
    static void Main()
    {
        string inputExpression = ")(a+b))"; 
        //"((a+b)/5-d)"; 
        //Console.ReadLine();
        int rightBrackets = 0;
        int leftBrackets = 0;
        bool isCorrect = true;

        for (int i = 0; i < inputExpression.Length; i++)
        {
            if (leftBrackets > rightBrackets)
            {
                isCorrect = false; 
                break;
            } 
            if(inputExpression[i] == '(')
            {
                rightBrackets++;
            }
            if (inputExpression[i] == ')')
            {
                leftBrackets++;
            }
        }
        if(rightBrackets != leftBrackets)
        {
            isCorrect = false;
        }
        Console.WriteLine("Expression is {0}.", isCorrect? "correct" : "incorrect" );
    }
}

