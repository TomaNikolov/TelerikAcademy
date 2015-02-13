
//Problem 2. Compare arrays

//    Write a program that reads two integer arrays from the console and compares them element by element.


using System;
using System.Linq;

    class CompareArraays
    {
        static void Main()
        {
            Console.WriteLine("Enter first array: ");
            string FirstInputString = Console.ReadLine();
            Console.WriteLine("Enter second array: ");
            string SeconfInputString = Console.ReadLine();
            bool isEqual = true;
            //Linq expression. See https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
            int[] arr1 = (from x in FirstInputString.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          select int.Parse(x)).ToArray();
            int[] arr2 = (from x in SeconfInputString.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          select int.Parse(x)).ToArray();
            if(arr1.Length != arr2.Length)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if(arr1[i] != arr2[i])
                    {
                        isEqual = false;
                        break;  
                    }
                }
                
            }
            Console.WriteLine("Arrays are{0} equal.", isEqual? "" : " not");
        }
    }

