
//Problem 20.* Variations of set

//    Write a program that reads two numbers N and K 
//    and generates all the variations of K elements from the set [1..N].


using System;

class VariationOfSet
{
    static void Main()
    {
        int n = 3; //int.Parse(Console.ReadLine());
        int k = 2; // int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
			{
                arr[i] = i + 1;
			}
        Variation(arr, new int[k], 0);
    }

    private static void Variation(int[] nums, int[] arr, int index)
    {
        
        if(index == arr.Length)
        {
            Console.WriteLine(string.Join(", ", arr));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            arr[index] = nums[i];
            Variation(nums, arr, index + 1);
        }
    }
}

