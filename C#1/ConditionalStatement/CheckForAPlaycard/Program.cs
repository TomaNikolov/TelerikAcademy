
//Classical play cards use the following signs to designate the card face: `2, 
//3,
//4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and 
//prints “yes” if it is a valid card sign or “no” otherwise. Examples:

using System;

namespace CheckForAPlaycard
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a card: ");
            string card = Console.ReadLine();
            string  deck ="2 3 4 5 6 7 8 9 10 J Q K A";
            if(deck.Contains(card))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
