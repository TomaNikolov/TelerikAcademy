
//Problem 7. Encode/decode

//    Write a program that encodes and decodes a string using given encryption key (cipher).
//    The key consists of a sequence of characters.
//    The encoding/decoding is done by performing XOR (exclusive or) operation over the
      //first letter of the string with the first of the key, the second – with the second,
      //etc. When the last key character is reached, the next is the first.


using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter encryption key: ");
        string cipher = Console.ReadLine();
        Console.Write("Enter message: ");
        string message = Console.ReadLine();

        string encryptMassage = Enigma(cipher, message);
        Console.WriteLine("Result: {0}", encryptMassage);

    }

    private static string Enigma(string cipher, string message)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0, j = 0; i < message.Length; i++, j++)
        {
            if(j == cipher.Length)
            {
                j = 0;
            }
            result.Append(Convert.ToChar(message[i] ^ cipher[j]));

        }
        return result.ToString();
    }
}

