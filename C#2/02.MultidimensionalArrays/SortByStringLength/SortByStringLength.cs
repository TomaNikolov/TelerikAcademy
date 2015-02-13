
//Problem 5. Sort by string length

//    You are given an array of strings.
//    Write a method that sorts the array by the length of its elements 
//    (the number of characters composing them).

using System;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Enter size of array N:  ");
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write("Element {0}: ", i);
                words[i]= Console.ReadLine();
        }
        Console.WriteLine("Unsorted: " + string.Join(", ", words));
        SortArray(ref words); 
        Console.WriteLine("Sorted: " + string.Join(", ", words));
    }

    private static void SortArray(ref string[] words)
    {
        for (int i = 0; i < words.Length - 1; i++)
        {
            int min = i;
            for (int j =i + 1; j < words.Length; j++)
            {
                if(words[j].Length < words[min].Length)
                {
                    min = j;
                }
            }
                string temp = words[i];
                words[i] = words[min];
                words[min] = temp;
            
        }
    }
}

