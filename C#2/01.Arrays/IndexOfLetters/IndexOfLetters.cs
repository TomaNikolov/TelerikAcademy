
//Problem 12. Index of letters

//    Write a program that creates an array containing all letters
//    from the alphabet (A-Z).
//    Read a word from the console and print the index of each of
//    its letters in the array.


using System;
using System.Text;

class IndexOfLetters
{
    static void Main()
    {
        char[] letters = new char[26];
        int A = 65;
        StringBuilder indexer = new StringBuilder();
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = Convert.ToChar(A + i);
        }
        string inputWord = Console.ReadLine();
        string upperInput = inputWord.ToUpper();

        for (int i = 0; i < upperInput.Length; i++)
        {
            indexer.AppendFormat("[{0}], ",
             BinarySearchIndex(letters, upperInput[i], 0, letters.Length - 1));
        }
        Console.WriteLine(indexer.ToString());
    }

    private static int BinarySearchIndex(char[] arr, char key, int min, int max)
    {
        if (max < min)
        {
            return -1;
        }
        else
        {
            int mid = ((max - min) / 2) + min;
            if (arr[mid] > key)
            {
                return BinarySearchIndex(arr, key, min, mid - 1);
            }
            else if (arr[mid] < key)
            {
                return BinarySearchIndex(arr, key, mid + 1, max);
            }
            else
            {
                return mid;
            }
        }
    }

}
