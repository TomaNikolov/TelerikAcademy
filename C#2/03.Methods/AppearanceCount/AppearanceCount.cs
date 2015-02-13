
//Problem 4. Appearance count

//    Write a method that counts how many times given number appears in given array.
//    Write a test program to check if the method is workings correctly.


using System;

class AppearanceCount
{
    static void Main()
    {
        int[] arr = new int[9]{
        1, 2, 3, 4, 5, 6, 7, 8, 9
        };
        int appearNumber = 4;
        ApearanceCount(arr, appearNumber);
    }

    private static int ApearanceCount(int[] arr, int appearNumber)
    {
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == appearNumber)
            {
                result++;
            }
        }
        return result;
    }
}

