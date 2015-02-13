
//Problem 3. Compare char arrays

//    Write a program that compares two char arrays lexicographically (letter by letter).


using System;

    class CompareCharArray
    {
        static void Main()
        {
            Console.Write("Enter first char array: ");
            string firstInputString = Console.ReadLine();
            Console.Write("Enter second char array: ");
            string secondInputString = Console.ReadLine();
            char[] firstArr = firstInputString.ToCharArray();
            char[] secondArr = secondInputString.ToCharArray();
            bool isEqual = true;
            int arrayLenght = 0;
            if( firstArr.Length <= secondArr.Length)
            {
                arrayLenght = firstArr.Length;
            }
            else
            {
                arrayLenght = secondArr.Length;
            }
            for (int i = 0; i < arrayLenght; i++)
            {
                if(firstArr[i] < secondArr[i])
                {
                    isEqual = false;
                    Console.WriteLine("The first char array is lexicografically before the second.");
                    break;
                }
                if (firstArr[i] > secondArr[i])
                {
                    isEqual = false;
                    Console.WriteLine("The second char array is lexicografically before the first.");
                    break;
                }
            }
            if(isEqual && firstArr.Length < secondArr.Length)
            {
                Console.WriteLine("The first char array is lexicografically before the second.");
            }
            if (isEqual && firstArr.Length > secondArr.Length)
            {
                Console.WriteLine("The second char array is lexicografically before the first.");
            }
            if (isEqual && firstArr.Length == secondArr.Length)
            {
                Console.WriteLine("Arrays are aqual");
            }

        }
    }

