
//Problem 4. Sub-string in text

//    Write a program that finds how many times a sub-string is contained 
//    in a given text (perform case insensitive search).


using System;

class SubStringInText
{
    static void Main()
    {
        string inputText = @"We are living in an yellow submarine. We don't have anything 
                            else. inside the submarine is very tight. So we are
                            drinking all the day. We will move out of it in 5 days.";
        int index = 0;
        int inCounter = 0;

        while (index >= 0)
        {
           index = inputText.IndexOf("in", index);
            if(index >= 0)
            {
                inCounter++;
                index++;
            }
            
        }
        Console.WriteLine("The result is: {0}", inCounter);
    }
}

