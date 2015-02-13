
//Problem 12. Subtracting polynomials

//    Extend the previous program to support also subtraction and
//    multiplication of polynomials.


using System;

class SubstactingPolinomials
{
    static void Main()
    {

        int[] firstPolinom = new int[] { 2, 3, 4 };
        Console.Write("First polinom coefficients : ");
        Print(firstPolinom);
        int[] secondPolinom = new int[] { 1, 3, 5 };
        Console.Write("Second polinom coefficients : ");
        Print(secondPolinom);
        int[] result = AddPolynomials(firstPolinom, secondPolinom);
        Console.Write("Adding polynomials : ");
        Print(result);
        result = SubstractPolynomials(firstPolinom, secondPolinom);
         Console.Write("Substacting polynomials : ");
        Print(result);
         result = MultiplicationPolynomials(firstPolinom, secondPolinom);
         Console.Write("Multiplication polynomials : ");
        Print(result);
    }
    private static void Print(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] != 0)
            {
                if (i == 0)
                {
                    Console.Write("{0} ", array[i]);
                }
                else if (i - 1 == 0)
                {
                    Console.Write("{0}x + ", array[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} + ", i, array[i]);
                }
            }
        }
        Console.WriteLine();
    }
    private static int[] AddPolynomials(int[] firstArr, int[] secondArr)
    {
        int[] result = new int[Math.Max(firstArr.Length, secondArr.Length)];
        Array.Reverse(firstArr);
        Array.Reverse(secondArr);
        for (int i = 0; i < result.Length; i++)
        {
            if (i < firstArr.Length)
            {
                result[i] += firstArr[i];
            }
            if (i < secondArr.Length)
            {
                result[i] += secondArr[i];
            }

        }
        Array.Reverse(result);
        return result;
    }
    private static int[] MultiplicationPolynomials(int[] firstArr, int[] secondArr)
    {
        int[] result = new int[Math.Max(firstArr.Length, secondArr.Length)];
        Array.Reverse(firstArr);
        Array.Reverse(secondArr);
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 1;
            if (i < firstArr.Length)
            {
                result[i] *= firstArr[i];
            }
            if (i < secondArr.Length)
            {
                result[i] *= secondArr[i];
            }

        }
        Array.Reverse(result);
        return result;
    }
    private static int[] SubstractPolynomials(int[] firstArr, int[] secondArr)
    {
        int[] result = new int[Math.Max(firstArr.Length, secondArr.Length)];
        Array.Reverse(firstArr);
        Array.Reverse(secondArr);
        for (int i = 0; i < result.Length; i++)
        {
            if (i < firstArr.Length)
            {
                result[i] -= firstArr[i];
            }
            if (i < secondArr.Length)
            {
                result[i] -= secondArr[i];
            }

        }
        Array.Reverse(result);
        return result;
    }
}


